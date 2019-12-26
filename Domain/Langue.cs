using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Langue
    {
        private int _id;
        private string _nom;
        private string _certification;
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
        virtual public string Certification
        {
            get { return _certification; }
            set { _certification = value; }
        }
        virtual public int IdUtilisateur
        {
            get { return _idUtilisateur; }
            set { _idUtilisateur = value; }
        }


        public Langue() { }
        public Langue(string nom, string certification, int idUtilisateur)
        {
            _idUtilisateur = idUtilisateur;
            _nom = nom;
            _certification = certification;
        }

    }
}
