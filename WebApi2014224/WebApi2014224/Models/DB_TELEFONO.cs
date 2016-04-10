using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace WebApi2014224.Models
{
    public class DB_TELEFONO:DbContext
    {
        public DB_TELEFONO():base("name=DB_TELEFONO") { }
        public DbSet<Telefono> telefono { get; set; }
    }
}