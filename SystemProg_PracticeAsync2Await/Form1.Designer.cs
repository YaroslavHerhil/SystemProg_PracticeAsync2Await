namespace SystemProg_PracticeAsync2Await
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxDestDir = new System.Windows.Forms.TextBox();
            this.browseBtnDest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.textBoxCopyDir = new System.Windows.Forms.TextBox();
            this.browseBtnCopy = new System.Windows.Forms.Button();
            this.fldDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 44);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // textBoxDestDir
            // 
            this.textBoxDestDir.Enabled = false;
            this.textBoxDestDir.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestDir.Location = new System.Drawing.Point(12, 118);
            this.textBoxDestDir.Name = "textBoxDestDir";
            this.textBoxDestDir.Size = new System.Drawing.Size(427, 44);
            this.textBoxDestDir.TabIndex = 1;
            // 
            // browseBtnDest
            // 
            this.browseBtnDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtnDest.Location = new System.Drawing.Point(445, 118);
            this.browseBtnDest.Name = "browseBtnDest";
            this.browseBtnDest.Size = new System.Drawing.Size(67, 44);
            this.browseBtnDest.TabIndex = 2;
            this.browseBtnDest.Text = "Browse";
            this.browseBtnDest.UseVisualStyleBackColor = true;
            this.browseBtnDest.Click += new System.EventHandler(this.browseBtnDest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a directory to copy and a destination";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startBtn.Location = new System.Drawing.Point(12, 178);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(107, 44);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(405, 178);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 44);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopBtn.Location = new System.Drawing.Point(292, 178);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(107, 44);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // textBoxCopyDir
            // 
            this.textBoxCopyDir.Enabled = false;
            this.textBoxCopyDir.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCopyDir.Location = new System.Drawing.Point(12, 68);
            this.textBoxCopyDir.Name = "textBoxCopyDir";
            this.textBoxCopyDir.Size = new System.Drawing.Size(427, 44);
            this.textBoxCopyDir.TabIndex = 7;
            // 
            // browseBtnCopy
            // 
            this.browseBtnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtnCopy.Location = new System.Drawing.Point(445, 68);
            this.browseBtnCopy.Name = "browseBtnCopy";
            this.browseBtnCopy.Size = new System.Drawing.Size(67, 44);
            this.browseBtnCopy.TabIndex = 8;
            this.browseBtnCopy.Text = "Browse";
            this.browseBtnCopy.UseVisualStyleBackColor = true;
            this.browseBtnCopy.Click += new System.EventHandler(this.browseBtnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 234);
            this.Controls.Add(this.browseBtnCopy);
            this.Controls.Add(this.textBoxCopyDir);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseBtnDest);
            this.Controls.Add(this.textBoxDestDir);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxDestDir;
        private System.Windows.Forms.Button browseBtnDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox textBoxCopyDir;
        private System.Windows.Forms.Button browseBtnCopy;
        private System.Windows.Forms.FolderBrowserDialog fldDialog;
    }
}

