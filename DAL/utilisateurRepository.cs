using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class utilisateurRepository : Repository
    {
        public List<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }

        public Utilisateur GetUtilisateur(int id)
        {
            return Session.Query<Utilisateur>().Where(u => u.Id == id).ToList()[0];
        }

        public void SaveOrUpdate(Utilisateur utilisateur)
        {
            Session.SaveOrUpdate(utilisateur);
            Session.Flush();
        }

        public void Delete(Utilisateur utilisateur)
        {
            Session.Delete(utilisateur);
            Session.Flush();
        }

        public Utilisateur GetLastUtilisateur()
        {
            return Session.Query<Utilisateur>().OrderByDescending(u => u.Id).ToList()[0];                
        }

    }
}
