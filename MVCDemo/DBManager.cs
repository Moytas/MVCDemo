using MVCDemo.Models;
using System.Data.Entity;

namespace MVCDemo
{
    public class DBManager : System.Data.Entity.DbContext
    {
        public DBManager() : base()
        {
            Database.SetInitializer<DBManager>(new CreateDatabaseIfNotExists<DBManager>());

        }

        public DbSet<ModelClass> DBElements { get; set; }
    }
}
