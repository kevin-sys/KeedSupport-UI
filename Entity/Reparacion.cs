using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reparacion
    {
        public string CodigoReparacion { get; set; }
        public DateTime FechaReparacion { get; set; }
        public Cliente Cliente { get; set; }
        public Equipo Equipo { get; set; }
        public string Solucion { get; set; }

    }
}
