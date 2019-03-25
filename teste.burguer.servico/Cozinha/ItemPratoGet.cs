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
    public class ItemPratoGet
    {
        private DataContext dbContext = new DataContext();
        private RepositoryService<ItemPrato> Repository;

        public ItemPratoGet() {
            Repository = new RepositoryService<ItemPrato>(dbContext);
        }

        public List<ItemPrato> Todos() {
            Expression<Func<ItemPrato, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public ItemPrato PorID(int id) {
            Expression<Func<ItemPrato, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
