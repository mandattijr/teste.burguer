using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.data;
using teste.burguer.entidade.Salao;

namespace teste.burguer.servico.Salao
{
    public class ItemPedidoGet
    {
        private DataContext dbContext = new DataContext();
        private RepositoryService<ItemPedido> Repository;

        public ItemPedidoGet() {
            Repository = new RepositoryService<ItemPedido>(dbContext);
        }

        public List<ItemPedido> Todos() {
            Expression<Func<ItemPedido, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public ItemPedido PorID(int id) {
            Expression<Func<ItemPedido, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
