using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FfmpegApp
{
    public partial class SplitVideoForm : Form
    {
        public class Time
        {
            public string Hour { get; set; }
        }
        public SplitVideoForm()
        {
            InitializeComponent();
        }


        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog1.FileName;
            }
        }
        private void SplitButton_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(txtNote.Text).ToList();
            var seconds = Helper.ConvertToSeconds(lines);
            var extension = extensionComboBox.Text;
            var outputFolder = txtOutputFolder.Text;
            var inputFolder = txtInputFile.Text;
            var existingValues = Helper.checkOutputFolderForExistFiles(outputFolder, extension);
            for (int i = 0; i < seconds.Count; i++)
            {
                if (!existingValues.Any(p => p == i))
                {
                    if (i != seconds.Count - 1)
                    {
                        if (seconds[i + 1] - seconds[i] < 5)
                        {
                            string outputFilename = $@"{outputFolder}\{i}{extension}";
                            string command = $"-i \"{inputFolder}\" -ss {seconds[i]} -t {(seconds[i + 1] - seconds[i])} \"{outputFilename}\" & exit /b";
                            FfmpegHandler.ExecuteFFMpeg(command);
                        }
                    }
                }

            }
        }

        private void FolderOpenButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtOpenFolderButton_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNote.Text = openFileDialog1.FileName;
            }

        }
    }
}
