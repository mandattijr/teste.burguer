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
    public class ItemPedido: ClassBase
    {
        [ForeignKey("Cardapio")]
        [DisplayName("Identificador de Cardapio")]
        public int IdCardapio { get; set; }

        [Required, Column(TypeName = "INT")]
        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

    }
}
