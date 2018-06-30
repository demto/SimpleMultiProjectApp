using Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class PersonConfiguration : EntityTypeConfiguration<PersonDto>
    {
        public PersonConfiguration()
        {
            // Table changes

            ToTable("PersonDtos");

            // Key changes

            HasKey(k => k.PersonId);

            // Property changes

            Property(p => p.PersonId)
            .HasColumnName("PersonId")
            .HasColumnOrder(0);

            Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

            Property(p => p.NickName)
            .HasMaxLength(100);

            // Relationship changes

        }
    }
}
