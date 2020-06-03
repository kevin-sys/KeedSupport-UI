using System;
using System.Collections.Generic;
using Entity;
using DAL;

namespace BLL
{
    public class BaseDeFallasService
    {
        private readonly ConnectionManager conexion;
        private readonly BaseDeFallasRepository repositorio;
        List<BaseDeFallas> fallas;
        public BaseDeFallasService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new BaseDeFallasRepository(conexion);
        }
        public string Guardar(BaseDeFallas fallas)
        {


            try
            {
                conexion.Open();
                repositorio.Guardar(fallas);
                conexion.Close();
                return $"Se guardaron los datos satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public string Eliminar(string codigo)
        {
            try
            {
                conexion.Open();
                var bbfallas = repositorio.Buscar(codigo);
                if (bbfallas != null)
                {
                    repositorio.Eliminar(codigo);
                    conexion.Close();
                    return ($"El registro {bbfallas.CodigoFalla} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {codigo} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }

   


        public List<BaseDeFallas> Consultar()
        {
            conexion.Open();
            fallas = new List<BaseDeFallas>();
            fallas = repositorio.Consultar();
            conexion.Close();
            return fallas;
        }
        public RespuestaBusquedaBD Buscar(string codigo)
        {
            RespuestaBusquedaBD respuesta = new RespuestaBusquedaBD();
            try
            {

                conexion.Open();
                respuesta.Falla = repositorio.Buscar(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Falla != null) ? "Se encontró la base de falla buscada" : "La base de falla buscada no existe";
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

        public string Modificar(BaseDeFallas bd)
        {
            try
            {
                conexion.Open();
                var bdvieja = repositorio.Buscar(bd.CodigoFalla);
                if (bdvieja != null)
                {
                    repositorio.Modificar(bd);
                    conexion.Close();
                    return ($"El registro {bdvieja.CodigoFalla} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {bdvieja.CodigoFalla} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }



    }

    public class RespuestaBusquedaBD
    {
        public string Mensaje { get; set; }
        public BaseDeFallas Falla { get; set; }
        public bool Error { get; set; }
    }

    public class RespuestaConsultaBD
    {
        public string Mensaje { get; set; }
        public IList<BaseDeFallas> BdFallas { get; set; }
        public bool Error { get; set; }
    }
}
