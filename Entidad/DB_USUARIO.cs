using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class DB_USUARIO
    {
        [Key]
        [Column(TypeName = "char(10)")]
        public string COD_USER { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string DES_USER { get; set; }

        [Required]
        [Column(TypeName = "char(20)")]
        public string EMAIL_USER { get; set; }

        [Required]
        [Column(TypeName = "char(20)")]
        public string CLAVE_USER { get; set; }

        [Required]
        public bool FLG_EST_USER { get; set; }

        [Required]
        public DateTime FEC_ABM { get; set; }

    }
}
