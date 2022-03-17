namespace VSProject
{
    partial class FolderCrawlerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectDirectoryButton = new System.Windows.Forms.Button();
            this.LabelDirectory = new System.Windows.Forms.Label();
            this.BFSButton = new System.Windows.Forms.Button();
            this.DFSButton = new System.Windows.Forms.Button();
            this.TargetFilename = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectDirectoryButton
            // 
            this.SelectDirectoryButton.Location = new System.Drawing.Point(35, 33);
            this.SelectDirectoryButton.Name = "SelectDirectoryButton";
            this.SelectDirectoryButton.Size = new System.Drawing.Size(203, 30);
            this.SelectDirectoryButton.TabIndex = 0;
            this.SelectDirectoryButton.Text = "Select Directory";
            this.SelectDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButton_Click);
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.Location = new System.Drawing.Point(122, 76);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(33, 16);
            this.LabelDirectory.TabIndex = 1;
            this.LabelDirectory.Text = "hem";
            this.LabelDirectory.Click += new System.EventHandler(this.LabelDirectory_Click);
            // 
            // BFSButton
            // 
            this.BFSButton.Location = new System.Drawing.Point(35, 278);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(75, 23);
            this.BFSButton.TabIndex = 3;
            this.BFSButton.Text = "BFS";
            this.BFSButton.UseVisualStyleBackColor = true;
            this.BFSButton.Click += new System.EventHandler(this.BFSButton_Click);
            // 
            // DFSButton
            // 
            this.DFSButton.Location = new System.Drawing.Point(163, 278);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(75, 23);
            this.DFSButton.TabIndex = 4;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = true;
            this.DFSButton.Click += new System.EventHandler(this.DFSButton_Click);
            // 
            // TargetFilename
            // 
            this.TargetFilename.Location = new System.Drawing.Point(35, 217);
            this.TargetFilename.Name = "TargetFilename";
            this.TargetFilename.Size = new System.Drawing.Size(203, 22);
            this.TargetFilename.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(330, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(407, 63);
            this.Title.TabIndex = 6;
            this.Title.Text = "Folder Crawling";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
           
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.ItemHeight = 16;
            this.ListBoxOutput.Location = new System.Drawing.Point(125, 368);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(520, 52);
            this.ListBoxOutput.TabIndex = 8;
            this.ListBoxOutput.SelectedIndexChanged += new System.EventHandler(this.ListBoxOutput_SelectedIndexChanged);
            // 
            // FolderCrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TargetFilename);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.BFSButton);
            this.Controls.Add(this.LabelDirectory);
            this.Controls.Add(this.SelectDirectoryButton);
            this.Name = "FolderCrawlerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelDirectory;
        private System.Windows.Forms.Button BFSButton;
        private System.Windows.Forms.Button DFSButton;
        private System.Windows.Forms.Button SelectDirectoryButton;
        private System.Windows.Forms.TextBox TargetFilename;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.ListBox ListBoxOutput;
       // private System.Windows.Forms.CheckBox CheckBoxFindAllOccurance;
    }
}