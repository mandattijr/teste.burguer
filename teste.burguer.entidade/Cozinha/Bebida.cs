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
    [Table("Bebida")]
    public class Bebida : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required, Column(TypeName = "VARCHAR"), StringLength(255)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Lista de itens")]
        public virtual List<ItemBebida> ItemBebida { get; set; }
    }
}
