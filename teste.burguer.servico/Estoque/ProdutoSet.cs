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
    public class ProdutoSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Produto> Repository;

        public ProdutoSet()
        {
            Repository = new RepositoryService<Produto>(dbContext);
        }

        public Produto Inserir(Produto entity) {
            return Repository.Insert(entity);
        }
        public Produto Atualizar(Produto entity) {
            Expression<Func<Produto, bool>> filter1 = x => x.Id.Equals(entity.Id);
            Produto produto = Repository.Filter(filter1).FirstOrDefault();
            produto.DataCriacao = entity.DataCriacao;
            produto.IdTipoProduto = entity.IdTipoProduto;
            produto.IdUnidadeMedida = entity.IdUnidadeMedida;
            produto.Nome = entity.Nome;
            produto.Quantidade = entity.Quantidade;
            produto.TipoProduto = entity.TipoProduto;
            produto.UnidadeMedida = entity.UnidadeMedida;
            produto.ValorUnitario = entity.ValorUnitario;
            return Repository.Update(produto);
        }

        public void Deletar(int id) {
            Expression<Func<Produto, bool>> filter1 = x => x.Id.Equals(id);
            Produto Produto = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(Produto);
        }
    }
}
