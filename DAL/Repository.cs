using NHibernate;
using NHibernate.Cfg;

namespace DAL
{
    public abstract class Repository
    {
        private static ISessionFactory sessionFactory;
        private static ISession session;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                    sessionFactory = new Configuration().Configure().BuildSessionFactory();
                return sessionFactory;
            }
        }

        protected static ISession Session
        {
            get
            {
                if (session == null)
                    session = SessionFactory.OpenSession();
                return session;
            }
        }
    }
}
