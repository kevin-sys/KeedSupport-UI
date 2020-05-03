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
        public string NombreCliente { get; set; }
        public string Identificacion { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Color { get; set; }
        public string Accesorios { get; set; }
        public string Falla { get; set; }
        public string EstadoEquipo { get; set; }
        public string EstadoReparacion { get; set; }
        public string Solucion { get; set; }

    }
}
