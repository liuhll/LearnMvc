using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvc.Context.Interfaces
{
    public interface IUnitOfWork<TDbContext>
        where TDbContext : IDbContext, new()
    {
        void BeginTransaction();

        void SaveChanges();
    }
}
