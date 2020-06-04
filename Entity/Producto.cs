using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Producto
    {
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public List<Producto> Productos { get; set; }
        public float Cantidad { get; set; }
        public float Total { get; set; }
        public DateTime FechaRegistro { get; set; }
        public float PorcentajeIVA { get; set; }

        public float CalcularTotal()
        {
            return Total = Cantidad * Precio;
        }
        public float SubTotal
        { 
            get
            {
                return Cantidad * Precio;
            } 
        }

        public float ValorIVa 
        { 
            get 
            {
                return SubTotal * (PorcentajeIVA/ 100);

               
            } 
        }



    }
}
