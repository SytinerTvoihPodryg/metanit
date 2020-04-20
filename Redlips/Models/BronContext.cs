using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Redlips.Models
{
    public class BronContext : DbContext
    {
        public DbSet<Bron> Bron { get; set; }
        public DbSet<Data> Data { get; set; }
    }
}