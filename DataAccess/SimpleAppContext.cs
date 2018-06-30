using DataAccess.EntityConfigurations;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SimpleAppContext : DbContext
    {
        public DbSet<PersonDto> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
