using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cupon
    {
        public string CodigoCupon { get; set; }
        public string Descripcion { get; set; }
        public float Porcentaje { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int VigenciaEnDias { get; set; }
    }
}
