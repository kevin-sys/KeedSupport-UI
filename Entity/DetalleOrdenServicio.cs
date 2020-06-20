using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleOrdenServicio
    {

        
        public string DescripcionProducto { get; set; }
        public string CodigoDetalle { get; set; }
        public Producto Producto { get; set; }
        public OrdenDeServicio OrdenDeServicio { get; set; }
        public string CodigoProducto { get; set; }
        public float Cantidad { get; set; }
        public float SubTotal { get; set; }
        public float ValorUnitario { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }
        public float TotalIva { get; set; }

        public override string ToString()
        {
            return $"{CodigoDetalle};{OrdenDeServicio.NumeroOrden};{Producto.CodigoProducto};{Producto.NombreProducto};{Cantidad};{ValorUnitario};{SubTotal};{Producto.PorcentajeIVA};{Total}";
        }

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
