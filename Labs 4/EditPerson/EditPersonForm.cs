using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
        public EditPersonForm()
        {
            InitializeComponent();
        }

        Person p;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }

    }
}
