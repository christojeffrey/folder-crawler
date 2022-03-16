using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
namespace VSProject
{
    public partial class Form1 : Form
    {
        static class GlobalVariable
        {
          
            public static Graph outputGraph = new Graph("graph");
            public static GViewer viewer = new GViewer();
            public static int selfidcounter;
        }
        [STAThread]
        public static void Main(string[] args)
        {
            // Starts the application.
            Console.WriteLine("fuck the World!");
            Console.WriteLine("this is the program entry point! im not sure this thing will show up");
            Form1 FolderCrawler = new Form1();

  

            //bind the graph to the viewer 
            GlobalVariable.viewer.Graph = GlobalVariable.outputGraph;
            //associate the viewer with the form 
            FolderCrawler.SuspendLayout();
            GlobalVariable.viewer.Dock = DockStyle.Fill;
            FolderCrawler.Controls.Add(GlobalVariable.viewer);


            Application.Run(FolderCrawler);
        }
        public static void BFS(string path)
        {
            // data yg disimpen di tiap tuple di queue adalah <parent id, self id, diretory full name>
            int idcounter = 0;
            Queue<Tuple<int,int, string>> myQueue = new Queue<Tuple<int,int, string>>();
            myQueue.Enqueue(new Tuple<int,int, string>(idcounter,idcounter, path));

            while (myQueue.Count != 0)
            {
                Tuple<int, int, string> currentNode = myQueue.Dequeue();
                string currentDirectory = currentNode.Item3;
                DirectoryInfo d = new DirectoryInfo(currentDirectory);
                if (Directory.Exists(currentDirectory))
                {
                    DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
                    FileInfo[] Files = d.GetFiles(); // getting files
                    foreach (DirectoryInfo directory in Directories)
                    {
                        myQueue.Enqueue(new Tuple<int,int, string>(currentNode.Item2,++idcounter,directory.FullName));

                    }

                    foreach (FileInfo file in Files)
                    {
                        myQueue.Enqueue(new Tuple<int,int , string>(currentNode.Item2, ++idcounter, file.FullName));
                    }
                }

                //this is where you code the 'action'
                GlobalVariable.outputGraph.AddNode(currentNode.Item2.ToString()).Label.Text = currentNode.Item1 + ", " + currentNode.Item2 + ", "+  d.Name;
                if(currentNode.Item2 != 0)
                {
                    GlobalVariable.outputGraph.AddEdge(currentNode.Item1.ToString(), currentNode.Item2.ToString());
                }
            }
        }

        public static void DFS(int parentid, string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);

            DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
            FileInfo[] Files = d.GetFiles(); // getting files
            //create root
            if(GlobalVariable.selfidcounter == 0)
            {
                GlobalVariable.outputGraph.AddNode(GlobalVariable.selfidcounter.ToString()).Label.Text = parentid + "," + GlobalVariable.selfidcounter + ", " + d.Name;
            }

            foreach (DirectoryInfo directory in Directories)
            {
                //this is where you code the 'action'
                GlobalVariable.selfidcounter++;
                GlobalVariable.outputGraph.AddNode(GlobalVariable.selfidcounter.ToString()).Label.Text = parentid + "," + GlobalVariable.selfidcounter + ", " + directory.Name;
                //connect to parent
                GlobalVariable.outputGraph.AddEdge(parentid.ToString(), GlobalVariable.selfidcounter.ToString());


                DFS(GlobalVariable.selfidcounter, @directory.FullName);
            }

            foreach (FileInfo file in Files)
            {
                //this is where you code the 'action'
                GlobalVariable.selfidcounter++;
                GlobalVariable.outputGraph.AddNode(GlobalVariable.selfidcounter.ToString()).Label.Text = parentid + "," + GlobalVariable.selfidcounter + ", " + file.Name;
                //connect to parent
                GlobalVariable.outputGraph.AddEdge(parentid.ToString(), GlobalVariable.selfidcounter.ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            //GlobalVariable.outputGraph.AddNode(GlobalVariable.counter.ToString()).Label.Text = "testing";
            //GlobalVariable.outputGraph.AddEdge("1", "2");


            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
           
            if (result == DialogResult.OK)
            {
                lblDirectory.Text = folderDlg.SelectedPath;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
      
        private void btnBFS_Click(object sender, EventArgs e)
        {

            //clearing the graph
            foreach (Node node in GlobalVariable.outputGraph.Nodes.ToArray())
            {
                GlobalVariable.outputGraph.RemoveNode(node);
            }

            foreach (Edge edge in GlobalVariable.outputGraph.Edges.ToArray())
            {
                GlobalVariable.outputGraph.RemoveEdge(edge);
            }

            //run the algorithm
            BFS(@lblDirectory.Text);
           
            // outputing to graph
            GlobalVariable.viewer.Graph = GlobalVariable.outputGraph;

        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            //clearing the graph
            foreach (Node node in GlobalVariable.outputGraph.Nodes.ToArray())
            {
                GlobalVariable.outputGraph.RemoveNode(node);
            }

            foreach (Edge edge in GlobalVariable.outputGraph.Edges.ToArray())
            {
                GlobalVariable.outputGraph.RemoveEdge(edge);
            }

            //setup
            GlobalVariable.selfidcounter = 0;

            DFS(0, @lblDirectory.Text);
           
            // outputing to graph
            GlobalVariable.viewer.Graph = GlobalVariable.outputGraph;
        }
    }
}
