using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _description;
        private string _mail;
        private string _tel;
        private string _adresse;
        private List<Contact> _reseaux;
        private List<Langue> _langues;

        virtual public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        virtual public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        virtual public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        virtual public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        virtual public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        virtual public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        virtual public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        virtual public List<Contact> Reseaux
        {
            get { return _reseaux; }
            set { _reseaux = value; }
        }

        virtual public List<Langue> Langues
        {
            get { return _langues; }
            set { _langues = value; }
        }

        public Utilisateur() { }
        public Utilisateur(int id, string nom, string prenom, string description, string mail, string tel, string adresse)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _description = description;
            _tel = tel;
            _mail = mail;
            _adresse = adresse;
        }

        public override String ToString()
        {
            return _prenom + " " + _nom;
        }

    }
}
