using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise_4
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler<User> ValidateDateInput;
        public UserControl1()
        {
            InitializeComponent();
        }

        

        private void sendButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = Convert.ToInt32(ageNumericUpDown.Value);
            string phone = phoneTextBox.Text;
            if (ValidateData())
            {
                User user = new User(name, age, phone);
                ValidateDateInput?.Invoke(this, user);
            }
            
            

        }

        private bool ValidateData()
        {
            bool isValid = true;
            
            if (nameTextBox.Text.Any(char.IsDigit))
            //if (int.TryParse(nameTextBox.Text, out int number))
            {
                errorProvider1.SetError(nameTextBox, "Поле \"Имя\" не может содержать цифры");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(nameTextBox, "");
            }

            if (!int.TryParse(phoneTextBox.Text, out int numberPhone))
            //if (phoneTextBox.Text == "")
            {
                errorProvider2.SetError(phoneTextBox, "Поле \"Телефон\" не может содержать буквы");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(phoneTextBox, "");
            }
            if (ageNumericUpDown.Value < 18 || ageNumericUpDown.Value > 80)
            {
                errorProvider3.SetError(ageNumericUpDown, "Возраст должен быть от 18 до 80");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(ageNumericUpDown, "");
            }
            return isValid;
        }
    }
}
