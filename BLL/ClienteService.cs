using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                conexion.Open();
                repositorio.Guardar(cliente);
                conexion.Close();
                return $"Se guardaron los datos satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var cliente = repositorio.Buscar(identificacion);
                if (cliente != null)
                {
                    repositorio.Eliminar(cliente);
                    conexion.Close();
                    return ($"El registro {cliente.PrimerNombre} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {

                conexion.Open();
                respuesta.clientes = repositorio.Consultar();
                conexion.Close();
                if (respuesta.clientes.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay datos para consultar";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }

        public RespuestaBusqueda Buscar(string identificacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {

                conexion.Open();
                respuesta.Cliente = repositorio.Buscar(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Cliente != null) ? "Se encontró la Persona buscada" : "La persona buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }

        public string Modificar(Cliente nuevocliente)
        {
            try
            {
                conexion.Open();
                var clienteviejo = repositorio.Buscar(nuevocliente.Identificacion);
                if (clienteviejo != null)
                {
                    repositorio.Modificar(nuevocliente);
                    conexion.Close();
                    return ($"El registro {nuevocliente.Identificacion} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {nuevocliente.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
    }

    public class RespuestaBusqueda
    {
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
        public bool Error { get; set; }
    }

    public class RespuestaConsulta
    {
        public string Mensaje { get; set; }
        public IList<Cliente> clientes { get; set; }
        public bool Error { get; set; }
    }
}
