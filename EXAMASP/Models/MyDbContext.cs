using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EXAMASP.Models
{
    public class MyDbContext : DbContext
    {
        public System.Data.Entity.DbSet<EXAMASP.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<EXAMASP.Models.Category> Categories { get; set; }
    }
}