using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class BaseDeFallasRepository
    {
        private SqlConnection connection;
        private List<BaseDeFallas> baseDeFallas;
        public BaseDeFallasRepository(SqlConnection connectionDb)
        {
            connection = connectionDb;
            baseDeFallas = new List<BaseDeFallas>();
        }

        public void Guardar(BaseDeFallas fallas)
        {
            using (var command=connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO BaseFalla (CodigoFalla, FechaRegistro, TipoEquipo, Marca, Modelo, Falla, Sintomas, Solucion) values (@CodigoFalla, @FechaRegistro, @TipoEquipo, @Marca, @Modelo, @Falla, @Sintomas, @Solucion)";
                command.Parameters.AddWithValue("@CodigoFalla", fallas.CodigoFalla);
                command.Parameters.AddWithValue("@FechaRegistro", fallas.FechaRegistro);
                command.Parameters.AddWithValue("@TipoEquipo", fallas.TipoEquipo);
                command.Parameters.AddWithValue("@Marca", fallas.Marca);
                command.Parameters.AddWithValue("@Modelo", fallas.Modelo);
                command.Parameters.AddWithValue("@Falla", fallas.Falla);
                command.Parameters.AddWithValue("@Sintomas", fallas.Sintomas);
                command.Parameters.AddWithValue("@Solucion", fallas.Solucion);
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(string codigo)
        {
            using(var command=connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM BaseFalla WHERE CodigoFalla=@CodigoFalla";
                command.Parameters.AddWithValue("@CodigoFalla", codigo);
                command.ExecuteNonQuery();
            }
        }

        private BaseDeFallas Mapear(SqlDataReader reader)
        {
            BaseDeFallas fallas = new BaseDeFallas();
            fallas.CodigoFalla = (string)reader["CodigoFalla"];
            fallas.FechaRegistro = (DateTime)reader["FechaRegistro"];
            fallas.TipoEquipo = (string)reader["TipoEquipo"];
            fallas.Marca = (string)reader["Marca"];
            fallas.Modelo = (string)reader["Modelo"];
            fallas.Falla = (string)reader["Falla"];
            fallas.Sintomas = (string)reader["Sintomas"];
            fallas.Solucion = (string)reader["Solucion"];
            return fallas;
        }

        public BaseDeFallas Buscar(string codigo)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM BaseFalla WHERE CodigoFalla = @CodigoFalla";
                command.Parameters.AddWithValue("@CodigoFalla", codigo);
                var reader = command.ExecuteReader();
                if (reader.HasRows==true)
                {
                    while (reader.Read())
                    {
                        return Mapear(reader);
                    }
                }
            }
            return null;
        }

        public List<BaseDeFallas> Consultar()
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM BaseFalla";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    BaseDeFallas fallas = new BaseDeFallas();
                    fallas = Mapear(Reader);
                    baseDeFallas.Add(fallas);
                }
            }
            return baseDeFallas;
        }

        public void Modificar(BaseDeFallas fallas)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE BaseFalla SET FechaRegistro = @FechaRegistro, TipoEquipo = @TipoEquipo, Marca = @Marca, Modelo = @Modelo, Falla = @Falla, Sintomas = @Sintomas, Solucion = @Solucion WHERE CodigoFalla = @CodigoFalla";
                command.Parameters.AddWithValue("@CodigoFalla", fallas.CodigoFalla);
                command.Parameters.AddWithValue("@FechaRegistro", fallas.FechaRegistro);
                command.Parameters.AddWithValue("@TipoEquipo", fallas.TipoEquipo);
                command.Parameters.AddWithValue("@Marca", fallas.Marca);
                command.Parameters.AddWithValue("@Modelo", fallas.Modelo);
                command.Parameters.AddWithValue("@Falla", fallas.Falla);
                command.Parameters.AddWithValue("@Sintomas", fallas.Sintomas);
                command.Parameters.AddWithValue("@Solucion", fallas.Solucion);
                command.ExecuteNonQuery();

            }
        }
    }
}
