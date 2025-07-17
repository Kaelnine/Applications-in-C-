namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControlTimer1.TimeEnabled == true)
            {
                userControlTimer1.TimeEnabled = false;
            }
            else { userControlTimer1.TimeEnabled = true; }
            if (userControl11.TimeEnabled == true)
            {
                userControl11.TimeEnabled = false;
            }
            else { userControl11.TimeEnabled = true; }
        }
    }
}
