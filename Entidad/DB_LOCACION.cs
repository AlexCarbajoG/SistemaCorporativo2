using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_LOCACION
    {
        [Required]
        public bool FLG_DEP_CEN { get; set; }

        [Key]
        [Column(TypeName = "char(20)")]
        public string COD_LOC { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_LOC { get; set; }

        [Required]
        public DateTime FEC_CREA { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_NOM_ENC { get; set; }

        [Required]
        public bool FLG_LOC_VIR { get; set; }

        [Required]
        [Column(TypeName = "char(3)")]
        public string COD_PAIS { get; set; }

        [Required]
        public short COD_DPTO { get; set; }

        [Required]
        public short COD_CIU { get; set; }

        [Required]
        public short COD_BARR { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_DIR_LOC { get; set; }

        [Required]
        [Column(TypeName = "numeric(20,4)")]
        public decimal VAL_ZLOC_ALT { get; set; }

        [Required]
        [Column(TypeName = "numeric(20,4)")]
        public decimal VAL_ZLOC_SUP { get; set; }

        [Required]
        public short VAL_COB_ESP { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
