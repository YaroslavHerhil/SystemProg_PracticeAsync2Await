using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemProg_PracticeAsync2Await
{
    public partial class Form1 : Form
    {
        string copyDir = "";
        string destinationDir = "";
        bool threadIsRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void browseBtnCopy_Click(object sender, EventArgs e)
        {
            fldDialog.Description = "Choose a directory to copy";
            DialogResult result = fldDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxCopyDir.Text = fldDialog.SelectedPath;
                copyDir = fldDialog.SelectedPath;
            }
        }

        private void browseBtnDest_Click(object sender, EventArgs e)
        {
            fldDialog.Description = "Choose a destination";
            DialogResult result = fldDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxDestDir.Text = fldDialog.SelectedPath;
                destinationDir = fldDialog.SelectedPath;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!threadIsRunning) 
            {
                
                browseBtnDest.Enabled = false;
                textBoxDestDir.Visible = false;
                browseBtnDest.Visible = false;
                progressBar1.Visible = true;

                CopyFiles();
            }
            
        }

        private async Task CopyFiles()
        {
            threadIsRunning = true;
            label1.Text = "Copying directories...";
            var allDirectories = Directory.GetDirectories(copyDir, "*", SearchOption.AllDirectories);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = allDirectories.Length;
            for (int i = 0; i < allDirectories.Length; i++)
            {
                
                Directory.CreateDirectory(allDirectories[i].Replace(copyDir, destinationDir));
                await Task.Delay(1000);
                progressBar1.Value = i + 1;
            }
            var allFiles = Directory.GetFiles(copyDir, "*.*", SearchOption.AllDirectories);
            label1.Text = "Copying files...";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = allFiles.Length;
            for (int i = 0; i < allFiles.Length; i++)
            {
                File.Copy(allFiles[i], allFiles[i].Replace(copyDir, destinationDir), true);
                await Task.Delay(100);
                progressBar1.Value = i + 1;
            }

            label1.Text = "Done!";
            threadIsRunning = false;
        }
    }
}
