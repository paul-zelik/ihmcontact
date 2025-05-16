using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioContacts
{
    public class ListeContacts
    {
		//propriétés
        private List<Contact> _mesContacts=new List<Contact>();
		
		
		//constructeur
        public ListeContacts()
        {
            _mesContacts = new List<Contact>();
        }
		
		//accesseurs
        public List<Contact> MesContacts { get { return _mesContacts; } }



		//méthodes

        /// <summary>
        /// Ajoute un contact sans enfant à la liste des contacts
        /// </summary>
        /// <param name="nom">nom du contact</param>
        /// <param name="prenom">prenom du contact</param>
        public void AjouterContact(string nom, string prenom)
        {
            // créé l'ID du nouveau contact à partir du dernier
            int id;
            if (_mesContacts.Count > 0)
            {
                Contact lastContact = _mesContacts.ElementAt(_mesContacts.Count - 1);
                id = lastContact.Id + 1;
            }
            else id = 1;

            // créé le nouveau contact et l'ajoute à la liste
            Contact C = new Contact(id, nom, prenom, 0);
            _mesContacts.Add(C);
        }

        /// <summary>
        /// Ajoute un contact avec enfants à la liste des contacts
        /// </summary>
        /// <param name="nom">nom du contact</param>
        /// <param name="prenom">prenom du contact</param>
        /// <param name="prenomsEnfants">liste des prenoms des enfants</param>
        public void AjouterContact(string nom, string prenom, List<string> prenomsEnfants)
        {
            // créé l'ID du nouveau contact à partir du dernier
            int id;
            if (_mesContacts.Count > 0)
            {
                Contact lastContact = _mesContacts.ElementAt(_mesContacts.Count - 1);
                id = lastContact.Id + 1;
            }
            else id = 1;

            // créé le contact avec le nombre de ses enfants
            Contact C = new Contact(id, nom, prenom, prenomsEnfants.Count);
            
            // ajoute la liste des prénoms de ses enfants
            foreach (string prenomE in prenomsEnfants)
            {
                C.AddEnfant(prenomE);
            }
            _mesContacts.Add(C);
        }

        /// <summary>
        /// supprime le contact dont l'id est passé en paramètre
        /// </summary>
        /// <param name="id"> id du contact à supprimer</param>
        public void SupprimerContact(Contact C)
        {
            _mesContacts.Remove(C);
        }
    }
}
