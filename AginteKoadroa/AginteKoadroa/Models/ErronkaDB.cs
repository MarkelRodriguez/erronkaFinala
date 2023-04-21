using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.Models
{
    internal class ErronkaDB : DbContext
    {

        public ErronkaDB() : base(nameOrConnectionString: "ErronkaDB")
        { }
        public DbSet<partida> partida { get; set; }
        public DbSet<erabiltzailea> erabiltzailea { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


        }
    }
}
