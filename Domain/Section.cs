using System;
using System.Collections.Generic;

namespace Domain
{
    public class Section
    {
        private int _id;
        private string _titre;
        private List<Element> _elements;
        private int _idCv;
        private int _idUtilisateur;
        private int _active;

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
        virtual public List<Element> Elements
        {
            get { return _elements; }
            set { _elements = value; }
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
        virtual public int Active
        {
            get { return _active; }
            set { _active = value; }
        }
        
        public Section()
        {
            _elements = new List<Element>();
        }

        public Section(int id, string titre, List<Element> elements, int idCv, int idUtilisateur)
        {
            _id = id;
            _titre = titre;
            _elements = elements;
            _idCv = idCv;
            _idUtilisateur = idUtilisateur;
            _active = 1;
        }

        public virtual bool contient(Element element)
        {
            for(int i = 0; i < _elements.Count; i++)
                if (element.Id == _elements[i].Id)
                    return true;
            return false;
        }
    }
}
