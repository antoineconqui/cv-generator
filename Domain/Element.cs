using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Element
    {
        private int _id;
        private string _titre;
        private string _debut;
        private string _fin;
        private string _lieu;
        private string _competences;
        private int _active;
        private int _hobbies;
        private int _idSection;
        private int _idCv;
        private int _idUtilisateur;

        virtual public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        virtual public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        virtual public string Debut
        {
            get { return _debut; }
            set { _debut = value; }
        }
        virtual public string Fin
        {
            get { return _fin; }
            set { _fin = value; }
        }
        virtual public string Lieu
        {
            get { return _lieu; }
            set { _lieu = value; }
        }
        virtual public string Competences
        {
            get { return _competences; }
            set { _competences = value; }
        }
        virtual public int Active
        {
            get { return _active; }
            set { _active = value; }
        }
        virtual public int Hobbies
        {
            get { return _hobbies; }
            set { _hobbies = value; }
        }
        virtual public int IdSection
        {
            get { return _idSection; }
            set { _idSection = value; }
        }
        virtual public int IdCv
        {
            get { return _idCv; }
            set { _idCv = value; }
        }
        virtual public int IdUtilisateur
        {
            get { return _idUtilisateur; }
            set { _idUtilisateur = value; }
        }

        public Element() {
            _titre = "";
        }
        
        public Element(string titre, string debut, string fin, string lieu, string competences, int active, int hobbies, int idCv, int idSection, int idUtilisateur)
        {
            _titre = titre;
            _debut = debut;
            _fin = fin;
            _lieu = lieu;
            _competences = competences;
            _active = active;
            _hobbies = hobbies;
            _idCv = idCv;
            _idSection = idSection;
            _idUtilisateur = idUtilisateur;
        }

        public override string ToString()
        {
            return _titre;
        }
    }
}
