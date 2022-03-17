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
            FolderCrawlerForm FolderCrawler = new FolderCrawlerForm();


            //bind the graph to the viewer 
            FolderCrawlerAlgo.GlobalVariable.viewer.Graph = FolderCrawlerAlgo.GlobalVariable.outputGraph;
            //associate the viewer with the form 
            FolderCrawler.SuspendLayout();
            FolderCrawlerAlgo.GlobalVariable.viewer.Dock = DockStyle.Fill;
            FolderCrawler.Controls.Add(FolderCrawlerAlgo.GlobalVariable.viewer);

            Application.Run(FolderCrawler);
        }
        
        public FolderCrawlerForm()
        {
            InitializeComponent();
        }

        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                LabelDirectory.Text = folderDlg.SelectedPath;
            }
        }
        private void BFSButton_Click(object sender, EventArgs e)
        {

            //clearing the graph
            foreach (Node node in FolderCrawlerAlgo.GlobalVariable.outputGraph.Nodes.ToArray())
            {
                FolderCrawlerAlgo.GlobalVariable.outputGraph.RemoveNode(node);
            }

            foreach (Edge edge in FolderCrawlerAlgo.GlobalVariable.outputGraph.Edges.ToArray())
            {
                FolderCrawlerAlgo.GlobalVariable.outputGraph.RemoveEdge(edge);
            }

            //run the algorithm
            FolderCrawlerAlgo.BFS(LabelDirectory.Text);

            // outputing to graph
            FolderCrawlerAlgo.GlobalVariable.viewer.Graph = FolderCrawlerAlgo.GlobalVariable.outputGraph;

        }

        private void DFSButton_Click(object sender, EventArgs e)
        {
            //clearing the graph
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

            FolderCrawlerAlgo.DFS(0, LabelDirectory.Text, TargetFilename.Text);

            // outputing to graph
            FolderCrawlerAlgo.GlobalVariable.viewer.Graph = FolderCrawlerAlgo.GlobalVariable.outputGraph;
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
    }
}
