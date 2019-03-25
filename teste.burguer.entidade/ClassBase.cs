using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.burguer.entidade
{
    public class ClassBase
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("Id", Order = 1)]
        public int Id { get; set; }

        [Required, Column(TypeName = "DATETIME")]
        [DisplayName("Data de criação")]
        public DateTime DataCriacao { get; set; }

    }
}
