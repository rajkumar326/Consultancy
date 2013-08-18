using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public interface IUnitOfWork:IDisposable
    {
        int SaveChanges();
    }

    public interface IManageUnitOfWork : IUnitOfWork
    {        
        
    }

   
}
