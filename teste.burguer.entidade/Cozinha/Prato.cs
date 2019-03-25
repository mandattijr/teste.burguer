using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.burguer.entidade.Cozinha
{
    [Table("Prato")]
    public class Prato : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required, Column(TypeName = "VARCHAR"), StringLength(255)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Lista de itens")]
        public virtual List<ItemPrato> ItemPrato { get; set; }
    }
}
