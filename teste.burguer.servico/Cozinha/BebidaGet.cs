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
    public class BebidaGet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Bebida> Repository;

        public BebidaGet() {
            Repository = new RepositoryService<Bebida>(dbContext);
        }

        public List<Bebida> Todos() {
            Expression<Func<Bebida, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public Bebida PorID(int id) {
            Expression<Func<Bebida, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
