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
    public class ItemBebidaGet
    {     
        private DataContext dbContext = new DataContext();
        private RepositoryService<ItemBebida> Repository;

        public ItemBebidaGet() {
            Repository = new RepositoryService<ItemBebida>(dbContext);
        }

        public List<ItemBebida> Todos() {
            Expression<Func<ItemBebida, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public ItemBebida PorID(int id) {
            Expression<Func<ItemBebida, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
