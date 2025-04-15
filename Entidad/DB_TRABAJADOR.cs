using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_TRABAJADOR
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_TRA { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_PER { get; set; }

        [Required]
        public bool FLG_INH_MOV { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
