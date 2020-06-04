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
        public OrdenServicioRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(OrdenDeServicio orden)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO OrdenServicio (NumeroOrden, FechaOrden, TipoEquipo, Marca, Modelo, NumeroSerie, Color, FallaReportada, EstadoEquipo, Accesorios, NombreCliente, Identificacion, Telefono, Direccion, Correo, SubTotal, IVA, Total, Abono, Vueltos, Deuda) values (@NumeroOrden, @FechaOrden, @TipoEquipo, @Marca, @Modelo, @NumeroSerie, @Color, @FallaReportada, @EstadoEquipo, @Accesorios, @NombreCliente, @Identificacion, @Telefono, @Direccion, @Correo, @SubTotal, @IVA, @Total, @Abono, @Vueltos, @Deuda)";
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
                command.Parameters.AddWithValue("@IVA", orden.IVA);
                command.Parameters.AddWithValue("@Total", orden.TotalOrden);
                command.Parameters.AddWithValue("@Abono", orden.Abono);
                command.Parameters.AddWithValue("@Vueltos", orden.Vueltos);
                command.Parameters.AddWithValue("@Deuda", orden.Deuda);
                command.ExecuteNonQuery();

            }

        }
    }
}
