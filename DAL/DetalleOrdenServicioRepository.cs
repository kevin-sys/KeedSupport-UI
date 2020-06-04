using Entity;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleOrdenServicioRepository
    {
        public List<DetalleOrdenServicio> detalles = new List<DetalleOrdenServicio>();
        private readonly SqlConnection _connection;
        public DetalleOrdenServicioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
            detalles = new List<DetalleOrdenServicio>();
        }

        public void Guardar(List<DetalleOrdenServicio> detalles)
        {
            foreach (var detalle in detalles)
            {
                using (var command = _connection.CreateCommand())
                {

                    command.CommandText = "INSERT INTO DetalleOrden (NumeroOrden, Codigo, ServicioProducto, Cantidad, Precio, SubTotal, IVA, Total)VALUES (@NumeroOrden, @Codigo, @ServicioProducto, @Cantidad, @Precio, @SubTotal, @IVA, @Total)";
                    command.Parameters.AddWithValue("@NumeroOrden", detalle.OrdenDeServicio.NumeroOrden);
                    command.Parameters.AddWithValue("@Codigo", detalle.CodigoProducto);
                    command.Parameters.AddWithValue("@ServicioProducto", detalle.Producto);
                    command.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    command.Parameters.AddWithValue("@Precio", detalle.ValorUnitario);
                    command.Parameters.AddWithValue("@SubTotal", detalle.SubTotal);
                    command.Parameters.AddWithValue("@IVA", detalle.IVA);
                    command.Parameters.AddWithValue("@Total", detalle.Total);
                    command.ExecuteNonQuery();

                }
            }
        }
        public void AddDetalle(DetalleOrdenServicio detalle)
        {
            detalle.CalcularSubtotal(detalle.Cantidad);
            detalles.Add(detalle);
        }
        public List<DetalleOrdenServicio> ConsultarDetalle()
        {
            return detalles;
        }
    }
}
