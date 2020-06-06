using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ProductoService
    {
        private readonly ConnectionManager conexion;
        ProductoRepository repositorio;
        List<Producto> productos;

        public ProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProductoRepository(conexion);
        }

        public string Guardar(Producto producto)
        {
            try
            {
                conexion.Open();
                repositorio.Guardar(producto);
                conexion.Close();
                return $"Se guardo la orden de servicio con exito";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public List<Producto> Consultar()
        {
            conexion.Open();
            productos = new List<Producto>();
            productos = repositorio.Consultar();
            conexion.Close();
            return productos;
        }

        public Producto Buscar(string codigo)
        {
            Producto producto = new Producto();

            try
            {
                conexion.Open();

              return repositorio.Buscar(codigo);
                //return producto;
            }
            catch (Exception e)
            {

                string mensaje = " ERROR EN LA BASE DE DATOS " + e.Message;
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
