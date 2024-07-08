namespace System_Programming_Classwork_4
{
    partial class Task8
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
            this.textTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vowelsTB = new System.Windows.Forms.TextBox();
            this.consonantsTB = new System.Windows.Forms.TextBox();
            this.symbolsTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTB
            // 
            this.textTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTB.Location = new System.Drawing.Point(212, 126);
            this.textTB.Name = "textTB";
            this.textTB.Size = new System.Drawing.Size(267, 23);
            this.textTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Text";
            // 
            // vowelsTB
            // 
            this.vowelsTB.Location = new System.Drawing.Point(212, 223);
            this.vowelsTB.Name = "vowelsTB";
            this.vowelsTB.Size = new System.Drawing.Size(47, 20);
            this.vowelsTB.TabIndex = 2;
            // 
            // consonantsTB
            // 
            this.consonantsTB.Location = new System.Drawing.Point(316, 223);
            this.consonantsTB.Name = "consonantsTB";
            this.consonantsTB.Size = new System.Drawing.Size(47, 20);
            this.consonantsTB.TabIndex = 3;
            // 
            // symbolsTB
            // 
            this.symbolsTB.Location = new System.Drawing.Point(424, 223);
            this.symbolsTB.Name = "symbolsTB";
            this.symbolsTB.Size = new System.Drawing.Size(47, 20);
            this.symbolsTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vowels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consonants";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Symbols";
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(214, 155);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(265, 23);
            this.countBtn.TabIndex = 8;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // Task8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symbolsTB);
            this.Controls.Add(this.consonantsTB);
            this.Controls.Add(this.vowelsTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTB);
            this.Name = "Task8";
            this.Text = "Task8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vowelsTB;
        private System.Windows.Forms.TextBox consonantsTB;
        private System.Windows.Forms.TextBox symbolsTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button countBtn;
    }
}