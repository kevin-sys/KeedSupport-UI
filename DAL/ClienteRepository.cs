using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;


namespace DAL
{
    public class ClienteRepository
    {

        private readonly SqlConnection _connection;
        private readonly List<Cliente> _clientes = new List<Cliente>();
        public ClienteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Cliente cliente)
        {
            using (var command=_connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Cliente (Identificacion, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Telefono, FechaNacimiento, Direccion, Ciudad, FechaRegistro, Correo) values (@Identificacion, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Telefono, @FechaNacimiento, @Direccion, @Ciudad, @FechaRegistro, @Correo)";
                command.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                command.Parameters.AddWithValue("@PrimerNombre", cliente.PrimerNombre);
                command.Parameters.AddWithValue("@SegundoNombre", cliente.SegundoNombre);
                command.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                command.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                command.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                command.ExecuteNonQuery();

            }
        }

        public void Eliminar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "delete from Cliente where Idenficacion=@Identificacion";
                command.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                command.ExecuteNonQuery();
            }
        }

        private Cliente Mapear(SqlDataReader reader)
        {
            if (!reader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.Identificacion = (string)reader["Identificacion"];
            cliente.PrimerNombre = (string)reader["PrimerNombre"];
            cliente.SegundoNombre = (string)reader["SegundoNombre"];
            cliente.PrimerApellido = (string)reader["PrimerApellido"];
            cliente.SegundoApellido = (string)reader["SegundoApellido"];
            cliente.Telefono = (string)reader["Telefono"];
            cliente.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
            cliente.Direccion = (string)reader["Direccion"];
            cliente.Ciudad = (string)reader["Ciudad"];
            cliente.FechaRegistro = (DateTime)reader["FechaRegistro"];
            cliente.Correo = (string)reader["Correo"];
            return cliente;
        }

        public Cliente Buscar(string identificacion)
        {
            SqlDataReader reader;

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Cliente WHERE Identificacion = @Identificacion ";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                 reader = command.ExecuteReader();
                reader.Read();
                return Mapear(reader);

            }
        }

        public List<Cliente> Consultar()
        {
            SqlDataReader reader;
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Cliente";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = Mapear(reader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        public void Modificar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "UPDATE Cliente SET PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Telefono = @Telefono, FechaNacimiento = @FechaNacimiento, Direccion = @Direccion, Ciudad = @Ciudad, FechaRegistro = @FechaRegistro, Correo = @Correo WHERE Identificacion = @Identificacion"; 
                command.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                command.Parameters.AddWithValue("@PrimerNombre", cliente.PrimerNombre);
                command.Parameters.AddWithValue("@SegundoNombre", cliente.SegundoNombre);
                command.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                command.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                command.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                command.ExecuteNonQuery();

            }
        }
    }
}
