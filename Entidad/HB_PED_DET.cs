using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class HB_PED_DET
    {
        [Key]
        [Column("DOC_NRO_PED", Order = 0, TypeName = "char(20)")]
        public string DOC_NRO_PED { get; set; }

        [Key, Column(Order = 1)]
        public short NRO_LINEA { get; set; }

        [Required]
        [Column(TypeName = "char(20)")]
        public string COD_ART { get; set; }

        [Required]
        public DateTime FEC_ENT_MER { get; set; }

        [Required]
        public decimal VAL_VTA_UND { get; set; }

        [Required]
        public decimal VAL_BONV_UND { get; set; }

        [Required]
        public decimal VAL_MON_UMO { get; set; }

        [Required]
        public decimal VAL_CVT_UMO { get; set; }

        [Required]
        public decimal VAL_IVA_UMO { get; set; }

        [Required]
        public decimal VAL_ENT_UND { get; set; }

        [Required]
        public decimal VAL_SAL_UND { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
