﻿using System;
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
        private readonly ConnectionManager conexion;
        public List<DetalleOrdenServicio> detalleorden;
        private readonly DetalleOrdenServicioRepository repository;
        private static DetalleOrdenServicioRepository repo = new DetalleOrdenServicioRepository();

        public DetalleOrdenServicioService()
        {
            repo = new DetalleOrdenServicioRepository();
        }

        public DetalleOrdenServicioService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repository = new DetalleOrdenServicioRepository(conexion);
        }


        public string GuardarArchivo(DetalleOrdenServicio detalle)
        {
            try
            {

                repo.GuardarArchivo(detalle);
                return "El producto ha sido añadido al carrito con exito!";

            }
            catch (Exception e)
            {

                return "Error de Datos: " + e.Message;
            }
        }
        public void EliminarTxt()
        {
            repo.EliminarTxt();
        }

        public string GuardarDetalleBD()
        {
            try
            {
                conexion.Open();
                repository.GuardarArchivoPlano();
                conexion.Close();
                return $"Detalles de compra guardados con exito en la BD";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


        public string GuardarArchivoPlano()
        {
            try
            {
                conexion.Open();
                repository.GuardarArchivoPlano();
                conexion.Close();
                return $"El producto se añadio al carrito de compra";


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
                    return ($"El producto {detalle.Producto.NombreProducto} ha sido sacado de la orden.");
                }
                else
                {
                    return ($"Lo sentimos, {codigoDetalle} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }

        public string EliminarTodoDetalle(string numeroOrden)
        {
            try
            {
                conexion.Open();
                var detalle = repository.BuscarTodoDetalle(numeroOrden);
                if (detalle != null)
                {
                    repository.EliminarTodoDetalle(detalle);
                    conexion.Close();
                    return ($"Todos los productos añadidos al carrito fueron eliminados.");
                }
                else
                {
                    return ($"Hasta luego :)");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }

        public string Modificar(DetalleOrdenServicio detalleorden)
        {
            try
            {
                conexion.Open();
                var detalleviejo = repository.Buscar(detalleorden.CodigoDetalle);
                if (detalleviejo != null)
                {
                    repository.Modificar(detalleorden);
                    conexion.Close();
                    return ($"El producto {detalleorden.Producto.NombreProducto} se ha actualizado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {detalleorden.CodigoDetalle} no se encuentro el producto.");
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
