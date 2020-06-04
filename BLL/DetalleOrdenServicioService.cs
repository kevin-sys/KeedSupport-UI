using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class DetalleOrdenServicioService
    {
        public List<DetalleOrdenServicio> detalleorden;
        public DetalleOrdenServicioRepository repository;
        private readonly ConnectionManager conexion;

        public DetalleOrdenServicioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repository = new DetalleOrdenServicioRepository(conexion);
        }

        public string Guardar(List<DetalleOrdenServicio> detalles)
        {
            try
            {
                conexion.Open();
                repository.Guardar(detalles);
                conexion.Close();
                return $"Se guardaron los datos satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public void AddDetalle(DetalleOrdenServicio detalle)
        {
            repository.AddDetalle(detalle);
        }
        public List<DetalleOrdenServicio> ConsultarDetalle()
        {
            return repository.ConsultarDetalle();
        }
    }
}
