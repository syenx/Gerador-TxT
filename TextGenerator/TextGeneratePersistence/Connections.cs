using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Configuration;

namespace TextGeneratePersistence
{
    public class Connections
    {
        private static ISessionFactory _sessionFactory;



        public ISession OpenConnection()
        {
            string connectionString = @"Data Source=NBBV026291\SQLEXPRESS;Initial Catalog=TransacaoBanco;Integrated Security=True";//ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            CreateDatabase(connectionString);
            return _sessionFactory.OpenSession();
         
        }

        static void CreateDatabase(string connectionString)
        {
            var configuration = GetConfiguration(connectionString);

            var exporter = new SchemaExport(configuration);
            exporter.Execute(true, true, false);

            _sessionFactory = configuration.BuildSessionFactory();
        }

        private static NHibernate.Cfg.Configuration GetConfiguration(string connectionString)
        {
            return Fluently.Configure()
                            .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString).ShowSql)
                            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TransacaoMaps>())
                            .BuildConfiguration();
        }
    }
}
    


