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

        public string Guardar(DetalleOrdenServicio detalles)
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

        public string Eliminar(string codigoDetalle)
        {
            try
            {
                conexion.Open();
                var detalle = repository.Buscar(codigoDetalle);
                if (detalle != null)
                {
                    repository.Eliminar(detalle);
                    conexion.Close();
                    return ($"El registro {detalle.Producto.NombreProducto} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {codigoDetalle} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }



    }
}
