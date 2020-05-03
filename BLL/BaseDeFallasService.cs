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
    public class BaseDeFallasService
    {
        SqlConnection connection;
        string CadenaCnexion = @"Data Source=DESKTOP-NVQ1I8P;Initial Catalog=KeedSupport;Integrated Security=True";
        BaseDeFallasRepository fallasRepository;
        List<BaseDeFallas> fallas;
        public BaseDeFallasService()
        {
            connection = new SqlConnection(CadenaCnexion);
            fallasRepository = new BaseDeFallasRepository(connection);
        }
        public string Guardar(BaseDeFallas BdFallas)
        {
            try
            {
                connection.Open();
                fallasRepository.Guardar(BdFallas);
                return "Se guardo correctamente la base de falla";
            }
            catch (Exception e)
            {

                return "error de datos: " + e.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        public string Eliminar(string codigo)
        {
            try
            {
                connection.Open();
                fallasRepository.Eliminar(codigo);
                return "SE ELIMINO CORRECTAMENTE";
            }
            catch (Exception e)
            {
                return " ERROR EN LOS DATOS: " + e.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<BaseDeFallas>Consultar()
        {
            connection.Open();
            fallas = new List<BaseDeFallas>();
            fallas = fallasRepository.Consultar();
            connection.Close();
            return fallas;
        }

        public BaseDeFallas Buscar(string codigo)
        {
            try
            {
                connection.Open();
                return fallasRepository.Buscar(codigo);
            }
            catch (Exception e)
            {

                string mensaje = "ERROR EN LA BASE DE DATOS" + e.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public BaseDeFallas Modificar(BaseDeFallas BdFallas)
        {
            try
            {
                connection.Open();
                fallasRepository.Modificar(BdFallas);
                return BdFallas;
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
