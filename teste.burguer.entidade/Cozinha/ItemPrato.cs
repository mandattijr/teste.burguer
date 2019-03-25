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
    [Table("ItemPrato")]
    public class ItemPrato : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required, ForeignKey("Prato")]
        [DisplayName("Identificador do prato")]
        public int IdPrato { get; set; }

        [DisplayName("Lista de produtos")]
        public virtual List<ItemPratoProduto> ItemPratoProduto { get; set; }

        [DisplayName("Classe do prato")]
        public virtual Prato Prato { get; set; }

    }
}
