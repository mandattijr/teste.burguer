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
    public class CardapioGet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Cardapio> Repository;

        public CardapioGet() {
            Repository = new RepositoryService<Cardapio>(dbContext);
        }

        public List<Cardapio> Todos() {
            Expression<Func<Cardapio, bool>> filter1 = x => x.Id > -1;
            return Repository.Filter(filter1).ToList();
        }


        public Cardapio PorID(int id) {
            Expression<Func<Cardapio, bool>> filter1 = x => x.Id.Equals(id);
            return Repository.Filter(filter1).FirstOrDefault();
        }

    }
}
