using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApi2014224.Models
{
    public class Telefono
    {
        [Key]
        public int idTelefono { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string almacenamientoInterno { get; set; }
        public string memoriaRam { get; set; }
    }
}