using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProjectAlura.Models
{
    public class Context: DbContext
    {
        public DbSet<Perfil> Perfils { get; set; }
    }
}