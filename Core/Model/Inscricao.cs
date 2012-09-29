using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Core.Model
{
    public class Inscricao : Entity
    {
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
