using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_ARTICULO
    {
        [Key]
        [Column(TypeName = "char(20)")]
        public string COD_ART { get; set; }

        [Column(TypeName = "char(20)")]
        public string COD_UNICO { get; set; }

        [Column(TypeName = "char(20)")]
        public string COD_PADRE { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string DES_ART { get; set; }

        [Column(TypeName = "char(20)")]
        public string COD_FABRICANTE { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CAR_UND_VTAP { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CAR_UND_VTAS { get; set; }

        public short VAL_NCOMP_VTAS { get; set; }

        public decimal CAR_UND_COMPACK { get; set; }

        [Column(TypeName = "char(10)")]
        public string COD_CAT { get; set; }

        [Column(TypeName = "char(10)")]
        public string COD_LIN { get; set; }

        [Column(TypeName = "char(10)")]
        public string COD_MAR { get; set; }

        [Column(TypeName = "char(10)")]
        public string COD_PRV { get; set; }

        public decimal VAL_TAS_IVA { get; set; }
        public decimal VAL_PUM_UMO { get; set; }
        public decimal VAL_CUN_UMO { get; set; }
        public decimal VAL_SSG_ESP { get; set; }
        public decimal VAL_STK_EXP { get; set; }
        public decimal VAL_VTA_MIN { get; set; }

        public bool FLG_ORIGEN { get; set; }
        public bool FLG_VTA_LIBRE { get; set; }
        public bool FLG_ART_CTR { get; set; }
        public bool FLG_ART_FRA { get; set; }
        public bool FLG_CAD_FRIO { get; set; }
        public bool FLG_ART_INA { get; set; }
        public bool FLG_INH_VTA { get; set; }
        public bool FLG_INH_COM { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string CAR_ADICIONAL { get; set; }

        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        public DateTime FEC_ABM { get; set; }
    }
}
