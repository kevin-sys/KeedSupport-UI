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
                command.CommandText = "INSERT INTO Producto (Codigo, Descripcion, NombreProducto, Precio, Cantidad, Total, FechaRegistro, IVA, SubTotal) values (@Codigo, @Descripcion, @NombreProducto, @Precio, @Cantidad, @Total, @FechaRegistro, @IVA, @SubTotal)";
                command.Parameters.AddWithValue("@Codigo", producto.CodigoProducto);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Total", producto.Total);
                command.Parameters.AddWithValue("@FechaRegistro", producto.FechaRegistro);
                command.Parameters.AddWithValue("@IVA", producto.PorcentajeIVA);
                command.Parameters.AddWithValue("@SubTotal", producto.SubTotal);

                command.ExecuteNonQuery();

            }

        }

        private Producto Mapear(SqlDataReader reader)
        {
            Producto producto = new Producto();
            producto.CodigoProducto = (string)reader["Codigo"];
            producto.Descripcion = (string)reader["Descripcion"];
            producto.NombreProducto = (string)reader["NombreProducto"];
            producto.Precio = float.Parse(reader["Precio"].ToString());
            producto.Cantidad = int.Parse(reader["Cantidad"].ToString());
            producto.Total = float.Parse(reader["Total"].ToString());
            producto.FechaRegistro = (DateTime)reader["FechaRegistro"];
            producto.PorcentajeIVA = float.Parse(reader["IVA"].ToString());
            return producto;
        }

        public Producto Buscar(string codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Producto WHERE Codigo =@Codigo";
                command.Parameters.AddWithValue("@Codigo", codigo);
                var reader = command.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto = Mapear(reader);
                        return producto;
                    }
                }
            }
            return null;
        }

        public List<Producto> Consultar()
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Producto";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Producto producto  = new Producto();
                    producto = Mapear(Reader);
                    productos.Add(producto);
                }
            }
            return productos;
        }

    }
}
