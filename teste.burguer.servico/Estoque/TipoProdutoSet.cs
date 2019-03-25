using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.data;
using teste.burguer.entidade.Estoque;

namespace teste.burguer.servico.Estoque
{
    public class TipoProdutoSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<TipoProduto> Repository;

        public TipoProdutoSet()
        {
            Repository = new RepositoryService<TipoProduto>(dbContext);
        }

        public TipoProduto Inserir(TipoProduto entity) {
            return Repository.Insert(entity);
        }
        public TipoProduto Atualizar(TipoProduto entity) {
            Expression<Func<TipoProduto, bool>> filter1 = x => x.Id.Equals(entity.Id);
            TipoProduto tipoproduto = Repository.Filter(filter1).FirstOrDefault();
            tipoproduto.DataCriacao = entity.DataCriacao;
            tipoproduto.Nome = entity.Nome;
            return Repository.Update(tipoproduto);
        }

        public void Deletar(int id) {
            Expression<Func<TipoProduto, bool>> filter1 = x => x.Id.Equals(id);
            TipoProduto TipoProduto = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(TipoProduto);
        }
    }
}
