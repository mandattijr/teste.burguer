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
    public class PratoGet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Prato> Repository;

        public PratoGet() {
            Repository = new RepositoryService<Prato>(dbContext);
        }

        public List<Prato> Todos()
        {
            Expression<Func<Prato, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public Prato PorID(int id)
        {
            Expression<Func<Prato, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
