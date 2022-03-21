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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderCrawlerForm));
            this.SelectDirectoryButton = new System.Windows.Forms.Button();
            this.LabelDirectory = new System.Windows.Forms.Label();
            this.TargetFilename = new System.Windows.Forms.TextBox();
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFileNameLabel = new System.Windows.Forms.Label();
            this.SelectMethodLabel = new System.Windows.Forms.Label();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.BFSButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.IsAllOccuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectDirectoryButton
            // 
            this.SelectDirectoryButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SelectDirectoryButton.Location = new System.Drawing.Point(17, 88);
            this.SelectDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SelectDirectoryButton.Name = "SelectDirectoryButton";
            this.SelectDirectoryButton.Size = new System.Drawing.Size(188, 38);
            this.SelectDirectoryButton.TabIndex = 0;
            this.SelectDirectoryButton.Text = "Select Directory";
            this.SelectDirectoryButton.UseVisualStyleBackColor = false;
            this.SelectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButton_Click);
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.BackColor = System.Drawing.Color.Transparent;
            this.LabelDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDirectory.Location = new System.Drawing.Point(210, 94);
            this.LabelDirectory.MaximumSize = new System.Drawing.Size(265, 0);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(112, 17);
            this.LabelDirectory.TabIndex = 1;
            this.LabelDirectory.Text = "No File Choosen";
            this.LabelDirectory.Click += new System.EventHandler(this.LabelDirectory_Click);
            // 
            // TargetFilename
            // 
            this.TargetFilename.Location = new System.Drawing.Point(66, 413);
            this.TargetFilename.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TargetFilename.Name = "TargetFilename";
            this.TargetFilename.Size = new System.Drawing.Size(294, 26);
            this.TargetFilename.TabIndex = 5;
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.ItemHeight = 20;
            this.ListBoxOutput.Location = new System.Drawing.Point(45, 804);
            this.ListBoxOutput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(478, 124);
            this.ListBoxOutput.TabIndex = 8;
            this.ListBoxOutput.SelectedIndexChanged += new System.EventHandler(this.ListBoxOutput_SelectedIndexChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Font = new System.Drawing.Font("Chaparral Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.inputLabel.Location = new System.Drawing.Point(55, 189);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(112, 45);
            this.inputLabel.TabIndex = 10;
            this.inputLabel.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose Starting Directory";
            // 
            // InputFileNameLabel
            // 
            this.InputFileNameLabel.AutoSize = true;
            this.InputFileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFileNameLabel.Location = new System.Drawing.Point(64, 377);
            this.InputFileNameLabel.Name = "InputFileNameLabel";
            this.InputFileNameLabel.Size = new System.Drawing.Size(138, 25);
            this.InputFileNameLabel.TabIndex = 12;
            this.InputFileNameLabel.Text = "Input file name";
            // 
            // SelectMethodLabel
            // 
            this.SelectMethodLabel.AutoSize = true;
            this.SelectMethodLabel.Location = new System.Drawing.Point(70, 471);
            this.SelectMethodLabel.Name = "SelectMethodLabel";
            this.SelectMethodLabel.Size = new System.Drawing.Size(112, 20);
            this.SelectMethodLabel.TabIndex = 13;
            this.SelectMethodLabel.Text = "Select method";
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DFSButton.Location = new System.Drawing.Point(76, 504);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(215, 24);
            this.DFSButton.TabIndex = 14;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "Depth First Search (DFS)";
            this.DFSButton.UseVisualStyleBackColor = true;
            this.DFSButton.CheckedChanged += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BFSButton.Location = new System.Drawing.Point(76, 536);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(227, 24);
            this.BFSButton.TabIndex = 15;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "Breadth First Search (BFS)";
            this.BFSButton.UseVisualStyleBackColor = true;
            this.BFSButton.CheckedChanged += new System.EventHandler(this.BFSButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SearchButton.Location = new System.Drawing.Point(69, 645);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 34);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Chaparral Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.OutputLabel.Location = new System.Drawing.Point(539, 168);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(137, 45);
            this.OutputLabel.TabIndex = 17;
            this.OutputLabel.Text = "Output";
            // 
            // OutputPanel
            // 
            this.OutputPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OutputPanel.Location = new System.Drawing.Point(547, 222);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(945, 749);
            this.OutputPanel.TabIndex = 18;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.White;
            this.BackgroundPanel.Controls.Add(this.label1);
            this.BackgroundPanel.Controls.Add(this.OutputPanel);
            this.BackgroundPanel.Controls.Add(this.pictureBox1);
            this.BackgroundPanel.Controls.Add(this.OpenButton);
            this.BackgroundPanel.Controls.Add(this.OutputLabel);
            this.BackgroundPanel.Controls.Add(this.IsAllOccuranceCheckBox);
            this.BackgroundPanel.Controls.Add(this.ListBoxOutput);
            this.BackgroundPanel.Controls.Add(this.SearchButton);
            this.BackgroundPanel.Controls.Add(this.inputLabel);
            this.BackgroundPanel.Controls.Add(this.InputFileNameLabel);
            this.BackgroundPanel.Controls.Add(this.SelectMethodLabel);
            this.BackgroundPanel.Controls.Add(this.DFSButton);
            this.BackgroundPanel.Controls.Add(this.BFSButton);
            this.BackgroundPanel.Controls.Add(this.TargetFilename);
            this.BackgroundPanel.Controls.Add(this.groupBox1);
            this.BackgroundPanel.Location = new System.Drawing.Point(4, 0);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1517, 1022);
            this.BackgroundPanel.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chaparral Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(43, 760);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Path File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OpenButton.Location = new System.Drawing.Point(45, 938);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(112, 35);
            this.OpenButton.TabIndex = 19;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // IsAllOccuranceCheckBox
            // 
            this.IsAllOccuranceCheckBox.AutoSize = true;
            this.IsAllOccuranceCheckBox.Location = new System.Drawing.Point(73, 591);
            this.IsAllOccuranceCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IsAllOccuranceCheckBox.Name = "IsAllOccuranceCheckBox";
            this.IsAllOccuranceCheckBox.Size = new System.Drawing.Size(168, 24);
            this.IsAllOccuranceCheckBox.TabIndex = 17;
            this.IsAllOccuranceCheckBox.Text = "Find All Occurence";
            this.IsAllOccuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LabelDirectory);
            this.groupBox1.Controls.Add(this.SelectDirectoryButton);
            this.groupBox1.Location = new System.Drawing.Point(45, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 521);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FolderCrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 1026);
            this.Controls.Add(this.BackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(1548, 1082);
            this.MinimumSize = new System.Drawing.Size(1548, 1018);
            this.Name = "FolderCrawlerForm";
            this.Text = "tubes.rawr";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelDirectory;
        private System.Windows.Forms.Button SelectDirectoryButton;
        private System.Windows.Forms.TextBox TargetFilename;
        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InputFileNameLabel;
        private System.Windows.Forms.Label SelectMethodLabel;
        private System.Windows.Forms.RadioButton DFSButton;
        private System.Windows.Forms.RadioButton BFSButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.CheckBox IsAllOccuranceCheckBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}