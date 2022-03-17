using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
namespace VSProject
{
    public partial class FolderCrawlerAlgo
    {
        public static class GlobalVariable
        {
            public static Graph outputGraph = new Graph("graph");
            public static GViewer viewer = new GViewer();
            public static int selfidcounter;
        }
        public static void BFS(string path)
        {
            // data yg disimpen di tiap tuple di queue adalah <parent id, self id, diretory full name>
            int idcounter = 0;
            Queue<Tuple<int, int, string>> myQueue = new Queue<Tuple<int, int, string>>();
            myQueue.Enqueue(new Tuple<int, int, string>(idcounter, idcounter, path));

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
                        myQueue.Enqueue(new Tuple<int, int, string>(currentNode.Item2, ++idcounter, directory.FullName));

                    }

                    foreach (FileInfo file in Files)
                    {
                        myQueue.Enqueue(new Tuple<int, int, string>(currentNode.Item2, ++idcounter, file.FullName));
                    }
                }

                //this is where you code the 'action'
                GlobalVariable.outputGraph.AddNode(currentNode.Item2.ToString()).Label.Text = currentNode.Item1 + ", " + currentNode.Item2 + ", " + d.Name;
                if (currentNode.Item2 != 0)
                {
                    GlobalVariable.outputGraph.AddEdge(currentNode.Item1.ToString(), currentNode.Item2.ToString());
                }
            }
        }
        public static void DFS(int parentid, string path, string target)
        {
            DirectoryInfo d = new DirectoryInfo(path);

            DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
            FileInfo[] Files = d.GetFiles(); // getting files
            //create root
            if (GlobalVariable.selfidcounter == 0)
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


                DFS(GlobalVariable.selfidcounter, @directory.FullName, target);
            }

            foreach (FileInfo file in Files)
            {
                //this is where you code the 'action'
                GlobalVariable.selfidcounter++;
                string outputName = file.Name;
                if (file.Name == target)
                {
                    outputName += " (Target)";
                }
                GlobalVariable.outputGraph.AddNode(GlobalVariable.selfidcounter.ToString()).Label.Text = parentid + "," + GlobalVariable.selfidcounter + ", " + outputName;
                //connect to parent
                GlobalVariable.outputGraph.AddEdge(parentid.ToString(), GlobalVariable.selfidcounter.ToString());
            }
        }
    }
}
