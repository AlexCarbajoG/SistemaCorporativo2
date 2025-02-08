using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_MENU
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_OPCION { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_OPCION { get; set; }

        [Required]
        public bool FLG_EST_OPC { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
