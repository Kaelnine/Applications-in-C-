namespace Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.ValidateDateInput += User_Control1_ValidateDateInput;
            
        }

        private void User_Control1_ValidateDateInput(object sender, User user)
        {
            richTextBox1.Text = user.ToString();
        }
    }
}
