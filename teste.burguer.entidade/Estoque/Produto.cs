    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.burguer.entidade.Padrao;

namespace teste.burguer.entidade.Estoque
{
    [Table("Produto")]
    public class Produto : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required, Column(TypeName = "INT")]
        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

        [Required, Column(TypeName = "DECIMAL")]
        [DisplayName("Valor unitário")]
        public decimal ValorUnitario { get; set; }

        [Required, ForeignKey("TipoProduto")]
        [DisplayName("Identificador do tipo de produto")]
        public int IdTipoProduto { get; set; }

        [Required, ForeignKey("UnidadeMedida")]
        [DisplayName("Identificador da unidade de medida")]
        public int IdUnidadeMedida { get; set; }

        [DisplayName("Classe do tipo do produto")]
        public virtual TipoProduto TipoProduto { get; set; }

        [DisplayName("Classe da unidade de medida")]
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }
}
