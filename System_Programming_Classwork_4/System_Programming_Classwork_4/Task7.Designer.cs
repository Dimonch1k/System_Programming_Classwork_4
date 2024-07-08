namespace System_Programming_Classwork_4
{
    partial class Task7
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
            this.numberTB = new System.Windows.Forms.TextBox();
            this.powerTB = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.countBtn = new System.Windows.Forms.Button();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(210, 106);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(100, 20);
            this.numberTB.TabIndex = 0;
            // 
            // powerTB
            // 
            this.powerTB.Location = new System.Drawing.Point(210, 140);
            this.powerTB.Name = "powerTB";
            this.powerTB.Size = new System.Drawing.Size(100, 20);
            this.powerTB.TabIndex = 1;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(147, 109);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Number";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(147, 143);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(37, 13);
            this.powerLabel.TabIndex = 3;
            this.powerLabel.Text = "Power";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(147, 222);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(150, 166);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(160, 23);
            this.countBtn.TabIndex = 6;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(210, 219);
            this.resultTB.Name = "resultTB";
            this.resultTB.Size = new System.Drawing.Size(100, 20);
            this.resultTB.TabIndex = 5;
            // 
            // Task7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.powerTB);
            this.Controls.Add(this.numberTB);
            this.Name = "Task7";
            this.Text = "Task7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.TextBox powerTB;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.TextBox resultTB;
    }
}