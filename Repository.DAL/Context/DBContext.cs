using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.Context
{
    class DBContext : DbContext
    {
        public DBContext() : base("ConnectionString") { }
    }
}
