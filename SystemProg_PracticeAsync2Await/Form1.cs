using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemProg_PracticeAsync2Await
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellation = new CancellationTokenSource();
        string copyDir = "";
        string destinationDir = "";
        bool isPaused = false;
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
            
            stopBtn.Enabled = true;
            cancelBtn.Enabled = true;
            startBtn.Enabled = false;
            browseBtnDest.Enabled = false;
            textBoxDestDir.Visible = false;
            browseBtnDest.Visible = false;
            progressBar1.Visible = true;

            CopyFiles(cancellation.Token);
        }

        private async Task CopyFiles(CancellationToken cancellation)
        {
            bool isCancelled = false;
            label1.Text = "Copying directories...";
            var allDirectories = Directory.GetDirectories(copyDir, "*", SearchOption.AllDirectories);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = allDirectories.Length;
            for (int i = 0; i < allDirectories.Length; i++)
            {
                if (cancellation.IsCancellationRequested) { isCancelled = true; break; }
                cancellation.ThrowIfCancellationRequested();
                if (isPaused) { await CheckIfPaused(); }
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
                if (cancellation.IsCancellationRequested) { isCancelled = true; break; }
                if (isPaused) { await CheckIfPaused(); }
                File.Copy(allFiles[i], allFiles[i].Replace(copyDir, destinationDir), true);
                await Task.Delay(500);
                progressBar1.Value = i + 1;
            }
            if (isCancelled)
            { 
                label1.Text = "Cancelled";
            }
            else 
            { 
                label1.Text = "Done!";
            }
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            cancelBtn.Enabled = false;
            browseBtnDest.Enabled = true;
            textBoxDestDir.Visible = true;
            browseBtnDest.Visible = true;
            progressBar1.Visible = false;
        }
       
        private async Task CheckIfPaused()
        {
            while (isPaused) { await Task.Delay(10); }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            isPaused = isPaused ? false : true;
            if (isPaused) { stopBtn.Text = "Resume"; }
            else stopBtn.Text = "Stop";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancellation.Cancel();
            cancellation = new CancellationTokenSource(); 
        }
    }
}
