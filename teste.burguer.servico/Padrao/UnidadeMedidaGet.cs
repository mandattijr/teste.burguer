using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.data;
using teste.burguer.entidade.Padrao;

namespace teste.burguer.servico.Padrao
{
    public class UnidadeMedidaGet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<UnidadeMedida> Repository;

        public UnidadeMedidaGet()
        {
            Repository = new RepositoryService<UnidadeMedida>(dbContext);
        }

        public List<UnidadeMedida> Todos() {
            Expression<Func<UnidadeMedida, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public UnidadeMedida PorID(int id) {
            Expression<Func<UnidadeMedida, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
