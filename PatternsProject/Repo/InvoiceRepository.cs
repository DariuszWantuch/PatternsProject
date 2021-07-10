using NHibernate;
using PatternsProject.Model;
using PatternsProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Repo
{
    public class InvoiceRepository : Repository<Invoice>
    {
        public void DeleteAll(Invoice entity)
        {
            using (ISession session = NHService.OpenSession())
            using (ITransaction tran = session.BeginTransaction())
            {
                session.Flush();

                session.Delete(entity);

                tran.Commit();
            }
        }
    }
}
