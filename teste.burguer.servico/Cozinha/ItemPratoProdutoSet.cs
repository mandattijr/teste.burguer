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
    public class ItemPratoProdutoSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<ItemPratoProduto> Repository;

        public ItemPratoProdutoSet()
        {
            Repository = new RepositoryService<ItemPratoProduto>(dbContext);
        }

        public ItemPratoProduto Inserir(ItemPratoProduto entity) {
            return Repository.Insert(entity);
        }
        public ItemPratoProduto Atualizar(ItemPratoProduto entity) {
            Expression<Func<ItemPratoProduto, bool>> filter1 = x => x.Id.Equals(entity.Id);
            ItemPratoProduto itemPratoProduto = Repository.Filter(filter1).FirstOrDefault();
            itemPratoProduto.DataCriacao = entity.DataCriacao;
            itemPratoProduto.IdProduto = entity.IdProduto;
            itemPratoProduto.Quantidade = entity.Quantidade;
            return Repository.Update(itemPratoProduto);            
        }

        public void Deletar(int id) {
            Expression<Func<ItemPratoProduto, bool>> filter1 = x => x.Id.Equals(id);
            ItemPratoProduto ItemPratoProduto = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(ItemPratoProduto);
        }
    }
}