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
    public class PedidoGet
    {     
        private DataContext dbContext = new DataContext();
        private RepositoryService<Pedido> Repository;

        public PedidoGet() {
            Repository = new RepositoryService<Pedido>(dbContext);
        }

        public List<Pedido> Todos() {
            Expression<Func<Pedido, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public Pedido PorID(int id) {
            Expression<Func<Pedido, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
