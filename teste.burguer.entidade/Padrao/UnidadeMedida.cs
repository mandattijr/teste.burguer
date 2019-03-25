using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.burguer.entidade.Padrao
{
    [Table("UnidadeMedida")]
    public class UnidadeMedida : ClassBase
    {
        [Required, Column(TypeName = "VARCHAR"), StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required, Column(TypeName = "VARCHAR"), StringLength(2)]
        [DisplayName("Sigla")]
        public string Sigla { get; set; }
    }
}
