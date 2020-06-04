using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class OrdenServicioService
    {
        private readonly ConnectionManager conexion;
        private readonly OrdenServicioRepository repositorio;

        public OrdenServicioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new OrdenServicioRepository(conexion);
        }

        public string Guardar(OrdenDeServicio servicio)
        {
            try
            {
                conexion.Open();
                repositorio.Guardar(servicio);
                conexion.Close();
                return $"Se guardaron los datos satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
    }
}
