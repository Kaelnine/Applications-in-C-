namespace WinTimer1
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
            userControlTimer1 = new UserControlTimer();
            button1 = new Button();
            userControl11 = new WinFormsControlLibraryTimer.UserControl1();
            SuspendLayout();
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(85, 79);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(89, 51);
            userControlTimer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(85, 156);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 1;
            button1.Text = "Старт / Стоп";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(254, 79);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(122, 66);
            userControl11.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 282);
            Controls.Add(userControl11);
            Controls.Add(button1);
            Controls.Add(userControlTimer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserControlTimer userControlTimer1;
        private Button button1;
        private WinFormsControlLibraryTimer.UserControl1 userControl11;
    }
}
