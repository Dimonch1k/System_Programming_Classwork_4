namespace System_Programming_Classwork_4
{
    partial class Task1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.ListBox listBoxLetters;
        private System.Windows.Forms.ListBox listBoxSymbols;
        private System.Windows.Forms.Button buttonStartNumbers;
        private System.Windows.Forms.Button buttonStartLetters;
        private System.Windows.Forms.Button buttonStartSymbols;
        private System.Windows.Forms.ComboBox comboBoxNumberPriority;
        private System.Windows.Forms.ComboBox comboBoxLetterPriority;
        private System.Windows.Forms.ComboBox comboBoxSymbolPriority;
        private System.Windows.Forms.Label labelNumberPriority;
        private System.Windows.Forms.Label labelLetterPriority;
        private System.Windows.Forms.Label labelSymbolPriority;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.listBoxLetters = new System.Windows.Forms.ListBox();
            this.listBoxSymbols = new System.Windows.Forms.ListBox();
            this.buttonStartNumbers = new System.Windows.Forms.Button();
            this.buttonStartLetters = new System.Windows.Forms.Button();
            this.buttonStartSymbols = new System.Windows.Forms.Button();
            this.comboBoxNumberPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxLetterPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxSymbolPriority = new System.Windows.Forms.ComboBox();
            this.labelNumberPriority = new System.Windows.Forms.Label();
            this.labelLetterPriority = new System.Windows.Forms.Label();
            this.labelSymbolPriority = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // listBoxNumbers
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.Location = new System.Drawing.Point(12, 12);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(120, 200);
            this.listBoxNumbers.TabIndex = 0;

            // listBoxLetters
            this.listBoxLetters.FormattingEnabled = true;
            this.listBoxLetters.Location = new System.Drawing.Point(152, 12);
            this.listBoxLetters.Name = "listBoxLetters";
            this.listBoxLetters.Size = new System.Drawing.Size(120, 200);
            this.listBoxLetters.TabIndex = 1;

            // listBoxSymbols
            this.listBoxSymbols.FormattingEnabled = true;
            this.listBoxSymbols.Location = new System.Drawing.Point(292, 12);
            this.listBoxSymbols.Name = "listBoxSymbols";
            this.listBoxSymbols.Size = new System.Drawing.Size(120, 200);
            this.listBoxSymbols.TabIndex = 2;

            // buttonStartNumbers
            this.buttonStartNumbers.Location = new System.Drawing.Point(12, 240);
            this.buttonStartNumbers.Name = "buttonStartNumbers";
            this.buttonStartNumbers.Size = new System.Drawing.Size(120, 23);
            this.buttonStartNumbers.TabIndex = 3;
            this.buttonStartNumbers.Text = "Start Numbers";
            this.buttonStartNumbers.UseVisualStyleBackColor = true;
            this.buttonStartNumbers.Click += new System.EventHandler(this.buttonStartNumbers_Click);

            // buttonStartLetters
            this.buttonStartLetters.Location = new System.Drawing.Point(152, 240);
            this.buttonStartLetters.Name = "buttonStartLetters";
            this.buttonStartLetters.Size = new System.Drawing.Size(120, 23);
            this.buttonStartLetters.TabIndex = 4;
            this.buttonStartLetters.Text = "Start Letters";
            this.buttonStartLetters.UseVisualStyleBackColor = true;
            this.buttonStartLetters.Click += new System.EventHandler(this.buttonStartLetters_Click);

            // buttonStartSymbols
            this.buttonStartSymbols.Location = new System.Drawing.Point(292, 240);
            this.buttonStartSymbols.Name = "buttonStartSymbols";
            this.buttonStartSymbols.Size = new System.Drawing.Size(120, 23);
            this.buttonStartSymbols.TabIndex = 5;
            this.buttonStartSymbols.Text = "Start Symbols";
            this.buttonStartSymbols.UseVisualStyleBackColor = true;
            this.buttonStartSymbols.Click += new System.EventHandler(this.buttonStartSymbols_Click);

            // comboBoxNumberPriority
            this.comboBoxNumberPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberPriority.FormattingEnabled = true;
            this.comboBoxNumberPriority.Location = new System.Drawing.Point(12, 285);
            this.comboBoxNumberPriority.Name = "comboBoxNumberPriority";
            this.comboBoxNumberPriority.Size = new System.Drawing.Size(120, 21);
            this.comboBoxNumberPriority.TabIndex = 6;

            // comboBoxLetterPriority
            this.comboBoxLetterPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLetterPriority.FormattingEnabled = true;
            this.comboBoxLetterPriority.Location = new System.Drawing.Point(152, 285);
            this.comboBoxLetterPriority.Name = "comboBoxLetterPriority";
            this.comboBoxLetterPriority.Size = new System.Drawing.Size(120, 21);
            this.comboBoxLetterPriority.TabIndex = 7;

            // comboBoxSymbolPriority
            this.comboBoxSymbolPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSymbolPriority.FormattingEnabled = true;
            this.comboBoxSymbolPriority.Location = new System.Drawing.Point(292, 285);
            this.comboBoxSymbolPriority.Name = "comboBoxSymbolPriority";
            this.comboBoxSymbolPriority.Size = new System.Drawing.Size(120, 21);
            this.comboBoxSymbolPriority.TabIndex = 8;

            
            
            // labelNumberPriority
            this.labelNumberPriority.AutoSize = true;
            this.labelNumberPriority.Location = new System.Drawing.Point(12, 269);
            this.labelNumberPriority.Name = "labelNumberPriority";
            this.labelNumberPriority.Size = new System.Drawing.Size(89, 13);
            this.labelNumberPriority.TabIndex = 9;
            this.labelNumberPriority.Text = "Number Priority:";

            // labelLetterPriority
            this.labelLetterPriority.AutoSize = true;
            this.labelLetterPriority.Location = new System.Drawing.Point(152, 269);
            this.labelLetterPriority.Name = "labelLetterPriority";
            this.labelLetterPriority.Size = new System.Drawing.Size(73, 13);
            this.labelLetterPriority.TabIndex = 10;
            this.labelLetterPriority.Text = "Letter Priority:";

            // labelSymbolPriority
            this.labelSymbolPriority.AutoSize = true;
            this.labelSymbolPriority.Location = new System.Drawing.Point(292, 269);
            this.labelSymbolPriority.Name = "labelSymbolPriority";
            this.labelSymbolPriority.Size = new System.Drawing.Size(83, 13);
            this.labelSymbolPriority.TabIndex = 11;
            this.labelSymbolPriority.Text = "Symbol Priority:";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 321);
            this.Controls.Add(this.labelSymbolPriority);
            this.Controls.Add(this.labelLetterPriority);
            this.Controls.Add(this.labelNumberPriority);
            this.Controls.Add(this.comboBoxSymbolPriority);
            this.Controls.Add(this.comboBoxLetterPriority);
            this.Controls.Add(this.comboBoxNumberPriority);
            this.Controls.Add(this.buttonStartSymbols);
            this.Controls.Add(this.buttonStartLetters);
            this.Controls.Add(this.buttonStartNumbers);
            this.Controls.Add(this.listBoxSymbols);
            this.Controls.Add(this.listBoxLetters);
            this.Controls.Add(this.listBoxNumbers);
            this.Name = "MainForm";
            this.Text = "Multi-threading Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
