using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class OrdenServicioRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<OrdenDeServicio> ordenes = new List<OrdenDeServicio>();
       
        public OrdenServicioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
           
        }
        public void Guardar(OrdenDeServicio orden)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO OrdenServicio (NumeroOrden, FechaOrden, TipoEquipo, Marca, Modelo, NumeroSerie, Color, FallaReportada, EstadoEquipo, Accesorios, NombreCliente, Identificacion, Telefono, Direccion, Correo, SubTotal, Total, Abono, Vueltos, Deuda) values (@NumeroOrden, @FechaOrden, @TipoEquipo, @Marca, @Modelo, @NumeroSerie, @Color, @FallaReportada, @EstadoEquipo, @Accesorios, @NombreCliente, @Identificacion, @Telefono, @Direccion, @Correo, @SubTotal, @Total, @Abono, @Vueltos, @Deuda)";
                command.Parameters.AddWithValue("@NumeroOrden", orden.NumeroOrden);
                command.Parameters.AddWithValue("@FechaOrden", orden.FechaOrden);
                command.Parameters.AddWithValue("@TipoEquipo", orden.equipo.Tipo);
                command.Parameters.AddWithValue("@Marca", orden.equipo.Marca);
                command.Parameters.AddWithValue("@Modelo", orden.equipo.Modelo);
                command.Parameters.AddWithValue("@NumeroSerie", orden.equipo.NumeroSerie);
                command.Parameters.AddWithValue("@Color", orden.equipo.Color);
                command.Parameters.AddWithValue("@FallaReportada", orden.equipo.FallaReportada);
                command.Parameters.AddWithValue("@EstadoEquipo", orden.equipo.EstadoEquipo);
                command.Parameters.AddWithValue("@Accesorios", orden.equipo.Accesorios);
                command.Parameters.AddWithValue("@NombreCliente", orden.cliente.PrimerNombre);
                command.Parameters.AddWithValue("@Identificacion", orden.cliente.Identificacion);
                command.Parameters.AddWithValue("@Telefono", orden.cliente.Telefono);
                command.Parameters.AddWithValue("@Direccion", orden.cliente.Direccion);
                command.Parameters.AddWithValue("@Correo", orden.cliente.Correo);
                command.Parameters.AddWithValue("@SubTotal", orden.SubTotal);
                command.Parameters.AddWithValue("@Total", orden.TotalOrden);
                command.Parameters.AddWithValue("@Abono", orden.Abono);
                command.Parameters.AddWithValue("@Vueltos", orden.Vueltos);
                command.Parameters.AddWithValue("@Deuda", orden.Deuda);
                command.ExecuteNonQuery();

            }

        }

        private OrdenDeServicio Mapear(SqlDataReader reader)
        {
            OrdenDeServicio servicio = new OrdenDeServicio();
            servicio.NumeroOrden = (string)reader["NumeroOrden"];
            servicio.FechaOrden = (DateTime)reader["FechaOrden"];
            servicio.equipo.Tipo = (string)reader["TipoEquipo"];
            servicio.equipo.Marca = (string)reader["Marca"];
            servicio.equipo.Modelo = (string)reader["Modelo"];
            servicio.equipo.NumeroSerie = (string)reader["NumeroSerie"];
            servicio.equipo.Color = (string)reader["Color"];
            servicio.equipo.FallaReportada = (string)reader["FallaReportada"];
            servicio.equipo.EstadoEquipo = (string)reader["EstadoEquipo"];
            servicio.equipo.Accesorios = (string)reader["Accesorios"];
            servicio.cliente.PrimerNombre = (string)reader["NombreCliente"];
            servicio.cliente.Identificacion = (string)reader["Identificacion"];
            servicio.cliente.Telefono = (string)reader["Telefono"];
            servicio.cliente.Direccion = (string)reader["Direccion"];
            servicio.cliente.Correo = (string)reader["Correo"];
            servicio.SubTotal = float.Parse(reader["Total"].ToString());
            servicio.TotalOrden = float.Parse(reader["Total"].ToString());
            servicio.Abono = float.Parse(reader["Abono"].ToString());
            servicio.Vueltos = float.Parse(reader["Vueltos"].ToString());
            servicio.Deuda = float.Parse(reader["Deuda"].ToString());

            return servicio;


        }

        public int TotalizarCelular()
        {
            return ordenes.Where(p => p.equipo.Tipo.Equals("Celular")).Count();
        }
       

        public int TotalizarPC()
        {
            return ordenes.Where(p => p.equipo.Tipo.Equals("PC")).Count();
        }
        public int TotalizarImpresora()
        {
            return ordenes.Where(p => p.equipo.Tipo.Equals("Impresora")).Count();
        }

        public int TotalizarConsola()
        {
            return ordenes.Where(p => p.equipo.Tipo.Equals("Consola de videojuego")).Count();
        }

        public List<OrdenDeServicio> Consultar()
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM OrdenServicio";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    OrdenDeServicio ordenservicio = new OrdenDeServicio();
                    ordenservicio = Mapear(Reader);
                    ordenes.Add(ordenservicio);
                }
            }
            return ordenes;
        }

    }
}
