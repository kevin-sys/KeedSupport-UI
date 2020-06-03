using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Equipo
    {
        public string NumeroSerie { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string EstadoEquipo { get; set; }
        public string FallaReportada { get; set; }
        public string Accesorios { get; set; }
        public List<Equipo> Equipos { get; set; }
    }
}
