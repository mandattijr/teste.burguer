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
    public class UnidadeMedidaSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<UnidadeMedida> Repository;

        public UnidadeMedidaSet()
        {
            Repository = new RepositoryService<UnidadeMedida>(dbContext);
        }

        public UnidadeMedida Inserir(UnidadeMedida entity) {
            return Repository.Insert(entity);
        }
        public UnidadeMedida Atualizar(UnidadeMedida entity) {
            Expression<Func<UnidadeMedida, bool>> filter1 = x => x.Id.Equals(entity.Id);
            UnidadeMedida unidademedida = Repository.Filter(filter1).FirstOrDefault();
            unidademedida.DataCriacao = entity.DataCriacao;
            unidademedida.Sigla = entity.Sigla;
            unidademedida.Nome = entity.Nome;
            return Repository.Update(unidademedida);
        }

        public void Deletar(int id) {
            Expression<Func<UnidadeMedida, bool>> filter1 = x => x.Id.Equals(id);
            UnidadeMedida unidademedida = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(unidademedida);
        }
    }
}
