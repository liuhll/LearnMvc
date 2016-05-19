using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnMvc.Domain.Entities;

namespace LearnMvc.Context.Mapping
{
    public class ActionColumnMap: EntityTypeConfiguration<ActionColumn>
    {
        public ActionColumnMap()
        {
            HasKey(t => t.ActionColumnId)
                .Property(t => t.ActionColumnId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.ActionColumnName)
                .IsRequired();

            HasRequired(t => t.Action)
                .WithMany(t => t.ActionColumn)
                .HasForeignKey(t => t.ActionId);
        }
    }
}
