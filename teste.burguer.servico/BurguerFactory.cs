using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.data;
using teste.burguer.entidade;
using teste.burguer.entidade.Cozinha;
using teste.burguer.entidade.Estoque;
using teste.burguer.entidade.Padrao;
using teste.burguer.entidade.Salao;
using teste.burguer.servico;
using teste.burguer.servico.Cozinha;
using teste.burguer.servico.Estoque;
using teste.burguer.servico.Padrao;
using teste.burguer.servico.Salao;


namespace teste.burguer.servico {
    public class BurguerFactory {
        public static BurguerFactory Instance {
            get { return Singleton<BurguerFactory>.Instance; }
        }

        public BebidaGet BebidaGet()
        {
            return new BebidaGet();
        }

        public BebidaSet BebidaSet()
        {
            return new BebidaSet();
        }

        public ItemBebidaGet ItemBebidaGet()
        {
            return new ItemBebidaGet();
        }

        public ItemBebidaSet ItemBebidaSet()
        {
            return new ItemBebidaSet();
        }

        public PratoGet PratoGet()
        {
            return new PratoGet();
        }

        public PratoSet PratoSet()
        {
            return new PratoSet();
        }

        public ItemPratoGet ItemPratoGet()
        {
            return new ItemPratoGet();
        }

        public ItemPratoSet ItemPratoSet()
        {
            return new ItemPratoSet();
        }

        public ItemPratoProdutoGet ItemPratoProdutoGet()
        {
            return new ItemPratoProdutoGet();
        }

        public ItemPratoProdutoSet ItemPratoProdutoSet()
        {
            return new ItemPratoProdutoSet();
        }

        public ProdutoGet ProdutoGet()
        {
            return new ProdutoGet();
        }

        public ProdutoSet ProdutoSet()
        {
            return new ProdutoSet();
        }

        public TipoProdutoGet TipoProdutoGet()
        {
            return new TipoProdutoGet();
        }

        public TipoProdutoSet TipoProdutoSet()
        {
            return new TipoProdutoSet();
        }

        public UnidadeMedidaGet UnidadeMedidaGet()
        {
            return new UnidadeMedidaGet();
        }

        public UnidadeMedidaSet UnidadeMedidaSet()
        {
            return new UnidadeMedidaSet();
        }

        public CardapioGet CardapioGet()
        {
            return new CardapioGet();
        }

        public CardapioSet CardapioSet()
        {
            return new CardapioSet();
        }

    }
}
