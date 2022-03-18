using System;
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
            Console.WriteLine("fuck the World!");
            Console.WriteLine("this is the program entry point! im not sure this thing will show up");
            


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
        public void outputPanelRefresher()
        {
            FolderCrawlerAlgo.GlobalVariable.FolderCrawler.OutputLabel.Update();
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

                //setup
                FolderCrawlerAlgo.GlobalVariable.selfidcounter = 0;

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

                //run the algorithm
                FolderCrawlerAlgo.BFS(LabelDirectory.Text, TargetFilename.Text, IsAllOccuranceCheckBox.Checked);

                // outputing to graph
                FolderCrawlerAlgo.GlobalVariable.viewer.Graph = FolderCrawlerAlgo.GlobalVariable.outputGraph;
            }

        }

        private void DFSButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BFSButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
