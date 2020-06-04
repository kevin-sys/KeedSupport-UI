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
        private readonly ProductoRepository repositorio;
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
            try
            {
                conexion.Open();
                Producto productos = new Producto();

                productos = repositorio.Buscar(codigo);
                return productos;
            }
            catch (Exception)
            {


            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

    }
}
