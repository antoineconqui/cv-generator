using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Domain
{
    public class Cv
    {
        private string _titre;
        private int _id;
        private int _idUtilisateur;
        private Utilisateur _utilisateur;
        private string _job;
        private List<Section> _sections;
        private List<Element> _competences;
        private List<Element> _hobbies;

        public virtual string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual int IdUtilisateur
        {
            get { return _idUtilisateur; }
            set { _idUtilisateur = value; }
        }
        public virtual Utilisateur Utilisateur
        {
            get { return _utilisateur; }
            set { _utilisateur = value; }
        }

        virtual public string Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public virtual List<Element> Competences
        {
            get { return _competences; }
            set { _competences = value; }
        }
        public virtual List<Element> Hobbies
        {
            get { return _hobbies; }
            set { _hobbies = value; }
        }
        virtual public List<Section> Sections
        {
            get { return _sections; }
            set { _sections = value; }
        }

        public Cv() { }
        
        public Cv(string titre, Utilisateur utilisateur)
        {
            _titre = titre;
            _job = "";
            _utilisateur = utilisateur;
            _idUtilisateur = _utilisateur.Id;
            _competences = new List<Element>();
            _hobbies = new List<Element>();
            _sections = new List<Section>();
        }

        public virtual bool contient(Section section)
        {
            for (int i = 0; i < _sections.Count; i++)
                if (section.Id == _sections[i].Id)
                    return true;
            return false;
        }
    }
}
