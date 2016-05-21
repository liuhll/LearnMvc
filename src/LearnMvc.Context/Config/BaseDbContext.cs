using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnMvc.Context.Interfaces;

namespace LearnMvc.Context.Config
{
    public class BaseDbContext:DbContext,IDbContext
    {
        public BaseDbContext(string connetcionStringName, Guid? currentUserId=null)
            : base(connetcionStringName)
        {
            CurrentUserId = currentUserId;
        }

        public new DbSet Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public Guid? CurrentUserId { get; private set; }
    }
}
