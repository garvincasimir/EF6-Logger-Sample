using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealTimeLogging
{
    public class DbConfig : DbConfiguration
    {
        public DbConfig()
        {
            this.SetDatabaseInitializer<PersonContext>(new DbInitializer());
        }
    }
}