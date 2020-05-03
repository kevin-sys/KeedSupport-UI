using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrdenDeServicio
    {
        public string NumeroOrden { get; set; }
        public DateTime FechaOrden { get; set; }


        public string NombreCliente { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }


        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Color { get; set; }
        public string Accesorios { get; set; }
        public string Falla { get; set; }
        public string EstadoEquipo { get; set; }
        public string ServicioOProducto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float IVA { get; set; }
        public float Abono { get; set; }
        public float Vueltos { get; set; }
        public float Deuda { get; set; }



        public float CalcularSubTotal
        {
            get
            {
                float subTotal = 0;
                subTotal = Cantidad * Precio;
                return subTotal;
            }
        }

        public float CalcularIVA
        {
            get
            {
                float iva = 0;
                iva = (CalcularSubTotal * IVA)/100;

                return iva;
            }
        }

        public float CalcularTotalServicios
        {
            get
            {
                float total = 0;
                total = CalcularSubTotal + CalcularIVA;
                return total;
            }
        }

        public float CalcularVueltos
        {
            get
            {
                if (Abono>=CalcularTotalServicios)
                {
                    Vueltos = Abono - CalcularTotalServicios;
                    
                }
                else if (Abono<CalcularTotalServicios)
                {
                    Vueltos = 0;
                  
                }
                return Vueltos;
            }
        }

        public float CalcularDeuda
        {
            get
            {
                if (Abono>=CalcularTotalServicios)
                {
                    Deuda = 0;
                }
                else if (Abono<CalcularTotalServicios)
                {
                    Deuda = CalcularTotalServicios - Abono;
                }
                return Deuda;
            }
        }
    }
}
