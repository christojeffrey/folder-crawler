
namespace DFS_BFS_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderChooserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputFilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BFSButton = new System.Windows.Forms.RadioButton();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.StartSearchButton = new System.Windows.Forms.Button();
            this.TraversalListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FolderChooserButton
            // 
            this.FolderChooserButton.Location = new System.Drawing.Point(51, 96);
            this.FolderChooserButton.Name = "FolderChooserButton";
            this.FolderChooserButton.Size = new System.Drawing.Size(142, 29);
            this.FolderChooserButton.TabIndex = 0;
            this.FolderChooserButton.Text = "Choose Folder";
            this.FolderChooserButton.UseVisualStyleBackColor = true;
            this.FolderChooserButton.Click += new System.EventHandler(this.FolderChooserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting Directory :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(190, 55);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(18, 20);
            this.DirectoryLabel.TabIndex = 2;
            this.DirectoryLabel.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "INPUT";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // InputFilename
            // 
            this.InputFilename.Location = new System.Drawing.Point(864, 55);
            this.InputFilename.Name = "InputFilename";
            this.InputFilename.Size = new System.Drawing.Size(125, 27);
            this.InputFilename.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input Nama File : ";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Input Metode Pencarian : ";
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.Location = new System.Drawing.Point(864, 101);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(54, 24);
            this.BFSButton.TabIndex = 7;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "BFS";
            this.BFSButton.UseVisualStyleBackColor = true;
            this.BFSButton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.Location = new System.Drawing.Point(924, 101);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(56, 24);
            this.DFSButton.TabIndex = 8;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = true;
            // 
            // StartSearchButton
            // 
            this.StartSearchButton.Location = new System.Drawing.Point(472, 161);
            this.StartSearchButton.Name = "StartSearchButton";
            this.StartSearchButton.Size = new System.Drawing.Size(140, 29);
            this.StartSearchButton.TabIndex = 9;
            this.StartSearchButton.Text = "Start Search";
            this.StartSearchButton.UseVisualStyleBackColor = true;
            this.StartSearchButton.Click += new System.EventHandler(this.StartSearchButton_Click);
            // 
            // TraversalListBox
            // 
            this.TraversalListBox.FormattingEnabled = true;
            this.TraversalListBox.ItemHeight = 20;
            this.TraversalListBox.Location = new System.Drawing.Point(51, 228);
            this.TraversalListBox.Name = "TraversalListBox";
            this.TraversalListBox.Size = new System.Drawing.Size(1009, 244);
            this.TraversalListBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 504);
            this.Controls.Add(this.TraversalListBox);
            this.Controls.Add(this.StartSearchButton);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.BFSButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderChooserButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FolderChooserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton BFSButton;
        private System.Windows.Forms.RadioButton DFSButton;
        private System.Windows.Forms.Button StartSearchButton;
        private System.Windows.Forms.ListBox TraversalListBox;
    }
}

