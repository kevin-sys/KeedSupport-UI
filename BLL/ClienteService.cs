using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class ClienteService
    {
        SqlConnection connection;
        string CadenaCnexion = @"Data Source=DESKTOP-NVQ1I8P;Initial Catalog=KeedSupport;Integrated Security=True";
        ClienteRepository clienteRepository;
        List<Cliente> clientes;
        public ClienteService()
        {
            connection = new SqlConnection(CadenaCnexion);
            clienteRepository = new ClienteRepository(connection);
        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                connection.Open();
                clienteRepository.Guardar(cliente);
                return "se guardo la persona correctamente";
            }
            catch (Exception ex)
            {

                return "error de datos: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                connection.Open();
                clienteRepository.Eliminar(identificacion);
                return "SE ELIMINO CORRECTAMENTE";

            }
            catch (Exception ex)
            {

                return " ERROR EN LOS DATOS: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }

        }

        public List<Cliente> Consultar()
        {
            connection.Open();
            clientes = new List<Cliente>();
            clientes = clienteRepository.Consultar();
            connection.Close();
            return clientes;
        }

        public Cliente BuscarID(string identificacion)
        {
            Cliente cliente = new Cliente();
            try
            {
                connection.Open();
                return clienteRepository.Buscar(identificacion);
            }
            catch (Exception e)
            {

                string mensaje = " ERROR EN LA BASE DE DATOS " + e.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public Cliente Modificar(Cliente cliente)
        {
            try
            {
                connection.Open();
                clienteRepository.Modificar(cliente);
                return cliente;
            }
            catch (Exception e)
            {

                string mensaje = " ERROR DE DATOS: " + e.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
