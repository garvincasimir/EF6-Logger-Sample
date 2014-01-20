using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealTimeLogging
{
    public class DbInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            context.People.Add(new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 55

            });

            context.People.Add(new Person
            {
                FirstName = "Jane",
                LastName = "Smith",
                Age = 90

            });

            context.SaveChanges();
        }
    }
}