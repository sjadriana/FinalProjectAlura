using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProjectAlura.Models
{
    public class Perfil
    {
        [Key]
        public string Nome { get; set; }
    }
}