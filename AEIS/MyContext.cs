using SQLite.CodeFirst;
using System.Data.Entity;

namespace AEIS.Models
{
    public class MyContext : DbContext
    {
        public MyContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Point> Points { get; set; }
    }
}
