using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Naiva.Areas.Admin.Models
{
    public class OurDbContex : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}