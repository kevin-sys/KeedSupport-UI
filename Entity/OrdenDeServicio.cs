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
        public float IVA { get; set; }
        public float TotalOrden { get; set; }
        public float SubTotal { get; set; }
        public float Abono { get; set; }



        public List<Producto> Productos{ get; set; }
         
        public string ServicioOProducto { get; set; }
     
        
        //public float SubTotal
        //{
        //    get
        //    {
        //        return Productos.Sum(p => p.SubTotal);
        //    }
        //}

        //public float ValorTotalIVA
        //{
        //    get
        //    {
        //        return Productos.Sum(p => p.ValorIVa);
        //    }
        //}

        //public float TotalOrden
        //{
        //    get
        //    {
                
        //        return  SubTotal + ValorTotalIVA;
                
        //    }
        //}

        public float Vueltos
        {
            get
            {
                return (Abono <= TotalOrden)? 0: Abono- TotalOrden;
                //condicion?T:F;
            }
            set
            {

            }
        }

        public float Deuda
        {
            get
            {
                return (Abono >= TotalOrden) ? 0: TotalOrden - Abono;
            }
            set
            {

            }
        }
    }
}
