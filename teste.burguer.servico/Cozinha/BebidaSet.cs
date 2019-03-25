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
    public class BebidaSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Bebida> Repository;

        public BebidaSet()
        {
            Repository = new RepositoryService<Bebida>(dbContext);
        }

        public Bebida Inserir(Bebida entity) {
            return Repository.Insert(entity);
        }
        public Bebida Atualizar(Bebida entity) {
            Expression<Func<Bebida, bool>> filter1 = x => x.Id.Equals(entity.Id);
            Bebida bebida = Repository.Filter(filter1).FirstOrDefault();
            bebida.DataCriacao = entity.DataCriacao;
            bebida.Descricao = entity.Descricao;
            bebida.Id = entity.Id;
            bebida.Nome = entity.Nome;
            return Repository.Update(bebida);
        }

        public void Deletar(int id) {
            Expression<Func<Bebida, bool>> filter1 = x => x.Id.Equals(id);
            Bebida Bebida = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(Bebida);
        }
    }
}
