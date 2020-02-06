using System;
using System.Collections.Generic;
using System.Data.Entity;
using md753815MIS4200spring.Models;
using System.Linq;
using System.Web;

namespace md753815MIS4200spring.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, md753815MIS4200spring.Migration.MISContext.Configuration>("DefaultConnection"));
            // add the SetInitializer statement here
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Pets> Pets { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<Vets> Vets { get; set; }
        public DbSet<VisitDetail> visitDetail { get; set; }
        public DbSet<customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<orderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}