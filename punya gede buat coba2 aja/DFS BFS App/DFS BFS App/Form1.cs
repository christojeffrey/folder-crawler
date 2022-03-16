using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFS_BFS_App
{
    public partial class Form1 : Form
    {
        public string userSelectedPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FolderChooserButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new()
            {
                ShowNewFolderButton = true
            };
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryLabel.Text = folderDlg.SelectedPath;
                userSelectedPath = folderDlg.SelectedPath;
                _ = folderDlg.RootFolder;
            }
        }

        private void StartSearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputFilename.Text))
            {
                string message = "Please Fill The InputFilename TextBox";
                string title = "Empty Searched FileName";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            } else
            {
                TraversalListBox.Items.Clear();
                if (BFSButton.Checked)
                {
                    BFSSearch(userSelectedPath, InputFilename.Text);
                }
                else if (DFSButton.Checked)
                {
                    DFSSearch(userSelectedPath, InputFilename.Text);
                }
            }
        }

        public void DFSSearch(string DirectoryPath, string SearchedFileName)
        {

        }

        public void BFSSearch(string DirectoryPath, string SearchedFileName)
        {
            List<string> pathDirectoryQueue = new List<string>();
            pathDirectoryQueue.Add(DirectoryPath);
            while (pathDirectoryQueue.FirstOrDefault() != null)
            {
                string currentDirectory = pathDirectoryQueue.First();
                string[] subdirectoryEntries = Directory.GetDirectories(currentDirectory);
                foreach (string subDirectory in subdirectoryEntries)
                {
                    pathDirectoryQueue.Add(subDirectory);
                    var subDirectoryName = new DirectoryInfo(subDirectory).Name;
                    string subDirNameFolder = subDirectoryName.ToString() + " (Folder)";
                    TraversalListBox.Items.Add(subDirNameFolder);
                }
                string[] filesEntries = Directory.GetFiles(currentDirectory);
                foreach (string files in filesEntries)
                {
                    string filename = "";
                    if (Path.GetFileName(files) == SearchedFileName)
                    {
                        filename = Path.GetFileName(files) + " (Target File)";
                    } else
                    {
                        filename = Path.GetFileName(files) + " (File)";
                    }
                    TraversalListBox.Items.Add(filename);
                }
                pathDirectoryQueue.RemoveAt(0);
            }
        }
    }
}
