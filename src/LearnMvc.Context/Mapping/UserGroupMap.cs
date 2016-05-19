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
    public class UserGroupMap:EntityTypeConfiguration<UserGroup>
    {
        public UserGroupMap()
        {
            HasKey(t => t.Id)
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(t => t.GroupManager)
                .WithMany(t => t.UserGroups)
                .HasForeignKey(t => t.GroupId);

            HasRequired(t => t.User)
                .WithMany(t => t.UserGroups)
                .HasForeignKey(t => t.UserId);

        }
    }
}
