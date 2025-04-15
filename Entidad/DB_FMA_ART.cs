using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_FMA_ART
    {
        [Key, Column(Order = 0, TypeName = "char(10)")]
        public string COD_CAT { get; set; }

        [Required, Column(TypeName = "varchar(80)")]
        public string DES_CAT { get; set; }

        [Key, Column(Order = 1, TypeName = "char(10)")]
        public string COD_LIN { get; set; }

        [Required, Column(TypeName = "varchar(80)")]
        public string DES_LIN { get; set; }

        [Required, Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
