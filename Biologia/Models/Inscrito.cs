using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biologia.Models
{
    public class Inscrito
    {
        public int inscritoId { get; set; }

        [Required]
        [DisplayName("Nome")]
        public string nome { get; set; }

        [Required]
        [DisplayName("Instituição")]
        public string instituicao { get; set; }

        [Required]
        [DisplayName("E-mail")]
        public string email { get; set; }

        [Required]
        [DisplayName("Telefone")]
        public string telefone { get; set; }

        [Required]
        [DisplayName("Curso")]
        public string curso { get; set; }
    }
}