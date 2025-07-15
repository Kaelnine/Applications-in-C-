using System.Text;
using MyClass;
using System.ComponentModel;
using BiblWorm.Bibl;
namespace BiblWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
#pragma warning disable WFO1000 // ����������� ������������ ������������ ���� ��� ����������� ��������
        public string Author // �����
#pragma warning restore WFO1000 // ����������� ������������ ������������ ���� ��� ����������� ��������
        {

            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title // ��������
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PublishHouse // ������������
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Page // ���������� �������
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Year // ��� �������
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int InvNumber // ����������� �����
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Existence // �������
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool SortInvNumber // ���������� �� ������������ ������
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ReturnTime // ����������� � ����
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PeriodUse // ���� �����������
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Genre // ����
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TitleJ // ����
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PublishHouseJ // ������������
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PageJ // ���������� �������
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int YearJ // ��� �������
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int InvNumberJ // ����������� �����
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ExistenceJ // �������
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        List<Item> its = new List<Item>();
        List<Item> itsJ = new List<Item>();

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
            Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tabName = tabControl1.SelectedTab.Name;
            if (tabName == "tabPage1")
            {
                if (SortInvNumber)
                    its.Sort();
                StringBuilder sb = new StringBuilder();
                foreach (Item item in its)
                {
                    sb.Append("\n" + item.ToString());
                }
                richTextBox1.Text = sb.ToString();
            }
            else if (tabName == "tabPage2")
            {
                if (SortInvNumber)
                    its.Sort();
                StringBuilder sb = new StringBuilder();
                foreach (Item item in itsJ)
                {
                    sb.Append("\n" + item.ToString());
                }
                richTextBox1.Text = sb.ToString();
            }
            //if (SortInvNumber)
            //    its.Sort();
            //StringBuilder sb = new StringBuilder();
            //foreach (Item item in its)
            //{
            //    sb.Append("\n" + item.ToString());
            //}
            //richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Journal b = new Journal(Genre, TitleJ, PublishHouseJ,
                        PageJ, YearJ, InvNumberJ, ExistenceJ);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            itsJ.Add(b);
            Genre = TitleJ = PublishHouseJ = "";
            PageJ = InvNumberJ = PeriodUse = 0;
            YearJ = 2020;
            ExistenceJ = ReturnTime = false;
        }
    }
}
