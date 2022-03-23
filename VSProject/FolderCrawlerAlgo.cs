using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
namespace VSProject
{
    public partial class FolderCrawlerAlgo
    {
        public static class GlobalVariable
        {
            // Inisialisasi Form dan Graf, dibuat public agar dapat diakses oleh FolderCrawlerForm dan FolderCrawlerAlgo
            public static Graph outputGraph = new Graph("graph");
            public static GViewer viewer = new GViewer() {
                NavigationVisible = false,
                Dock = System.Windows.Forms.DockStyle.Top,
            };
        
            public static FolderCrawlerForm FolderCrawler = new FolderCrawlerForm();

            public static int selfidcounter;
            // Sintaks untuk memakai kode berikut : edgeToPrent[child] = edgeToParent;
            public static Dictionary<int, Edge> DFSedgeToParent = new Dictionary<int, Edge>();
        }
        public static void BFS(string path, string target, Boolean isAllOccurance)
        {
            //note, the parentid of the root node is -1. the id of the root node is 0

            // Sintaks untuk memakai kode berikut : whoIsMyParent[child] = parent;
            Dictionary<int, int> whoIsMyParent = new Dictionary<int, int>();
            // Sintaks untuk memakai kode berikut : edgeToPrent[child] = edgeToParent;
            Dictionary<int, Edge> edgeToParent = new Dictionary<int, Edge>();
            // Penanda sudah ditemukannya file dengan filename yang sesuai
            Boolean Found = false;

            // Data yg disimpen di tiap tuple pada queue adalah <parent id, self id, diretory full name>
            // Parent ID untuk simpul root folder adalah -1, Self ID untuk simpul root folder adalah 0
            // Parent ID digunakan untuk melihat relasi parent-child antar simpul
            // Self ID digunakan untuk melihat urutan pengecekan simpul pada graf
            int idcounter = -1;
            Queue<Tuple<int, int, string>> myQueue = new Queue<Tuple<int, int, string>>();
            myQueue.Enqueue(new Tuple<int, int, string>(idcounter, ++idcounter, path));

            // Pada awal, akan di enqueue parent id (-1), self id (0), dan path dari directory awal
            // Selanjutnya, mengikuti aturan BFS, akan ditambahkan path untuk subdirectory dan file-file yang berada di dalam simpul yang sedang diperiksa
            // Jika simpul yang diperiksa mengandung subdirectory atau file, maka path untuk mengakses subdirectory dan file tersebut akan ditambahkan ke dalam queue
            // Untuk setiap folder baru, parent id akan bertambah 1. File yang berada di dalam folder baru tersebut akan memiliki parent id yang sama dengan folder asalnya
            // Pada kasus dimana terdapat subdirectory DAN file pada sebuah folder, path subdirectory/folder akan terlebih dahulu ditambahkan ke dalam queue
            // Proses ini akan berlanjut sampai queue kosong atau sampai semua simpul selesai diperiksa.

            while (myQueue.Count != 0)
            {
                Tuple<int, int, string> currentNode = myQueue.Dequeue();
                whoIsMyParent.Add(currentNode.Item2, currentNode.Item1);
                string currentDirectory = currentNode.Item3;
                DirectoryInfo d = new DirectoryInfo(currentDirectory);
                if (Directory.Exists(currentDirectory))
                {
                    DirectoryInfo[] Directories = d.GetDirectories(); // Untuk mendapatkan semua subdirectory di dalam simpul yang diperiksa
                    FileInfo[] Files = d.GetFiles(); // Untuk mendapatkan semua file di dalam simpul yang diperiksa (jika simpul yang diperiksa kosong, maka dikembalikan null)
                    foreach (DirectoryInfo directory in Directories)
                    {
                        myQueue.Enqueue(new Tuple<int, int, string>(currentNode.Item2, ++idcounter, directory.FullName));

                    }

                    foreach (FileInfo file in Files)
                    {
                        myQueue.Enqueue(new Tuple<int, int, string>(currentNode.Item2, ++idcounter, file.FullName));
                    }
                }
                



                // Snippet kode untuk melakukan pengecekan apakah filename sesuai atau tidak
                string outputName = currentNode.Item1 + ", " + currentNode.Item2 + ", " + d.Name;
                if(d.Name == target)
                {
                    outputName += "(target)";
                    Found = true;
                    GlobalVariable.FolderCrawler.listBoxPathAdder(d.FullName);
                }

                

                // Menambahkan simpul ke dalam graph
                GlobalVariable.outputGraph.AddNode(currentNode.Item2.ToString()).Label.Text = outputName;

                if (currentNode.Item2 != 0)
                {
                    //hubungin bapak ke anak. jangan dibalik, nti graphnya ikut kebalik
                    Edge newEdge = GlobalVariable.outputGraph.AddEdge(currentNode.Item1.ToString(), currentNode.Item2.ToString());
                    edgeToParent.Add(currentNode.Item2, newEdge);
                }


                //check what color should that node be
                // if it's a file and it's not a target OR if it's a folder without anak2, give it red. 
                // if it's a file and it's a target, give it blue.
                // else give it black.

                //the above condition doesn't work if we want to be able to search for folder name
                // here's the condition if we want to be able to search folder name
                // default color is black
                // if it has the same name as target, give it blue.
                // else, if it's a file OR it's a directory with no children, give it red. 
                
                //ini pake opsi yg kedua, bisa handle nama folder
                Color color = Color.Black;
                if (d.Name == target)
                
                {
                    color = Color.Blue;
                }
                else
                {
                    if ((Directory.Exists(currentDirectory) && !Directory.EnumerateFileSystemEntries(currentDirectory).Any() )|| !Directory.Exists(currentDirectory))
                    { // this will give true if directory is empty
                        color = Color.Red;
                    }
                }
               

                // color itself (anak), it's parent(bapak), and it's parent's parent(kakek), (kakek buyut), dst
                // priority blue, red, black. if while coloring, it encounter a node with higher priority, it will stop
                int child = currentNode.Item2;
                while(child != -1)
                {
                    //if the color is black, and the node which will be colored is red or blue, stop coloring
                    if(color == Color.Black && (GlobalVariable.outputGraph.FindNode(child.ToString()).Label.FontColor == Color.Red || GlobalVariable.outputGraph.AddNode(child.ToString()).Label.FontColor == Color.Blue))
                    {
                        break;
                    }
                    //if the color is red, and the node which will be colored is blue, stop coloring
                    if(color == Color.Red && GlobalVariable.outputGraph.FindNode(child.ToString()).Label.FontColor == Color.Blue){
                        break;
                    }
                    GlobalVariable.outputGraph.FindNode(child.ToString()).Label.FontColor = color;


                   
                    //updating edge. try to use it by id, not working. jadinya ya gini, di delete dulu trus ditambahin lagi. sadly begini
                    int parent = whoIsMyParent[child];
                    if (child != 0)
                    {
                        Edge prevEdge = edgeToParent[child];
                        GlobalVariable.outputGraph.RemoveEdge(prevEdge);
                        Edge newEdge = GlobalVariable.outputGraph.AddEdge(parent.ToString(), child.ToString());
                        edgeToParent.Remove(child);
                        edgeToParent.Add(child, newEdge);
                        newEdge.Attr.Color = color;
                    }

                    child = parent;
                }




                // Untuk menghasilkan graf realtime
                System.Threading.Thread.Sleep(700);
                GlobalVariable.viewer.Graph =  GlobalVariable.outputGraph;
                GlobalVariable.FolderCrawler.outputPanelRefresher();
          


                // break if found and not isAllOccurance
                if (Found && !isAllOccurance)
                {
                    break;
                }
            }
        }
        public static void DFSCaller(string path, string target, Boolean isAllOccurance)
        {
            // same as BFS, the parentid of the root folder is -1. the id of the root node is 0

            // clean dictionary for new DFS call
            GlobalVariable.DFSedgeToParent.Clear();

            Boolean FoundHolder = FolderCrawlerAlgo.DFS(-1, path, target, isAllOccurance);
            if (FoundHolder)
            {
                GlobalVariable.outputGraph.FindNode("0").Label.FontColor = Color.Blue;
            }
            else
            {
                GlobalVariable.outputGraph.FindNode("0").Label.FontColor = Color.Red;

            }
        }
        public static Boolean DFS(int parentid, string path, string target, Boolean isAllOccurance) // return true if file found
        {
            
            Boolean isFound = false; //true if any of the directories inside path contain target or the directory itself contains target
            DirectoryInfo d = new DirectoryInfo(path);

            DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
            FileInfo[] Files = d.GetFiles(); // getting files

            if (parentid == -1) // kalau simpul yang diperiksa adalah simpul awal
            {
                GlobalVariable.outputGraph.AddNode("0").Label.Text = parentid + ",0 , " + d.Name;
                GlobalVariable.selfidcounter = 0;
                parentid = 0;
            }
        

            //THIS CHUNK OF CODE IS TO COVER SEARCHING FOR DIRECTORY
            if (d.Name == target)
            {
                GlobalVariable.outputGraph.FindNode(GlobalVariable.selfidcounter.ToString()).Label.Text += " (Target)";
                
                GlobalVariable.FolderCrawler.listBoxPathAdder(d.FullName);
                GlobalVariable.outputGraph.FindNode(GlobalVariable.selfidcounter.ToString()).Label.FontColor = Color.Blue;
                

                isFound = true;
                if (!isAllOccurance)
                {
                    return true;
                }
            }
            //THIS CHUNK OF CODE IS TO COVER SEARCHING FOR DIRECTORY




            //intentionaly prioritizing directory above file, so that the difference between dfs and bfs more noticable
            foreach (DirectoryInfo directory in Directories)
            {
                //this is where you code the 'action'

                GlobalVariable.selfidcounter++;
                int selfid = GlobalVariable.selfidcounter;
                GlobalVariable.outputGraph.AddNode(selfid.ToString()).Label.Text = parentid + "," + selfid + ", " + directory.Name;
                //hubngin ke node atas dia
                //GlobalVariable.outputGraph.AddEdge(parentid.ToString(), selfid.ToString());



                //connect to parent and catet edge to parent
                Edge newEdge = GlobalVariable.outputGraph.AddEdge(parentid.ToString(), selfid.ToString());
                GlobalVariable.DFSedgeToParent.Add(selfid, newEdge);



                //adding realtime
                GlobalVariable.viewer.Graph = GlobalVariable.outputGraph;
                GlobalVariable.FolderCrawler.outputPanelRefresher();
                System.Threading.Thread.Sleep(700);



                Boolean isInsideFound; // to hold each one of the directory result
                isInsideFound = DFS(selfid, @directory.FullName, target, isAllOccurance);

                //coloring
                //ifInsideFound, means that the right target file is within me. color me blue
                //else, if my color is not blue, color me red
                //GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.Text += isInsideFound.ToString();

                Color color = Color.Black;
                if (isInsideFound)
                {
                    isFound = true;
                    color = Color.Blue;
                }
                else
                {
                    if (GlobalVariable.outputGraph.FindNode(GlobalVariable.selfidcounter.ToString()).Label.FontColor != Color.Blue)
                    {
                        color = Color.Red;
                    }
                    //else color me black, which is default
                }
                GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.FontColor = color;

                //update edge color
                Edge prevEdge = GlobalVariable.DFSedgeToParent[selfid];
                GlobalVariable.outputGraph.RemoveEdge(prevEdge);
                Edge newColoredEdge = GlobalVariable.outputGraph.AddEdge(parentid.ToString(), selfid.ToString());
                GlobalVariable.DFSedgeToParent.Remove(selfid);
                GlobalVariable.DFSedgeToParent.Add(selfid, newColoredEdge);
                newColoredEdge.Attr.Color = color;


                //deciding whether should continue searching
                if (isInsideFound && !isAllOccurance)
                {
                    return true;
                }
                
            }

            foreach (FileInfo file in Files)
            {
                //this is where you code the 'action'
                GlobalVariable.selfidcounter++;
                int selfid = GlobalVariable.selfidcounter;
                string outputName = file.Name;
                GlobalVariable.outputGraph.AddNode(selfid.ToString()).Label.Text = parentid + "," + selfid + ", " + outputName;

                //coloring
                Color color = Color.Red;
                if (file.Name == target)
                {
                    outputName += " (Target)";
                    isFound = true;
                    GlobalVariable.FolderCrawler.listBoxPathAdder(file.FullName);
                    color = Color.Blue;
                }
               
                    
                GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.FontColor = color;



                //connect to parent
                GlobalVariable.outputGraph.AddEdge(parentid.ToString(), selfid.ToString()).Attr.Color = color;
            
                //adding realtime
                System.Threading.Thread.Sleep(700);
                GlobalVariable.viewer.Graph = GlobalVariable.outputGraph;
                GlobalVariable.FolderCrawler.outputPanelRefresher();
            }
          
            return isFound;
        }
    }
}
