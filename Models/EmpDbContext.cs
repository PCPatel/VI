using System.Data.Entity;

namespace VI.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext() : base("name=EmpDbContext")
        {

        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<PayMaster> PayMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PayMaster>()
                .HasRequired(x => x.Employee)
                .WithMany(x=>x.PayMaster)
                .WillCascadeOnDelete(false);
        }
    }
}