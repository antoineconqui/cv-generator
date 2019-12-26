using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class elementRepository : Repository
    {
        private static utilisateurRepository utilisateurRepository = new utilisateurRepository();
        public List<Element> GetAll()
        {
            return Session.Query<Element>().ToList();
        }

        public List<Element> GetElements(int idSection)
        {
            return Session.Query<Element>().Where(e => e.IdSection == idSection).ToList();
        }

        public List<Element> GetCompetences(int idUtilisateur)
        {
            return Session.Query<Element>().Where(element => element.Hobbies == 2).Where(element => element.IdUtilisateur == idUtilisateur).ToList();
        }

        public List<Element> GetHobbies(int idUtilisateur)
        {
            return Session.Query<Element>().Where(element => element.Hobbies == 1).Where(element => element.IdUtilisateur == idUtilisateur).ToList();
        }

        public void Delete(Element element)
        {
            Session.Delete(element);
            Session.Flush();
        }

        public void SaveOrUpdate(Element element)
        {
            Session.SaveOrUpdate(element);
            Session.Flush();
        }
    }
}
