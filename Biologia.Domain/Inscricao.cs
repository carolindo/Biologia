using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biologia.Domain
{
    public class Inscricao
    {
        public int inscricaoId { get; set; }

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