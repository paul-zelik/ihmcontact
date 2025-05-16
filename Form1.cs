using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioContact;
    


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EnregistrerLeContact_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prénom = textBoxPrénom.Text;
            string numéroDeTéléphone = textBoxNuméro.Text;

            MessageBox.Show("Contact enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Ajout du Contact
            ListeContacts listeContacts = new ListeContacts();
            listeContacts.AjouterContact(textBoxNom.Text, textBoxPrénom.Text);

            textBoxNom.Clear();
            textBoxPrénom.Clear();
            textBoxNuméro.Clear();
        }

        private void textBoxPrénom_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void nud_enfant_ValueChanged(object sender, EventArgs e)
        {
            int nombreEnfant = (int)nud_enfant.Value;
            flp_enfant.Controls.Clear();

            for (int i = 0; i < nombreEnfant; i++)
            {
                Label labelNom = new Label { Text = $"Nom {i + 1} :" };
                TextBox textBoxNom = new TextBox();

                Label labelPrenom = new Label { Text = $"Prénom {i + 1} :" };
                TextBox textBoxPrenom = new TextBox();

                flp_enfant.Controls.Add(labelNom);
                flp_enfant.Controls.Add(textBoxNom);
                flp_enfant.Controls.Add(labelPrenom);
                flp_enfant.Controls.Add(textBoxPrenom);
            }
        }

        private TextBox textBoxNom;
        private TextBox textBoxPrénom;
        private TextBox textBoxNuméro;
        private Button EnregistrerLeContact;
        private NumericUpDown nud_enfant;
        private FlowLayoutPanel flp_enfant;
    }
}