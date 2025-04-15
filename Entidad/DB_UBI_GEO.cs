using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_UBI_GEO
    {
        [Key, Column(Order = 0, TypeName = "char(3)")]
        public string COD_PAIS { get; set; }

        [Key, Column(Order = 1, TypeName = "smallint")]
        public short COD_DPTO { get; set; }

        [Key, Column(Order = 2, TypeName = "smallint")]
        public short COD_CIU { get; set; }

        [Key, Column(Order = 3, TypeName = "smallint")]
        public short COD_BARR { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string DES_PAIS { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string DES_DPTO { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string DES_CIU { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string DES_BARR { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string CAR_IDIOMA { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string DES_CON { get; set; }

        [ForeignKey("DB_REG_FIS")]
        [Column(TypeName = "smallint")]
        public short COD_REG { get; set; }
        public DB_REG_FIS DB_REG_FIS { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string UBI_LATITUD { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string UBI_LONGITUD { get; set; }

        [Column(TypeName = "char(20)")]
        public string COD_USER { get; set; }
        

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
