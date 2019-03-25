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
    public class ItemPratoSet
    {
        private DataContext dbContext = new DataContext();
        private RepositoryService<ItemPrato> Repository;

        public ItemPratoSet()
        {
            Repository = new RepositoryService<ItemPrato>(dbContext);
        }

        public ItemPrato Inserir(ItemPrato entity) {
            return Repository.Insert(entity);
        }
        public ItemPrato Atualizar(ItemPrato entity) {
            Expression<Func<ItemPrato, bool>> filter1 = x => x.Id.Equals(entity.Id);
            ItemPrato ItemPrato = Repository.Filter(filter1).FirstOrDefault();
            return Repository.Update(ItemPrato);
        }

        public void Deletar(int id) {
            Expression<Func<ItemPrato, bool>> filter1 = x => x.Id.Equals(id);
            ItemPrato ItemPrato = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(ItemPrato);
        }
    }
}
