using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities=LearnMvc.Domain.Entities;

namespace LearnMvc.Context.Mapping
{
    public class ActionMap: EntityTypeConfiguration<Entities.Action>
    {
        public ActionMap()
        {
            HasKey(t => t.Id)
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.ActionName)
                .HasMaxLength(50)
                .IsRequired();


        }
    }
}
