using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EntregaEquipo
    {
        public string CodigoEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string NombreCliente { get; set; }
        public string Identificacion { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Color { get; set; }
        public string Accesorios { get; set; }
        public string Sintomas { get; set; }
        public string Solucion { get; set; }
        public string FallaReportada { get; set; }
        public string EstadoEntrega { get; set; }
        public float SubTotal { get; set; }
        public float PrecioManoObra { get; set; }
        public float TotalPagar { get; set; }

    }
}
