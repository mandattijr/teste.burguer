using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.entidade.Estoque;

namespace teste.burguer.entidade.Cozinha
{
    [Table("ItemPratoProduto")]
    public class ItemPratoProduto : ClassBase
    {
        [Required, Column(TypeName = "INT")]
        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        [Required, ForeignKey("Produto")]
        [DisplayName("Identificador do produto")]
        public int IdProduto { get; set; }

        [DisplayName("Classe do produto")]
        public virtual Produto Produto { get; set; }

    }
}
