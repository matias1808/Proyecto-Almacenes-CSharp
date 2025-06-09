using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1
{
    public  class DArea_Producto
    {
        public String Asignar(Area_Producto area_Producto)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Area_Producto.Add(area_Producto);
                    context.SaveChanges();
                }
                return "Asignado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int numeroDocumento)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Area_Producto area_Producto = context.Area_Producto.Find(numeroDocumento);
                    context.Area_Producto.Remove(area_Producto);
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Area_Producto> ListarTodo()
        {
            List<Area_Producto> area_Producto = new List<Area_Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    area_Producto = context.Area_Producto.ToList();
                }
                return area_Producto;
            }
            catch (Exception ex)
            {
                return area_Producto;
            }
        }

        public List<Area_Producto> BuscarPorIdArea(int id_Area)
        {
            List<Area_Producto> area_Producto = new List<Area_Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    area_Producto = context.Area_Producto.Where(ad => ad.Id_Area.Equals(id_Area)).ToList();
                }
                return area_Producto;
            }
            catch (Exception ex)
            {
                return area_Producto;
            }
        }

        public List<Area_Producto> BuscarPorIdProducto(int id_Producto)
        {
            List<Area_Producto> area_Productos = new List<Area_Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    area_Productos = context.Area_Producto.Where(ad => ad.Codigo.Equals(id_Producto)).ToList();
                }
                return area_Productos;
            }
            catch (Exception ex)
            {
                return area_Productos;
            }
        }        
    }
}
