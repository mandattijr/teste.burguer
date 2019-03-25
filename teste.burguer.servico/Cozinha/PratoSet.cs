using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.data;
using teste.burguer.entidade.Cozinha;

namespace teste.burguer.servico.Cozinha
{
    public class PratoSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Prato> Repository;

        public PratoSet()
        {
            Repository = new RepositoryService<Prato>(dbContext);
        }

        public Prato Inserir(Prato entity)
        {
            return Repository.Insert(entity);
        }
        public Prato Atualizar(Prato entity)
        {
            Expression<Func<Prato, bool>> filter1 = x => x.Id.Equals(entity.Id);
            Prato prato = Repository.Filter(filter1).FirstOrDefault();
            prato.DataCriacao = entity.DataCriacao;
            prato.Descricao = entity.Descricao;
            prato.Nome = entity.Nome;
            return Repository.Update(prato);           
        }

        public void Deletar(int id) {
            Expression<Func<Prato, bool>> filter1 = x => x.Id.Equals(id);
            Prato prato = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(prato);
        }
    }
}
