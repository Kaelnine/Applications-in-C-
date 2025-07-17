namespace Exercise_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControl11 = new UserControl1();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(12, 12);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(320, 234);
            userControl11.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(368, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(204, 194);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 279);
            Controls.Add(richTextBox1);
            Controls.Add(userControl11);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserControl1 userControl11;
        private RichTextBox richTextBox1;
    }
}
