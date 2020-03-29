namespace FfmpegApp
{
    partial class SplitVideoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitButton = new System.Windows.Forms.Button();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.folderOpenButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtOpenFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input File Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInputFile
            // 
            this.txtInputFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInputFile.Location = new System.Drawing.Point(132, 66);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(461, 20);
            this.txtInputFile.TabIndex = 6;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(646, 65);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 22);
            this.openFileButton.TabIndex = 4;
            this.openFileButton.Text = "Browse...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitButton
            // 
            this.splitButton.Location = new System.Drawing.Point(284, 245);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(118, 32);
            this.splitButton.TabIndex = 7;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.SplitButton_Click);
            // 
            // extensionComboBox
            // 
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Items.AddRange(new object[] {
            ".mp4",
            ".flv",
            ".mpeg"});
            this.extensionComboBox.Location = new System.Drawing.Point(132, 160);
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.Size = new System.Drawing.Size(127, 21);
            this.extensionComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Extension Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output Folder:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutputFolder.Location = new System.Drawing.Point(132, 118);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(461, 20);
            this.txtOutputFolder.TabIndex = 16;
            // 
            // folderOpenButton
            // 
            this.folderOpenButton.Location = new System.Drawing.Point(646, 118);
            this.folderOpenButton.Name = "folderOpenButton";
            this.folderOpenButton.Size = new System.Drawing.Size(75, 22);
            this.folderOpenButton.TabIndex = 17;
            this.folderOpenButton.Text = "Browse...";
            this.folderOpenButton.UseVisualStyleBackColor = true;
            this.folderOpenButton.Click += new System.EventHandler(this.FolderOpenButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Input txt Name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNote.Location = new System.Drawing.Point(132, 13);
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(461, 20);
            this.txtNote.TabIndex = 20;
            // 
            // txtOpenFolderButton
            // 
            this.txtOpenFolderButton.Location = new System.Drawing.Point(646, 15);
            this.txtOpenFolderButton.Name = "txtOpenFolderButton";
            this.txtOpenFolderButton.Size = new System.Drawing.Size(75, 22);
            this.txtOpenFolderButton.TabIndex = 18;
            this.txtOpenFolderButton.Text = "Browse...";
            this.txtOpenFolderButton.UseVisualStyleBackColor = true;
            this.txtOpenFolderButton.Click += new System.EventHandler(this.txtOpenFolderButton_Click);
            // 
            // SplitVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtOpenFolderButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.folderOpenButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.extensionComboBox);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.openFileButton);
            this.Name = "SplitVideoForm";
            this.Text = "SplitVideoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button folderOpenButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button txtOpenFolderButton;
    }
}