using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_SEG_COM
    {
        [Key, Column(Order = 0, TypeName = "char(10)")]
        public string COD_SEG { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_SEG { get; set; }

        [Key, Column(Order = 1, TypeName = "char(10)")]
        public string COD_SSEG { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_SSEG { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
