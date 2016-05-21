using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using LearnMvc.Domain.Entities;

namespace LearnMvc.Context.Mapping
{
    public class GroupManagerMap : EntityTypeConfiguration<GroupManager>
    {
        public GroupManagerMap()
        {
            HasKey(t => t.Id)
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.CreateUserId)
                .IsRequired();

            Property(t => t.GroupInfo)
                .HasMaxLength(200);

            Property(p => p.CreateUserId)
                .IsRequired();


        }
    }
}