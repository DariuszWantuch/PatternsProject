using NHibernate;
using PatternsProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Repo
{
    public class Repository<T> where T : class
    {
        public void Save(T entity)
        {
            using (ISession session = NHService.OpenSession())
            using (ITransaction tran = session.BeginTransaction())
            {
                session.SaveOrUpdate(entity);

                tran.Commit();
            }
        }

        public void Delete(T entity)
        {
            using (ISession session = NHService.OpenSession())
            using (ITransaction tran = session.BeginTransaction())
            {             
                session.Delete(entity);

                tran.Commit();
            }
        }

        public void Update(T entity)
        {
            using (ISession session = NHService.OpenSession())
            using (ITransaction tran = session.BeginTransaction())
            {
                session.Update(entity);

                tran.Commit();
            }
        }

        public List<T> GetAll()
        {
            using (ISession session = NHService.OpenSession())
            using (ITransaction tran = session.BeginTransaction())
            {
                return session.Query<T>().ToList();
            }
        }

        public T Get(int id)
        {
            using (ISession session = NHService.OpenSession())
            using (ITransaction tran = session.BeginTransaction())
            {
                return session.Get<T>(id);
            }
        }
    }
}
