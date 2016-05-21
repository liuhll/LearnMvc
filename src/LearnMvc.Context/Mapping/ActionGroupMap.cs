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
    public class ActionGroupMap : EntityTypeConfiguration<ActionGroup>
    {
        public ActionGroupMap()
        {
            HasKey(t => t.Id)
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.ActionId)
                .IsRequired();

            Property(t => t.CreateUserId)
                .IsRequired();

            Property(t => t.GroupManagerId)
                .IsRequired();

            Property(t => t.CreateDateTime)
                .IsRequired();

            //定义表外键
            HasRequired(t => t.Action)
                .WithMany(t => t.ActionGroups)
                .HasForeignKey(t => t.ActionId);

            HasRequired(t => t.GroupManager)
                .WithMany(t => t.ActionGroups)
                .HasForeignKey(t => t.GroupManagerId);


        }
    }
}
