using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class cvRepository : Repository
    {
        public List<Cv> GetAll()
        {
            return Session.Query<Cv>().ToList();
        }

        public Cv GetCV(int id)
        {
            return Session.Query<Cv>().Where(c => c.Id == id).ToList()[0];
        }

        public List<Cv> GetCV(Utilisateur utilisateur)
        {
            return Session.Query<Cv>().Where(c => c.IdUtilisateur == utilisateur.Id).ToList();
        }

        public void SaveOrUpdate(Cv cv)
        {
            Session.SaveOrUpdate(cv);
            Session.Flush();
        }
        public void Delete(Cv cv)
        {
            Session.Delete(cv);
            Session.Flush();
        }

    }
}
