using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contact
    {
        private int _id;
        private string _nom;
        private string _lien;
        private int _idUtilisateur;

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
        virtual public string Lien
        {
            get { return _lien; }
            set { _lien = value; }
        }
        virtual public int IdUtilisateur
        {
            get { return _idUtilisateur; }
            set { _idUtilisateur = value; }
        }

        public Contact() { }
        public Contact(string nom, string lien, int idUtilisateur)
        {
            _nom = nom;
            _lien = lien;
            _idUtilisateur = idUtilisateur;
        }
    }
}
