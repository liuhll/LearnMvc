using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnMvc.Context.Config;
using LearnMvc.Context.Mapping;

namespace LearnMvc.Context
{
    public class MvcDbContext : BaseDbContext
    {
        public MvcDbContext()
            : base("LearnMvcEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ActionMap());
            modelBuilder.Configurations.Add(new ActionColumnMap());
            modelBuilder.Configurations.Add(new ActionGroupMap());
            modelBuilder.Configurations.Add(new GroupManagerMap());
            modelBuilder.Configurations.Add(new UserGroupMap());
            modelBuilder.Configurations.Add(new UserMap());

        }
    }
}
