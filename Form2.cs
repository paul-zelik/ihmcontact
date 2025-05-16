using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            checkedListBoxContacts.Items.Add("Alice");
            checkedListBoxContacts.Items.Add("Bob");
            checkedListBoxContacts.Items.Add("Charlie");
            checkedListBoxContacts.Items.Add("David");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
