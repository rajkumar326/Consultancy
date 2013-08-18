using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ManageUnitOfWork : IManageUnitOfWork
    {
        #region Fields
        private DB dbContext;
        //  private IAccountRepository accounts;

        #endregion

        #region Constructor
        public ManageUnitOfWork(DB context)
        {
            dbContext = context;
        }

        #endregion

        #region Property

        //public IAccountRepository Accounts
        //{
        //    get
        //    {
        //        if (accounts == null)
        //            accounts = new AccountRepository(dbContext);
        //        return accounts;
        //    }
        //}
        #endregion
        #region Utility
        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            //if (categories != null)
            //    categories.Dispose();        
            if (dbContext != null)
                dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
