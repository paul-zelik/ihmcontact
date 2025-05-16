namespace BiblioContacts
{
    public class Contact
    {
		//Propriétés
        private int _id;		// id du contact
        private string _nom;	// nom du contact
        private string _prenom;	// prénom du contact
        private int _nbEnfants;	// nombre d'enfants du contact
        private List<string> ?_prenomsEnfants;  // liste des prénoms de enfants du contact

        //Constructeur
        public Contact(int id, string nom, string prenom, int nbEnfants)
        {
			// Créé un contact avec les infos passées en paramètre. Instancie une liste de prénoms si le nbre d'enfants est >0
            _nom = nom;
            _prenom = prenom;
            _nbEnfants = nbEnfants;
            if (nbEnfants > 0)
               _prenomsEnfants = new List<string>();
        }

        //Accesseurs
        public int Id { get { return _id; } }
        public string Nom { get { return _nom; } }
        public string Prenom { get { return _prenom; } }
        public List<string> ?PrenomsEnfants { get { return _prenomsEnfants; } }
        public int NbEnfants { get { return _nbEnfants; } }
		
		//Méthodes
		public void AddEnfant(String prenom)
        {
			// Ajoute un prénom à la liste des prénoms des enfants
            if (_prenomsEnfants != null)
                _prenomsEnfants!.Add(prenom);
        }
    }
}
