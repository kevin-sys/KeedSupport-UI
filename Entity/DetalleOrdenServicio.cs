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
        public Producto Producto = new Producto();
        public OrdenDeServicio OrdenDeServicio = new OrdenDeServicio();
        public string CodigoProducto { get; set; }
        public float Cantidad { get; set; }
        public float SubTotal { get; set; }
        public float ValorUnitario { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }

        public float ganancia { get; set; }

        public float CalcularSubtotal(float Cantidad)
        {
            SubTotal = Cantidad * ValorUnitario;
            return SubTotal;

        }

        public float Calculartotal(float SubTotal)
        {
            Total = SubTotal * IVA;
            return Total;

        }

        public float Iva
        {
            get
            {
                float PrecioVenta = 0;
                PrecioVenta = (ValorUnitario * ganancia) / 100 + ValorUnitario;
                return PrecioVenta;
            }
        }

    }
}
