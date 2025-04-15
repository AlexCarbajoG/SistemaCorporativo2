using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_PROVEEDOR
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_PRV { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_PER { get; set; }

        [Required]
        public bool FLG_INH_MOV { get; set; }

        [Required]
        public short VAL_TIE_ATC { get; set; }

        [Required]
        [Column(TypeName = "numeric(20,4)")]
        public decimal VAL_CMN_UMO { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
