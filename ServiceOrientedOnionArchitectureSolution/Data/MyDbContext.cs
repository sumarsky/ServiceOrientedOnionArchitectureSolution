using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entities.Entities;

namespace Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("MyDbContextConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;

            Database.SetInitializer<MyDbContext>(new MyDbInitializer());
        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class MyDbInitializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            //// create 3 students to seed the database
            //context.Students.Add(new Student { ID = 1, FirstName = "Mark", LastName = "Richards", EnrollmentDate = DateTime.Now });
            //context.Students.Add(new Student { ID = 2, FirstName = "Paula", LastName = "Allen", EnrollmentDate = DateTime.Now });
            //context.Students.Add(new Student { ID = 3, FirstName = "Tom", LastName = "Hoover", EnrollmentDate = DateTime.Now });
            context.Players.Add(new Player {Name = "Igor"});
            base.Seed(context);
        }
    }
}
