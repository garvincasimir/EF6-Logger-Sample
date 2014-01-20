using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealTimeLogging
{
    [DbConfigurationType(typeof(DbConfig))]
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}