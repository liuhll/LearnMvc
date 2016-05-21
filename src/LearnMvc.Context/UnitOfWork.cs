using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnMvc.Context.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace LearnMvc.Context
{
   public class UnitOfWork<TContext> :IUnitOfWork<TContext>,IDisposable
        where TContext:IDbContext,new ()
   {
       private readonly IContextManager<TContext> _contextManager =
           ServiceLocator.Current.GetAllInstances<ContextManager<TContext>>() as IContextManager<TContext>;

       private readonly IDbContext _dbContext;
       private bool _disposed;

       public UnitOfWork()
       {
           _dbContext = _contextManager.GetContext();
       }


       public void BeginTransaction()
       {
           _disposed = false;
       }

       public void SaveChanges()
       {
           _dbContext.SaveChanges();
       }

       public void Dispose()
       {
           Dispose(true);
           GC.SuppressFinalize(this);
       }

       protected virtual void Dispose(bool disposing)
       {
           if (!_disposed)
           {
               if (disposing)
               {
                   _dbContext.Dispose();
               }
           }
           _disposed = true;
       }
    }
}
