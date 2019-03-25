using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.entidade.Cozinha;
using teste.burguer.entidade.Estoque;

namespace teste.burguer.entidade.Salao
{
    [Table("Cardapio")]
    public class Cardapio : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required, Column(TypeName = "VARCHAR"), StringLength(255)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [ForeignKey("Produto")]
        [DisplayName("Identificador do produto")]
        public int IdProduto { get; set; }

        [ForeignKey("Bebida")]
        [DisplayName("Identificador da bebida")]
        public int IdBebida { get; set; }

        [ForeignKey("Prato")]
        [DisplayName("Identificador da prato")]
        public int IdPrato { get; set; }

        [DisplayName("Classe do produto")]
        public virtual Produto Produto { get; set; }

        [DisplayName("Classe de bebida")]
        public virtual Bebida Bebida { get; set; }

        [DisplayName("Classe do prato")]
        public virtual Prato Prato { get; set; }

    }
}
