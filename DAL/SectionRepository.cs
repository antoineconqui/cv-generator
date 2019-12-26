using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class sectionRepository : Repository
    {
        public List<Section> GetAll()
        {
            return Session.Query<Section>().ToList();
        }

        public List<Section> GetSections(int idCv)
        {
            return Session.Query<Section>().Where(s => s.IdCv == idCv).ToList();
        }

        public Section GetSection(int id)
        {
            return Session.Query<Section>().Where(s => s.Id == id).ToList()[0];
        }

        public void Delete(Section section)
        {
            Session.Delete(section);
            Session.Flush();
        }

        public void SaveOrUpdate(Section section)
        {
            Session.SaveOrUpdate(section);
            Session.Flush();
        }
    }
}
