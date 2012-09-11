using System.ComponentModel.DataAnnotations;

namespace Biologia.Data
{
    public class Inscricao
    {
        [Key]
        public int inscricaoId { get; set; }
        public string nome { get; set; }
        public string instituicao { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string curso { get; set; }

        public Biologia.Domain.Inscricao ToDomainInscricao()
        {
            return new Domain.Inscricao
            {
                inscricaoId = this.inscricaoId,
                nome = this.nome,
                instituicao = this.instituicao,
                email = this.email,
                telefone = this.telefone,
                curso = this.curso
            };
        }
    }
}
