namespace CST_150_Activity5
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.resultsTB = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.alphabeticalTB = new System.Windows.Forms.TextBox();
            this.mostTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(12, 22);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(101, 96);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "&Choose File";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // resultsTB
            // 
            this.resultsTB.Location = new System.Drawing.Point(119, 22);
            this.resultsTB.Multiline = true;
            this.resultsTB.Name = "resultsTB";
            this.resultsTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsTB.Size = new System.Drawing.Size(577, 96);
            this.resultsTB.TabIndex = 1;
            this.resultsTB.TextChanged += new System.EventHandler(this.resultsTB_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 96);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // alphabeticalTB
            // 
            this.alphabeticalTB.Location = new System.Drawing.Point(119, 124);
            this.alphabeticalTB.Multiline = true;
            this.alphabeticalTB.Name = "alphabeticalTB";
            this.alphabeticalTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.alphabeticalTB.Size = new System.Drawing.Size(577, 96);
            this.alphabeticalTB.TabIndex = 4;
            this.alphabeticalTB.Text = "Alphabetically";
            // 
            // mostTB
            // 
            this.mostTB.Location = new System.Drawing.Point(119, 226);
            this.mostTB.Multiline = true;
            this.mostTB.Name = "mostTB";
            this.mostTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mostTB.Size = new System.Drawing.Size(577, 96);
            this.mostTB.TabIndex = 5;
            this.mostTB.Text = "Longest word with the most vowels";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 124);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(101, 96);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(704, 340);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mostTB);
            this.Controls.Add(this.alphabeticalTB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resultsTB);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "Form1";
            this.Text = "File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox resultsTB;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox alphabeticalTB;
        private System.Windows.Forms.TextBox mostTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

