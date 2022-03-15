using System.IO;
using System.Collections;
using System.Collections.Generic;
namespace FolderCrawling
{
    class Program
    {



        public static void Main()
        {
            System.Console.WriteLine("fuck the World!");
            System.Console.WriteLine("this is the program entry point!");


            string path = @"C:\Users\Asus\Desktop\tubes stima dua\testing";
     
            // implementasi DFS
            //DFS(path);

            // implementasi BFS
            //BFS(path);


        }
        public static void BFS(string path)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue(path);
            while (myQueue.Count != 0)
            {
                string currentDirectory = myQueue.Dequeue();
                DirectoryInfo d = new DirectoryInfo(currentDirectory);
                if (Directory.Exists(currentDirectory))
                {
                    DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
                    FileInfo[] Files = d.GetFiles(); // getting files
                    foreach (DirectoryInfo directory in Directories)
                    {
                        myQueue.Enqueue(@directory.FullName);
                    }

                    foreach (FileInfo file in Files)
                    {
                        myQueue.Enqueue(file.FullName);
                    }
                }
                System.Console.WriteLine(d.Name, "\n");
            }
        }
        public static void DFS(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);

            DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
            FileInfo[] Files = d.GetFiles(); // getting files

            foreach (DirectoryInfo directory in Directories)
            {
                System.Console.WriteLine(directory.Name, "\n");
                DFS(@directory.FullName);
            }

            foreach (FileInfo file in Files)
            {
                System.Console.WriteLine(file.Name, "\n");
            }
        }
    }
}
