using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    [Table("LICENCIA")]
    public class LICENCIA
    {
        [Key]
        [Column(Order = 0, TypeName = "char(12)")]
        public string NRO_LIC { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "varchar(30)")]
        public string NOM_EMP { get; set; }

        [Column(TypeName = "smallint")]
        public short ANO_CREA_EMP { get; set; }

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

        [Column(TypeName = "char(20)")]
        public string DES_SIM_MON { get; set; }

        [Column(TypeName = "char(3)")]
        public string COD_PAIS { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string DES_DIR_EMP { get; set; }
    }
}
