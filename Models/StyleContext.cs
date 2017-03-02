using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CDM1._1.Models
{
    public class StyleContext : DbContext
    { 
        public DbSet<StyleType> StyleType { get; set; }
        public DbSet<StyleItems> StyleItems { get; set; }
    }
}