using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class langueRepository : Repository
    {

        public List<Langue> GetLangues(int idUtilisateur)
        {
            return Session.Query<Langue>().Where(l => l.IdUtilisateur == idUtilisateur).ToList();
        }

        public void SaveOrUpdate(Langue langue)
        {
            Session.SaveOrUpdate(langue);
            Session.Flush();
        }

        public void Delete(Langue langue)
        {
            Session.Delete(langue);
            Session.Flush();
        }
    }
}
