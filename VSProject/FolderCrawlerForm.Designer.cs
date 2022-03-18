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
            this.TargetFilename = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.IsAllOccuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectDirectoryButton
            // 
            this.SelectDirectoryButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SelectDirectoryButton.Location = new System.Drawing.Point(38, 199);
            this.SelectDirectoryButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SelectDirectoryButton.Name = "SelectDirectoryButton";
            this.SelectDirectoryButton.Size = new System.Drawing.Size(125, 25);
            this.SelectDirectoryButton.TabIndex = 0;
            this.SelectDirectoryButton.Text = "Select Directory";
            this.SelectDirectoryButton.UseVisualStyleBackColor = false;
            this.SelectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButton_Click);
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDirectory.Location = new System.Drawing.Point(167, 206);
            this.LabelDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(84, 13);
            this.LabelDirectory.TabIndex = 1;
            this.LabelDirectory.Text = "No File Choosen";
            this.LabelDirectory.Click += new System.EventHandler(this.LabelDirectory_Click);
            // 
            // TargetFilename
            // 
            this.TargetFilename.Location = new System.Drawing.Point(38, 279);
            this.TargetFilename.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TargetFilename.Name = "TargetFilename";
            this.TargetFilename.Size = new System.Drawing.Size(197, 20);
            this.TargetFilename.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Sitka Banner", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Title.Location = new System.Drawing.Point(363, 23);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(272, 55);
            this.Title.TabIndex = 6;
            this.Title.Text = "Folder Crawling";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.Location = new System.Drawing.Point(0, 0);
            this.LabelOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(75, 19);
            this.LabelOutput.TabIndex = 9;
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(40, 491);
            this.ListBoxOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(309, 108);
            this.ListBoxOutput.TabIndex = 8;
            this.ListBoxOutput.SelectedIndexChanged += new System.EventHandler(this.ListBoxOutput_SelectedIndexChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.inputLabel.Location = new System.Drawing.Point(35, 95);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(65, 26);
            this.inputLabel.TabIndex = 10;
            this.inputLabel.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose Starting Directory";
            // 
            // InputFileNameLabel
            // 
            this.InputFileNameLabel.AutoSize = true;
            this.InputFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFileNameLabel.Location = new System.Drawing.Point(36, 256);
            this.InputFileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputFileNameLabel.Name = "InputFileNameLabel";
            this.InputFileNameLabel.Size = new System.Drawing.Size(114, 20);
            this.InputFileNameLabel.TabIndex = 12;
            this.InputFileNameLabel.Text = "Input file name";
            // 
            // SelectMethodLabel
            // 
            this.SelectMethodLabel.AutoSize = true;
            this.SelectMethodLabel.Location = new System.Drawing.Point(35, 316);
            this.SelectMethodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectMethodLabel.Name = "SelectMethodLabel";
            this.SelectMethodLabel.Size = new System.Drawing.Size(75, 13);
            this.SelectMethodLabel.TabIndex = 13;
            this.SelectMethodLabel.Text = "Select method";
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DFSButton.Location = new System.Drawing.Point(38, 352);
            this.DFSButton.Margin = new System.Windows.Forms.Padding(2);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(143, 17);
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
            this.BFSButton.Location = new System.Drawing.Point(38, 373);
            this.BFSButton.Margin = new System.Windows.Forms.Padding(2);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(150, 17);
            this.BFSButton.TabIndex = 15;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "Breadth First Search (BFS)";
            this.BFSButton.UseVisualStyleBackColor = true;
            this.BFSButton.CheckedChanged += new System.EventHandler(this.BFSButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SearchButton.Location = new System.Drawing.Point(38, 445);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 22);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.OutputLabel.Location = new System.Drawing.Point(362, 81);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(83, 26);
            this.OutputLabel.TabIndex = 17;
            this.OutputLabel.Text = "Output";
            // 
            // OutputPanel
            // 
            this.OutputPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OutputPanel.Location = new System.Drawing.Point(367, 121);
            this.OutputPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(639, 523);
            this.OutputPanel.TabIndex = 18;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Controls.Add(this.OpenButton);
            this.BackgroundPanel.Controls.Add(this.IsAllOccuranceCheckBox);
            this.BackgroundPanel.Controls.Add(this.ListBoxOutput);
            this.BackgroundPanel.Controls.Add(this.SearchButton);
            this.BackgroundPanel.Controls.Add(this.inputLabel);
            this.BackgroundPanel.Controls.Add(this.Title);
            this.BackgroundPanel.Controls.Add(this.label2);
            this.BackgroundPanel.Controls.Add(this.InputFileNameLabel);
            this.BackgroundPanel.Controls.Add(this.SelectMethodLabel);
            this.BackgroundPanel.Controls.Add(this.DFSButton);
            this.BackgroundPanel.Controls.Add(this.BFSButton);
            this.BackgroundPanel.Controls.Add(this.LabelDirectory);
            this.BackgroundPanel.Controls.Add(this.TargetFilename);
            this.BackgroundPanel.Controls.Add(this.SelectDirectoryButton);
            this.BackgroundPanel.Location = new System.Drawing.Point(-6, -14);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1026, 681);
            this.BackgroundPanel.TabIndex = 19;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(38, 621);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 19;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // IsAllOccuranceCheckBox
            // 
            this.IsAllOccuranceCheckBox.AutoSize = true;
            this.IsAllOccuranceCheckBox.Location = new System.Drawing.Point(40, 410);
            this.IsAllOccuranceCheckBox.Name = "IsAllOccuranceCheckBox";
            this.IsAllOccuranceCheckBox.Size = new System.Drawing.Size(116, 17);
            this.IsAllOccuranceCheckBox.TabIndex = 17;
            this.IsAllOccuranceCheckBox.Text = "Find All Occurance";
            this.IsAllOccuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // FolderCrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 667);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.BackgroundPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FolderCrawlerForm";
            this.Text = "Form1";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelDirectory;
        private System.Windows.Forms.Button SelectDirectoryButton;
        private System.Windows.Forms.TextBox TargetFilename;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LabelOutput;
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
    }
}