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
    [Table("StatusPedido")]
    public class StatusPedido : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
    }
}
