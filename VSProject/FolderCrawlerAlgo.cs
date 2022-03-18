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
            //public form and graph. can be accessed both by algo and form
            public static Graph outputGraph = new Graph("graph");
            public static GViewer viewer = new GViewer() {
                NavigationVisible = false,
                Dock = System.Windows.Forms.DockStyle.Top,
            };
        
            public static FolderCrawlerForm FolderCrawler = new FolderCrawlerForm();

            //for DFS. using global variable
            public static int selfidcounter;
        }
        public static void BFS(string path, string target, Boolean isAllOccurance)
        {
            //note, the parentid of the root node is -1. the id of the root node is 0

            //whoIsMyParent[child] = parent;
            Dictionary<int, int> whoIsMyParent = new Dictionary<int, int>();
            Boolean Found = false;

            // data yg disimpen di tiap tuple di queue adalah <parent id, self id, diretory full name>
            int idcounter = -1;
            Queue<Tuple<int, int, string>> myQueue = new Queue<Tuple<int, int, string>>();
            myQueue.Enqueue(new Tuple<int, int, string>(idcounter, ++idcounter, path));

            while (myQueue.Count != 0)
            {
                Tuple<int, int, string> currentNode = myQueue.Dequeue();
                whoIsMyParent.Add(currentNode.Item2, currentNode.Item1);
                string currentDirectory = currentNode.Item3;
                DirectoryInfo d = new DirectoryInfo(currentDirectory);
                if (Directory.Exists(currentDirectory))
                {
                    DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
                    FileInfo[] Files = d.GetFiles(); // getting files
                    foreach (DirectoryInfo directory in Directories)
                    {
                        myQueue.Enqueue(new Tuple<int, int, string>(currentNode.Item2, ++idcounter, directory.FullName));

                    }

                    foreach (FileInfo file in Files)
                    {
                        myQueue.Enqueue(new Tuple<int, int, string>(currentNode.Item2, ++idcounter, file.FullName));
                    }
                }
                



                //this is where you code the 'action'
                string outputName = currentNode.Item1 + ", " + currentNode.Item2 + ", " + d.Name;
                if(d.Name == target)
                {
                    outputName += "(target)";
                    Found = true;
                }

                

                //adding node and edge

                GlobalVariable.outputGraph.AddNode(currentNode.Item2.ToString()).Label.Text = outputName;

                if (currentNode.Item2 != 0)
                {
                    GlobalVariable.outputGraph.AddEdge(currentNode.Item1.ToString(), currentNode.Item2.ToString());
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
               

                // color everyone of it's parent
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
                   

                    child = Convert.ToInt32(whoIsMyParent[child]);
                }



                // realtime

                // System.Threading.Thread.Sleep(500);
                // outputing to graph
                GlobalVariable.viewer.Graph =  GlobalVariable.outputGraph;
                // refresh 
                GlobalVariable.FolderCrawler.outputPanelRefresher();


                // break if found and not all occurance
                if (Found && !isAllOccurance)
                {
                    break;
                }
            }
        }
        public static void DFSCaller(string path, string target, Boolean isAllOccurance)
        {
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
        public static Boolean DFS(int parentid, string path, string target, Boolean isAllOccurance) // return true if found
        {
            
            Boolean isFound = false; //true if any of the directories inside path contain target or the directory itself contains target
            DirectoryInfo d = new DirectoryInfo(path);

            DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
            FileInfo[] Files = d.GetFiles(); // getting files
            //create root
            if (parentid == -1) //if root
            {
                GlobalVariable.outputGraph.AddNode("0").Label.Text = parentid + ",0 , " + d.Name;
                GlobalVariable.selfidcounter = 0;
                parentid = 0;
            }

            //THIS CHUNK OF CODE IS TO COVER IS SEARCHING FOR DIRECTORY START
            if (d.Name == target)
            {
                GlobalVariable.outputGraph.FindNode(GlobalVariable.selfidcounter.ToString()).Label.Text += " (Target)";
                isFound = true;
                GlobalVariable.outputGraph.FindNode(GlobalVariable.selfidcounter.ToString()).Label.FontColor = Color.Blue;
            }

            //THIS CHUNK OF CODE IS TO COVER IS SEARCHING FOR DIRECTORY DONE




            //intentionaly prioritizing directory above file, so that the difference between dfs and bfs more noticable
            foreach (DirectoryInfo directory in Directories)
            {
                //this is where you code the 'action'

                GlobalVariable.selfidcounter++;
                int selfid = GlobalVariable.selfidcounter;
                GlobalVariable.outputGraph.AddNode(selfid.ToString()).Label.Text = parentid + "," + selfid + ", " + directory.Name;
                //connect to parent
                GlobalVariable.outputGraph.AddEdge(parentid.ToString(), selfid.ToString());

                

                Boolean isInsideFound; // to hold each one of the directory result
                isInsideFound = DFS(selfid, @directory.FullName, target, isAllOccurance);

                //coloring
                //ifInsideFound, means that the right target file is within me. color me blue
                //else, if my color is not blue, color me red
                GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.Text += isInsideFound.ToString();

                if (isInsideFound)
                {
                    isFound = true;
                    GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.FontColor = Color.Blue;
                }
                else
                {
                    if (GlobalVariable.outputGraph.FindNode(GlobalVariable.selfidcounter.ToString()).Label.FontColor != Color.Blue)
                    {
                        GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.FontColor = Color.Red;
                    }
                    //else color me black, which is default
                }

                

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
                if (file.Name == target)
                {
                    outputName += " (Target)";
                    isFound = true;
                    GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.FontColor = Color.Blue;
                }
               
                else
                {
                    GlobalVariable.outputGraph.FindNode(selfid.ToString()).Label.FontColor = Color.Red;

                }


                //connect to parent
                GlobalVariable.outputGraph.AddEdge(parentid.ToString(), selfid.ToString());
            }
          
            return isFound;
        }
    }
}
