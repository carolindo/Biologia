using System.Collections.Generic;

namespace Biologia.Domain.Repository
{
    public interface IinscricaoRepository
    {
        IEnumerable<Inscricao> PegarTodasIncricoes();
        void CriarInscricao(Inscricao inscricao);
        Inscricao DetalheInscricao(int id);
        void EditarInscricao(Inscricao inscricao);
        void DeletarInscricao(int id);
    }
}
