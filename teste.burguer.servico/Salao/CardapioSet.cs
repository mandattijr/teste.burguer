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
    public class CardapioSet
    {        
        private DataContext dbContext = new DataContext();
        private RepositoryService<Cardapio> Repository;

        public CardapioSet()
        {
            Repository = new RepositoryService<Cardapio>(dbContext);
        }

        public Cardapio Inserir(Cardapio entity) {
            return Repository.Insert(entity);
        }
        public Cardapio Atualizar(Cardapio entity) {
            Expression<Func<Cardapio, bool>> filter1 = x => x.Id.Equals(entity.Id);
            Cardapio Cardapio = Repository.Filter(filter1).FirstOrDefault();
            Cardapio.DataCriacao = entity.DataCriacao;
            Cardapio.Descricao = entity.Descricao;
            Cardapio.Id = entity.Id;
            Cardapio.Nome = entity.Nome;
            return Repository.Update(Cardapio);
        }

        public void Deletar(int id) {
            Expression<Func<Cardapio, bool>> filter1 = x => x.Id.Equals(id);
            Cardapio Cardapio = Repository.Filter(filter1).FirstOrDefault();
            Repository.Delete(Cardapio);
        }
    }
}
