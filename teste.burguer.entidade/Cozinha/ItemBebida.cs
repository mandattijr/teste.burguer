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
    [Table("ItemBebida")]
    public class ItemBebida : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required, Column(TypeName = "INT")]
        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        [Required, ForeignKey("Produto")]
        [DisplayName("Identificador do produto")]
        public int IdProduto { get; set; }

        [Required, ForeignKey("Bebida")]
        [DisplayName("Identificador da bebida")]
        public int IdBebida { get; set; }

        [DisplayName("Classe do produto")]
        public virtual Produto Produto { get; set; }

        [DisplayName("Classe da bebida")]
        public virtual Bebida Bebida { get; set; }

    }
}
