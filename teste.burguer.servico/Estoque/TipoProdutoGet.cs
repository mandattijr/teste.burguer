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
    public class TipoProdutoGet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<TipoProduto> Repository;

        public TipoProdutoGet()
        {
            Repository = new RepositoryService<TipoProduto>(dbContext);
        }

        public List<TipoProduto> Todos() {
            Expression<Func<TipoProduto, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public TipoProduto PorID(int id) {
            Expression<Func<TipoProduto, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
