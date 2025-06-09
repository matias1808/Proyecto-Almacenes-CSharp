using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1
{
    public class DProducto
    {
        public string Registrar(Producto producto)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Producto.Add(producto);
                    context.SaveChanges();
                }
                return "Registrado Correctamente";
            }
            catch (Exception ex)
            {
                Exception inner = ex;
                while (inner.InnerException != null)
                {
                    inner = inner.InnerException;
                }
                return "Error al registrar producto: " + inner.Message + "\n\n" + inner.ToString();
            }
        }

        public String Modificar(Producto producto)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Producto productoTemp = context.Producto.Find(producto.Codigo);
                    productoTemp.Nombre = producto.Nombre;
                    productoTemp.Descripcion = producto.Descripcion;
                    productoTemp.Costo = producto.Costo;
                    productoTemp.Stock = producto.Stock;
                    productoTemp.Unidad_Medida = producto.Unidad_Medida;
                    productoTemp.Tipo_Producto = producto.Tipo_Producto;
                    productoTemp.Id_Almacen = producto.Id_Almacen;
                    context.SaveChanges();
                }
                return "Modificado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Eliminar(int Id_Producto)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Producto productoTemp = context.Producto.Find(Id_Producto);
                    context.Producto.Remove(productoTemp);
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Producto> ListarTodo(int idAlmacen)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(a => a.Id_Almacen == idAlmacen).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }
        public List<Producto> ListarTodo2()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public List<Producto> BuscarPorTipoProducto(int idAlmacen, String tipo_producto)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(a => a.Id_Almacen == idAlmacen && a.Tipo_Producto == tipo_producto).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public List<Producto> BuscarPorTipoUnidadMedida(int idAlmacen, String unidadMedida)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(a => a.Id_Almacen == idAlmacen && a.Unidad_Medida == unidadMedida).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public List<Producto> BuscarPorAlmacen(int idAlmacen)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(a => a.Id_Almacen == idAlmacen).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }
        public Producto BuscarPorId(int idProducto)
        {
            using (var context = new db_proyecto_3Entities())
            {
                return context.Producto.Find(idProducto);
            }
        }       

    }
}
