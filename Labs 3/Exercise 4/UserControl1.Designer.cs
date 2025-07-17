namespace Exercise_4
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nameTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            phoneTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sendButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(137, 44);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(120, 23);
            nameTextBox.TabIndex = 0;
            //nameTextBox.KeyPress += nameTextBox_KeyPress;
            //nameTextBox.Validating += nameTextBox_Validating;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(137, 89);
            ageNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(120, 23);
            ageNumericUpDown.TabIndex = 1;
            ageNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //ageNumericUpDown.Validating += ageNumericUpDown_Validating;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(135, 140);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(122, 23);
            phoneTextBox.TabIndex = 2;
            //phoneTextBox.KeyPress += phoneTextBox_KeyPress;
            //phoneTextBox.Validating += phoneTextBox_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 51);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 92);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Возраст:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 146);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Телефон:";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(114, 189);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(98, 23);
            sendButton.TabIndex = 6;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sendButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phoneTextBox);
            Controls.Add(ageNumericUpDown);
            Controls.Add(nameTextBox);
            Name = "UserControl1";
            Size = new Size(320, 234);
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private NumericUpDown ageNumericUpDown;
        private TextBox phoneTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button sendButton;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}
