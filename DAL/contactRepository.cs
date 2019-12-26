using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class contactRepository : Repository
    {
        public List<Contact> GetAll()
        {
            return Session.Query<Contact>().ToList();
        }

        public List<Contact> GetContacts(int idUtilisateur)
        {
            return Session.Query<Contact>().Where(c => c.IdUtilisateur == idUtilisateur).ToList();
        }
    }
}
