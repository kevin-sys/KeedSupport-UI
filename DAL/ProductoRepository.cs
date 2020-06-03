using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductoRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<Producto> productos = new List<Producto>();
        public ProductoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Producto (Codigo, Descripcion, NombreProducto, Precio) values (@Codigo, @Descripcion, @NombreProducto, @Precio)";
                command.Parameters.AddWithValue("@Codigo", producto.CodigoProducto);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.ExecuteNonQuery();

            }

        }
    }
}
