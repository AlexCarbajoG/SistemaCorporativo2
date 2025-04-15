using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_PERSONA
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_PER { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_PER { get; set; }

        [Required]
        public bool FLG_PER_JUR { get; set; }

        [Required]
        public bool FLG_SEX_PER { get; set; }

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
        public string DES_DIR { get; set; }

        [Column(TypeName = "char(20)")]
        public string NRO_RUC { get; set; }

        [Column(TypeName = "char(20)")]
        public string EMAIL_EMP { get; set; }

        [Column(TypeName = "char(20)")]
        public string EMP_TELF1 { get; set; }

        [Column(TypeName = "char(20)")]
        public string EMP_TELF2 { get; set; }

        [Column(TypeName = "char(20)")]
        public string WWW_URL { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
