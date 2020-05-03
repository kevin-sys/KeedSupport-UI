using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BaseDeFallas
    {
        public string CodigoFalla { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Falla { get; set; }
        public string Sintomas { get; set; }
        public string Solucion { get; set; }
    }
}
