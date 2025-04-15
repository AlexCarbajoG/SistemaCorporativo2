using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class N_SegmentosComerciales
    {
        private CD_SegmentosComerciales objcd_segmentos = new CD_SegmentosComerciales();

        public List<DB_SEG_COM> Listar()
        {
            return objcd_segmentos.Listar();
        }

        public bool Insertar(DB_SEG_COM segmento)
        {
            return objcd_segmentos.Insertar(segmento);
        }

        public bool Actualizar(DB_SEG_COM segmento)
        {
            return objcd_segmentos.Actualizar(segmento);
        }

        public bool Eliminar(string codSeg, string codSseg)
        {
            return objcd_segmentos.Eliminar(codSeg, codSseg);
        }
    }
}
