using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsProject.Mapping;

namespace PatternsProject.Service
{
    class NHService
    {
        private static string CONNECTION_STRING = @"Server=DESKTOP-9FESPE6\SQLEXPRESS;Database=PatternsProject;User Id =ADMIN; Password=Admin1234!";
        public static ISessionFactory SessionFactory { get; private set; }

        private static NHService _NHService;

        private NHService()
        {
            Init();
        }

        public static NHService GetNHService()
        {
            if (_NHService == null)
            {
                _NHService = new NHService();
               
            }
            return _NHService;
        }

        private static void Init()
        {
            try
            {               
                ModelMapper mapper = new ModelMapper();
                mapper.AddMappings(GetMappingTypes());

                Configuration config = GetDbConfigurationNH();
                config.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);

                SessionFactory = config.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static Configuration GetDbConfigurationNH()
        {
            var configure = new Configuration();
            return configure.DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2008Dialect>();
                db.Driver<SqlClientDriver>();
                db.ConnectionString = CONNECTION_STRING;
                db.LogFormattedSql = false;
                db.LogSqlInConsole = false;
            });
        }

        private static List<Type> GetMappingTypes()
        {
            var m = new List<Type>();
            m.Add(typeof(ProductMap));
            m.Add(typeof(ContractorMap));
            m.Add(typeof(ElementMap));
            m.Add(typeof(InvoiceMap));
            return m;
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
