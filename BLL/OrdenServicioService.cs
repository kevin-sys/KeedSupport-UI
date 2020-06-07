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
        List<OrdenDeServicio> ordenes;
        public OrdenServicioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new OrdenServicioRepository(conexion);
        }

        public int TotalizarCelular()
        {
            return repositorio.TotalizarCelular();
        }

        public int TotalizarPC()
        {
            return repositorio.TotalizarPC();
        }

        public int TotalizarImpresora()
        {
            return repositorio.TotalizarImpresora();
        }

        public int TotalizarConsola()
        {
            return repositorio.TotalizarConsola();
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

        public List<OrdenDeServicio> Consultar()
        {
            conexion.Open();
            ordenes = new List<OrdenDeServicio>();
            ordenes = repositorio.Consultar();
            conexion.Close();
            return ordenes;
        }
    }
}
