using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Producto
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Color { get; set; }
        public string EstadoEquipo { get; set; }
        public  List<Producto> Productos { get; set; }
        public string Falla { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float SubTotal
        { 
            get
            {
                return Cantidad * Precio;
            } 
        }
        public float PorcentajeIVA { get; set; }

        public float ValorIVa 
        { 
            get 
            {
                return SubTotal * (PorcentajeIVA/ 100);

               
            } 
        }



    }
}
