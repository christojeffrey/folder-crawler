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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.BFSButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SelectDirectoryButton
            // 
            this.SelectDirectoryButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SelectDirectoryButton.Location = new System.Drawing.Point(49, 216);
            this.SelectDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectDirectoryButton.Name = "SelectDirectoryButton";
            this.SelectDirectoryButton.Size = new System.Drawing.Size(187, 38);
            this.SelectDirectoryButton.TabIndex = 0;
            this.SelectDirectoryButton.Text = "Select Directory";
            this.SelectDirectoryButton.UseVisualStyleBackColor = false;
            this.SelectDirectoryButton.Click += new System.EventHandler(this.SelectDirectoryButton_Click);
            // 
            // LabelDirectory
            // 
            this.LabelDirectory.AutoSize = true;
            this.LabelDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDirectory.Location = new System.Drawing.Point(242, 227);
            this.LabelDirectory.Name = "LabelDirectory";
            this.LabelDirectory.Size = new System.Drawing.Size(112, 17);
            this.LabelDirectory.TabIndex = 1;
            this.LabelDirectory.Text = "No File Choosen";
            this.LabelDirectory.Click += new System.EventHandler(this.LabelDirectory_Click);
            // 
            // TargetFilename
            // 
            this.TargetFilename.Location = new System.Drawing.Point(49, 314);
            this.TargetFilename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TargetFilename.Name = "TargetFilename";
            this.TargetFilename.Size = new System.Drawing.Size(294, 26);
            this.TargetFilename.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Sitka Banner", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Title.Location = new System.Drawing.Point(299, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(399, 81);
            this.Title.TabIndex = 6;
            this.Title.Text = "Folder Crawling";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.Location = new System.Drawing.Point(0, 0);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(112, 29);
            this.LabelOutput.TabIndex = 9;
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.ItemHeight = 20;
            this.ListBoxOutput.Location = new System.Drawing.Point(51, 559);
            this.ListBoxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(422, 44);
            this.ListBoxOutput.TabIndex = 8;
            this.ListBoxOutput.SelectedIndexChanged += new System.EventHandler(this.ListBoxOutput_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(42, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose Starting Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Input file name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select method";
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DFSButton.Location = new System.Drawing.Point(51, 421);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(215, 24);
            this.DFSButton.TabIndex = 14;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "Depth First Search (DFS)";
            this.DFSButton.UseVisualStyleBackColor = true;
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BFSButton.Location = new System.Drawing.Point(51, 451);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(227, 24);
            this.BFSButton.TabIndex = 15;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "Breadth First Search (BFS)";
            this.BFSButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(49, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(543, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Output";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(550, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 417);
            this.panel1.TabIndex = 18;
            // 
            // FolderCrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BFSButton);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TargetFilename);
            this.Controls.Add(this.LabelDirectory);
            this.Controls.Add(this.SelectDirectoryButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FolderCrawlerForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton DFSButton;
        private System.Windows.Forms.RadioButton BFSButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        // private System.Windows.Forms.CheckBox CheckBoxFindAllOccurance;
    }
}