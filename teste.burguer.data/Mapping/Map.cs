using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.entidade;
using teste.burguer.entidade.Cozinha;
using teste.burguer.entidade.Estoque;
using teste.burguer.entidade.Padrao;
using teste.burguer.entidade.Salao;

namespace teste.burguer.data.Mapping
{
    public class Map
    {
        public class BebidaMap : EntityTypeConfiguration<Bebida> { }
        public class ItemBebidaMap : EntityTypeConfiguration<ItemBebida> { }
        public class ItemPratoMap : EntityTypeConfiguration<ItemPrato> { }
        public class ItemPratoProdutoMap : EntityTypeConfiguration<ItemPratoProduto> { }
        public class PratoMap : EntityTypeConfiguration<Prato> { }
        public class ProdutoMap : EntityTypeConfiguration<Produto> { }
        public class TipoProdutoMap : EntityTypeConfiguration<TipoProduto> { }
        public class UnidadeMedidaMap : EntityTypeConfiguration<UnidadeMedida> { }
        public class CardapioMap : EntityTypeConfiguration<Cardapio> { }
        public class PedidoMap : EntityTypeConfiguration<Pedido> { }
        public class StatusPedidoMap : EntityTypeConfiguration<StatusPedido> { }
    }
}
