using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class ContactsContext: DbContext
    {
        public ContactsContext(): base("DefaultConnection")
        {

        }
        public DbSet<User> UserProfiles { get; set; }

    }
}