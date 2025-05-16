using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioContact;

namespace WindowsFormsApp1
{

    public class ListeContacts (List<Contact> contacts)
    {
            public List<Contact> Contacts { get; set; }
            public ListeContacts()
            {
                Contacts = new List<Contact>();
            }
            public void AjouterContact(Contact contact)
            {
                Contacts.Add(contact);
            }
            public void SupprimerContact(Contact contact)
            {
                Contacts.Remove(contact);
            }
            public List<Contact> ObtenirContacts()
            {
                return Contacts;
            }
    }

    public class Contact
    {
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string NuméroDeTéléphone { get; set; }

        // Constructeur pour initialiser un contact
        public Contact(string nom, string prénom, string numéroDeTéléphone)
        {
            Nom = nom;
            Prénom = prénom;
            NuméroDeTéléphone = numéroDeTéléphone;
        }
    }

    public partial class FormAcceuil : Form
    {
        public FormAcceuil()
        {
            InitializeComponent();
        }
    }
}
