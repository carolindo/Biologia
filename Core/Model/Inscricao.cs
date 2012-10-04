using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace Core.Model
{
    public class Inscricao : Entity
    {
        [Required]
        [DisplayName("Tipo Inscrição")]
        public string tipoInsccricao { get; set; }

        public List<string> tipos { get; set; }

        public Inscricao()
        {
            tipos = new List<string>
            {
                "Ouvinte",
                "Apresentação Oral",
                "Poster"
            };
        }

        [Required]
        [DisplayName("Nome")]
        public string nome { get; set; }

        [Required]
        [DisplayName("Instituição")]
        public string instituicao { get; set; }

        [Required]
        [DisplayName("E-mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string email { get; set; }

        [Required]
        [DisplayName("Telefone")]
        public string telefone { get; set; }

        [Required]
        [DisplayName("Curso")]
        public string curso { get; set; }
    }
}
