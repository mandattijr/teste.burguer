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
    public class ProdutoGet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Produto> Repository;

        public ProdutoGet() {
            Repository = new RepositoryService<Produto>(dbContext);
        }

        public List<Produto> Todos() {
            Expression<Func<Produto, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public Produto PorID(int id) {
            Expression<Func<Produto, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
