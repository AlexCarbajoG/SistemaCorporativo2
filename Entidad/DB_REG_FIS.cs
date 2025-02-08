using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_REG_FIS
    {
        [Key]
        [Column(TypeName = "smallint")]
        public short COD_REG { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_REG { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
