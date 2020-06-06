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

        public void Guardar(DetalleOrdenServicio detalles)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO DetalleOrden (CodigoDetalle, NumeroOrden, Codigo, ServicioProducto, Cantidad, Precio, SubTotal, IVA, Total)VALUES (@CodigoDetalle, @NumeroOrden, @Codigo, @ServicioProducto, @Cantidad, @Precio, @SubTotal, @IVA, @Total)";
                command.Parameters.AddWithValue("@CodigoDetalle", detalles.CodigoDetalle);
                command.Parameters.AddWithValue("@NumeroOrden", detalles.OrdenDeServicio.NumeroOrden);
                command.Parameters.AddWithValue("@Codigo", detalles.Producto.CodigoProducto);
                command.Parameters.AddWithValue("@ServicioProducto", detalles.Producto.NombreProducto);
                command.Parameters.AddWithValue("@Cantidad", detalles.Producto.Cantidad);
                command.Parameters.AddWithValue("@Precio", detalles.Producto.Precio);
                command.Parameters.AddWithValue("@SubTotal", detalles.Producto.SubTotal);
                command.Parameters.AddWithValue("@IVA", detalles.Producto.PorcentajeIVA);
                command.Parameters.AddWithValue("@Total", detalles.Producto.Total);
                command.ExecuteNonQuery();
            }
        }
        private DetalleOrdenServicio Mapear(SqlDataReader reader)
        {
            if (!reader.HasRows) return null;
            DetalleOrdenServicio detalle = new DetalleOrdenServicio();
            detalle.CodigoDetalle = (string)reader["CodigoDetalle"];
            detalle.OrdenDeServicio.NumeroOrden = (string)reader["NumeroOrden"];
            detalle.Producto.CodigoProducto = (string)reader["Codigo"];
            detalle.Producto.NombreProducto = (string)reader["ServicioProducto"];
            // detalle.Producto.Cantidad = (float)reader["Cantidad"];
            //  detalle.Producto.Precio = (float)reader["Precio"];
            // detalle.Producto.SubTotal = (float)reader["SubTotal"];
            //   detalle.Producto.PorcentajeIVA = (float)reader["IVA"];
            //  detalle.Producto.Total = (float)reader["Total"];
            detalle.Producto.Cantidad = float.Parse(reader["Cantidad"].ToString());
            detalle.Producto.Precio = float.Parse(reader["Precio"].ToString());
            detalle.Producto.SubTotal = float.Parse(reader["SubTotal"].ToString());
            detalle.Producto.PorcentajeIVA = float.Parse(reader["IVA"].ToString());
            detalle.Producto.Total = float.Parse(reader["Total"].ToString());


            return detalle;
        }

        public void Eliminar(DetalleOrdenServicio detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "delete from DetalleOrden where CodigoDetalle=@CodigoDetalle";
                command.Parameters.AddWithValue("@CodigoDetalle", detalle.CodigoDetalle);
                command.ExecuteNonQuery();
            }
        }
        public DetalleOrdenServicio Buscar(string codigodetalle)
        {
            SqlDataReader reader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM DetalleOrden WHERE CodigoDetalle = @CodigoDetalle ";
                command.Parameters.AddWithValue("@CodigoDetalle", codigodetalle);
                reader = command.ExecuteReader();
                reader.Read();
                return Mapear(reader);

            }

        }
        public List<DetalleOrdenServicio> Consultar()
        {
            SqlDataReader reader;
            List<DetalleOrdenServicio> detalles = new List<DetalleOrdenServicio>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from DetalleOrden";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DetalleOrdenServicio detalle = Mapear(reader);
                        detalles.Add(detalle);
                    }
                }
            }
            return detalles;
        }
        public void Modificar(DetalleOrdenServicio detalle)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "UPDATE DetalleOrden SET NumeroOrden = @NumeroOrden, Codigo = @Codigo, ServicioProducto = @ServicioProducto, Cantidad = @Cantidad, Precio = @Precio, SubTotal = @SubTotal, IVA = @IVA, Total = @Total WHERE CodigoDetalle = @CodigoDetalle";
                command.Parameters.AddWithValue("@CodigoDetalle", detalle.CodigoDetalle);
                command.Parameters.AddWithValue("@NumeroOrden", detalle.OrdenDeServicio.NumeroOrden);
                command.Parameters.AddWithValue("@Codigo", detalle.Producto.CodigoProducto);
                command.Parameters.AddWithValue("@ServicioProducto", detalle.Producto.NombreProducto);
                command.Parameters.AddWithValue("@Cantidad", detalle.Producto.Cantidad);
                command.Parameters.AddWithValue("@Precio", detalle.Producto.Precio);
                command.Parameters.AddWithValue("@SubTotal", detalle.Producto.SubTotal);
                command.Parameters.AddWithValue("@IVA", detalle.Producto.PorcentajeIVA);
                command.Parameters.AddWithValue("@Total", detalle.Producto.Total);
                command.ExecuteNonQuery();
            }
        }
    }
}

