using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace VSProject
{
    public partial class Form1 : Form
    {
        static class GlobalVariable
        {
            public static string output = "";
        }
        [STAThread]
        public static void Main(string[] args)
        {
            // Starts the application.
            System.Console.WriteLine("fuck the World!");
            System.Console.WriteLine("this is the program entry point! im not sure this thing will show up");
            Form1 FolderCrawler = new Form1();
            Application.Run(FolderCrawler);
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

                //this is where you code the 'action'
                GlobalVariable.output = GlobalVariable.output + d.Name + "\n";
            }
        }

        public static void DFS(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);

            DirectoryInfo[] Directories = d.GetDirectories(); // getting directories
            FileInfo[] Files = d.GetFiles(); // getting files

            foreach (DirectoryInfo directory in Directories)
            {
                //this is where you code the 'action'
                GlobalVariable.output = GlobalVariable.output + directory.Name + "\n";
                DFS(@directory.FullName);
            }

            foreach (FileInfo file in Files)
            {
                //this is where you code the 'action'
                GlobalVariable.output = GlobalVariable.output + file.Name + "\n";
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
            GlobalVariable.output = "";
            BFS(@lblDirectory.Text);
            lblOutput.Text = GlobalVariable.output;
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            GlobalVariable.output = "";
            DFS(@lblDirectory.Text);
            lblOutput.Text = GlobalVariable.output;
        }
    }
}
