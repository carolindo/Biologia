using System.Collections.Generic;
using System.Linq;
using Biologia.Domain.Repository;

namespace Biologia.Data
{
    public class SqlInscricaoRepository : IinscricaoRepository
    {
        private string _connectionName, _schemaName;

        public SqlInscricaoRepository(string connectionName, string schemaName)
        {
            _connectionName = connectionName;
            _schemaName = schemaName;
        }

        public IEnumerable<Domain.Inscricao> PegarTodasIncricoes()
        {

            using (BiologiaContext context = new BiologiaContext(_connectionName, _schemaName))
            {
                IList<Data.Inscricao> inscricoes = context.Inscricoes.ToList<Data.Inscricao>();
                var inscricao = from inscricaoFeita in inscricoes
                                select inscricaoFeita.ToDomainInscricao();
                return inscricao.ToList<Domain.Inscricao>();
            }
        }

        public void CriarInscricao(Domain.Inscricao inscricao)
        {
            using (BiologiaContext context = new BiologiaContext(_connectionName, _schemaName))
            {
                context.Entry(new Data.Inscricao
                {
                    nome = inscricao.nome,
                    instituicao = inscricao.instituicao,
                    email = inscricao.email,
                    telefone = inscricao.telefone,
                    curso = inscricao.curso
                }).State = System.Data.EntityState.Added;
                context.SaveChanges();
            }
        }

        public Domain.Inscricao DetalheInscricao(int id)
        {
            using (BiologiaContext context = new BiologiaContext(_connectionName, _schemaName))
            {
                var inscricao = context.Inscricoes.Find(id);
                if (inscricao != null)
                {
                    return inscricao.ToDomainInscricao();
                }
                return null;
            }
        }

        public void EditarInscricao(Domain.Inscricao inscricao)
        {
            using (BiologiaContext context = new BiologiaContext(_connectionName, _schemaName))
            {
                context.Entry(new Data.Inscricao
                {
                    inscricaoId = inscricao.inscricaoId,
                    nome = inscricao.nome,
                    instituicao = inscricao.instituicao,
                    email = inscricao.email,
                    telefone = inscricao.telefone,
                    curso = inscricao.curso
                }).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeletarInscricao(int id)
        {
            using (BiologiaContext context = new BiologiaContext(_connectionName, _schemaName))
            {
                Data.Inscricao inscricao = context.Inscricoes.Find(id);
                context.Entry(inscricao).State = System.Data.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
