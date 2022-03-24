using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
namespace VSProject
{
    public partial class FolderCrawlerForm : Form
    {
        
        [STAThread]
        public static void Main()
        {
            // Starts the application.
            //bind the graph to the viewer 
            FolderCrawlerAlgo.GlobalVariable.viewer.Graph = FolderCrawlerAlgo.GlobalVariable.outputGraph;

            //associate the viewer with the form 
            FolderCrawlerAlgo.GlobalVariable.FolderCrawler.SuspendLayout();


            FolderCrawlerAlgo.GlobalVariable.FolderCrawler.OutputPanel.Controls.Add(FolderCrawlerAlgo.GlobalVariable.viewer);
            Application.Run(FolderCrawlerAlgo.GlobalVariable.FolderCrawler);


        }

        public FolderCrawlerForm()
        {
            InitializeComponent();
        }


       
        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                LabelDirectory.Text = folderBrowserDialog1.SelectedPath;
           

            }

        }

        private void LabelDirectory_Click(object sender, EventArgs e)
        {

        }


        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckBoxFindAllOccurance(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(LabelDirectory.Text != "")
            {
                //clean timer
                LabelTimer.Text = "Time Taken ";
                //start timer
                DateTime start = DateTime.Now;
                if (DFSButton.Checked == true)
                {//clearing the graph
                    foreach (Node node in FolderCrawlerAlgo.GlobalVariable.outputGraph.Nodes.ToArray())
                    {
                        FolderCrawlerAlgo.GlobalVariable.outputGraph.RemoveNode(node);
                    }

                    foreach (Edge edge in FolderCrawlerAlgo.GlobalVariable.outputGraph.Edges.ToArray())
                    {
                        FolderCrawlerAlgo.GlobalVariable.outputGraph.RemoveEdge(edge);
                    }
                    //clearing listbox
                    ListBoxOutput.Items.Clear();

                    //setup
                    FolderCrawlerAlgo.GlobalVariable.selfidcounter = 0;

                    //run the algorithm
                    FolderCrawlerAlgo.DFSCaller(LabelDirectory.Text, TargetFilename.Text, IsAllOccuranceCheckBox.Checked);
           


                    // outputing to graph
                    FolderCrawlerAlgo.GlobalVariable.viewer.Graph = FolderCrawlerAlgo.GlobalVariable.outputGraph;
                }
                else if (BFSButton.Checked == true)
                {//clearing the graph
                    foreach (Node node in FolderCrawlerAlgo.GlobalVariable.outputGraph.Nodes.ToArray())
                    {
                        FolderCrawlerAlgo.GlobalVariable.outputGraph.RemoveNode(node);
                    }

                    foreach (Edge edge in FolderCrawlerAlgo.GlobalVariable.outputGraph.Edges.ToArray())
                    {
                        FolderCrawlerAlgo.GlobalVariable.outputGraph.RemoveEdge(edge);
                    }
                    //clearing listbox
                    ListBoxOutput.Items.Clear();

                    //run the algorithm
                    FolderCrawlerAlgo.BFS(LabelDirectory.Text, TargetFilename.Text, IsAllOccuranceCheckBox.Checked);

                    // outputing to graph
                    FolderCrawlerAlgo.GlobalVariable.viewer.Graph = FolderCrawlerAlgo.GlobalVariable.outputGraph;
                }
                //stop timer
                TimeSpan duration = DateTime.Now.Subtract(start);
                //update timer to label
                LabelTimer.Text += duration.TotalSeconds.ToString();
                LabelTimer.Text += " s";
            }
            //else, belum ada directory yg dipilih

        }

        private void DFSButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BFSButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabelTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = @"C:\Users\Asus\Documents\WPA Files",
                FileName = "explorer.exe",
            };

            //Process.Start(startInfo);
            //ListBoxOutput.Items.Add(@"C:\Users\Asus\Documents\WPA Files");
            //ListBoxOutput.Items.Add(@"C: \Users\Asus\Documents");

            System.Object[] ItemObject = new System.Object[10];
            for (int i = 0; i <= 9; i++)
            {
                ItemObject[i] = "Item" + i;
            }
            ListBoxOutput.Items.Add("T");

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(ListBoxOutput.SelectedIndex != -1)
            {
                string path = ListBoxOutput.SelectedItem.ToString();
                string parent = Directory.GetParent(path).FullName;

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = parent,
                    FileName = "explorer.exe",
                };

                //MessageBox.Show(path);
                Process.Start(startInfo);
            }
            //else, belum ada yg dipilih
        }



        //HELPER FUNCTION
        public void outputPanelRefresher() //buat realtime. sejauh ini masih gagal
        {
            FolderCrawlerAlgo.GlobalVariable.FolderCrawler.OutputPanel.Update();
        }
        
        public void listBoxPathAdder(string path) // buat nambahin path baru ke list box
        {
            ListBoxOutput.Items.Add(path);

        }

        private void BackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
