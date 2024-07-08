namespace System_Programming_Classwork_4
{
    partial class Task2
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
            this.chooseFile = new System.Windows.Forms.Button();
            this.fileNameLb = new System.Windows.Forms.Label();
            this.startCopyingBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(98, 85);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(75, 23);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "Choose File";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // fileNameLb
            // 
            this.fileNameLb.AutoSize = true;
            this.fileNameLb.Location = new System.Drawing.Point(111, 124);
            this.fileNameLb.Name = "fileNameLb";
            this.fileNameLb.Size = new System.Drawing.Size(0, 13);
            this.fileNameLb.TabIndex = 1;
            // 
            // startCopyingBtn
            // 
            this.startCopyingBtn.Location = new System.Drawing.Point(288, 85);
            this.startCopyingBtn.Name = "startCopyingBtn";
            this.startCopyingBtn.Size = new System.Drawing.Size(99, 23);
            this.startCopyingBtn.TabIndex = 2;
            this.startCopyingBtn.Text = "Start Copying";
            this.startCopyingBtn.UseVisualStyleBackColor = true;
            this.startCopyingBtn.Click += new System.EventHandler(this.startCopyingBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(288, 194);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(99, 23);
            this.pauseBtn.TabIndex = 3;
            this.pauseBtn.Text = "Pause Copying";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(288, 223);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(99, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Complete Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.startCopyingBtn);
            this.Controls.Add(this.fileNameLb);
            this.Controls.Add(this.chooseFile);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Label fileNameLb;
        private System.Windows.Forms.Button startCopyingBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button stopBtn;
    }
}