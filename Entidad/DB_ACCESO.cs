using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_ACCESO
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        [Column(TypeName = "char(20)")]
        public string COD_ALM { get; set; }

        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_OPCION { get; set; }

        [Required]
        public bool FLG_EST_ACC { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }

        // Definir las relaciones con las tablas DB_USUARIO y DB_MENU
        [ForeignKey("COD_USER")]
        public virtual DB_USUARIO Usuario { get; set; }

        [ForeignKey("COD_OPCION")]
        public virtual DB_MENU Menu { get; set; }
    }
}
