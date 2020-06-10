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
        public Equipo equipo = new Equipo();
        public Cliente cliente = new Cliente();
        public List<DetalleOrdenServicio> detalleOrdenServicios { get; set; }
        public float TotalOrden { get; set; }
        public float SubTotal { get; set; }
        public float Abono { get; set; }
        public float Vueltos { get; set; }
        public float Deuda { get; set; }

        public List<Producto> Productos { get; set; }



        public float CalcularVueltos()
        {

            // return (Abono <= TotalOrden) ? 0 : Abono - TotalOrden;
            if (Abono <= TotalOrden)
            {
                return Vueltos = 0;
            }
            else
            {
                return Vueltos = Abono - TotalOrden;
            }

        }

        public float CalcularDeuda()
        {

            //   return (Abono >= TotalOrden) ? 0 : TotalOrden - Abono;
            if (Abono >= TotalOrden)
            {
                return Deuda = 0;
            }
            else
            {
                return Deuda = TotalOrden - Abono;
            }

        }
    }
}
