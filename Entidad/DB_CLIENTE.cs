using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_CLIENTE
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_CLI { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_PER { get; set; }

        [Column(TypeName = "char(10)")]
        public string COD_GRP_EMP { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_VEN { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_SEG { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_SSEG { get; set; }

        [Required]
        public bool FLG_INH_MOV { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
