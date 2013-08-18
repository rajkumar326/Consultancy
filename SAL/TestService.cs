using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAL
{
    public class TestService:ItestService
    {
        private IManageUnitOfWork _context;
        public TestService(IManageUnitOfWork context)
        {
            _context = context;
        }
        public void GetData()
        {

        }
    }
}
