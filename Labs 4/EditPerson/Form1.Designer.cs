namespace EditPerson
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
            personsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // personsListView
            // 
            personsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            personsListView.Location = new Point(1, 2);
            personsListView.Name = "personsListView";
            personsListView.Size = new Size(398, 265);
            personsListView.TabIndex = 0;
            personsListView.UseCompatibleStateImageBehavior = false;
            personsListView.View = View.Details;
            personsListView.VirtualMode = true;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Имя";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Фамилия";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Возраст";
            columnHeader3.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(50, 307);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 307);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 2;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 355);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(personsListView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Список сотрудников";
            ResumeLayout(false);
        }

        #endregion

        private ListView personsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private Button button2;
    }
}
