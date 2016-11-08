using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Burse.LinqToMSSql;

namespace DataAccessLayer
{
    public class MSSqlRepository
    {
        System.Data.Linq.DataContext Repository;

        public MSSqlRepository()
        {
            Repository = new BurseMSSqlDataContext();
        }
    }
}
