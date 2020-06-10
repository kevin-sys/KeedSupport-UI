using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleOrdenServicio
    {
        public DetalleOrdenServicio()
        {
           
        }
        public string DescripcionProducto { get; set; }
        public string CodigoDetalle { get; set; }
        public Producto Producto = new Producto();
        public OrdenDeServicio OrdenDeServicio = new OrdenDeServicio();
        public string CodigoProducto { get; set; }
        public float Cantidad { get; set; }
        public float SubTotal { get; set; }
        public float ValorUnitario { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }
        public float TotalIva { get; set; }

        public float CalcularSubtotal()
        {
          return   SubTotal = Cantidad * ValorUnitario;
        }


        public float Calculartotal()
        {
            
          return  Total = (CalcularSubtotal() * Producto.PorcentajeIVA/100)+ CalcularSubtotal();
        }

        private float CalcularIva()
        {
         return   TotalIva = (SubTotal * IVA);
        }


    }
}
