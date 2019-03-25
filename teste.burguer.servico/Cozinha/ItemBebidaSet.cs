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
    public class ItemBebidaSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<ItemBebida> Repository;

        public ItemBebidaSet()
        {
            Repository = new RepositoryService<ItemBebida>(dbContext);
        }

        public ItemBebida Inserir(ItemBebida entity) {
            return Repository.Insert(entity);
        }
        public ItemBebida Atualizar(ItemBebida entity) {
            Expression<Func<ItemBebida, bool>> filter1 = x => x.Id.Equals(entity.Id);
            ItemBebida itemBebida = Repository.Filter(filter1).FirstOrDefault();
            itemBebida.DataCriacao = entity.DataCriacao;
            return Repository.Update(itemBebida);
        }

        public void Deletar(int id) {
            Expression<Func<ItemBebida, bool>> filter1 = x => x.Id.Equals(id);
            ItemBebida ItemBebida = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(ItemBebida);
        }
    }
}
