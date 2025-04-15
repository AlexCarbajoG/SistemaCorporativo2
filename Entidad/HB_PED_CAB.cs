using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class HB_PED_CAB
    {
        [Key]
        [Column(TypeName = "char(20)")]
        public string DOC_NRO_PED { get; set; }

        [Required]
        [Column(TypeName = "char(20)")]
        public string COD_LOC { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_CLI { get; set; }

        [Required]
        public DateTime FEC_MOV { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_VEN { get; set; }

        [Column(TypeName = "char(20)")]
        public string NRO_RUC { get; set; }

        [Column(TypeName = "char(10)")]
        public string DOC_REF { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string TXT_OBSERVACION { get; set; }

        [Required]
        public bool FLG_EST_PED { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
