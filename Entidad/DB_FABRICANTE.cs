using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_FABRICANTE
    {
        [Key]
        [Column(TypeName = "char(20)")]
        public string COD_FABRICANTE { get; set; }

        [Required]
        [Column(TypeName = "char(10)")]
        public string COD_PER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }
    }
}
