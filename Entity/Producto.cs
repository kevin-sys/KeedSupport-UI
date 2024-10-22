﻿using System;
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
        public float SubTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public float PorcentajeIVA { get; set; }
        public float CalcularSubTotal()
        {
            return SubTotal = Cantidad * Precio;
        }
        public float CalcularTotal()
        {
            return Total = ((CalcularSubTotal()*PorcentajeIVA)/100)+CalcularSubTotal();
        }
    }

}
