using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_MAR_ART
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_MAR { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_MAR { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
