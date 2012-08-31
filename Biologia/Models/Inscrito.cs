using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biologia.Models
{
    public class Inscrito
    {
        public int inscritoId { get; set; }
        public string nome { get; set; }
        public string instituicao { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
    }
}