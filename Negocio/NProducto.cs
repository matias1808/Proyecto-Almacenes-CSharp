using Datos1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProducto
    {
        private DProducto dProducto = new DProducto();  

        public string Registrar(Producto producto)
        {
            return dProducto.Registrar(producto);
        }

        public String Modificar(Producto producto)
        {
            return dProducto.Modificar(producto);
        }
        public String Eliminar(int Id_Producto)
        {
            return dProducto.Eliminar(Id_Producto);
        }
        public List<Producto> ListarTodo(int idAlmacen)
        {
           return dProducto.ListarTodo(idAlmacen);
        }
        public List<Producto> ListarTodo2()
        {
             return dProducto.ListarTodo2();
        }

        public List<Producto> BuscarPorTipoProducto(int idAlmacen, String tipo_producto)
        {
           return dProducto.BuscarPorTipoProducto(idAlmacen, tipo_producto);
        }

        public List<Producto> BuscarPorTipoUnidadMedida(int idAlmacen, String unidadMedida)
        {
            return dProducto.BuscarPorTipoUnidadMedida(idAlmacen, unidadMedida);
        }

        public List<Producto> BuscarPorAlmacen(int idAlmacen)
        {
            return dProducto.BuscarPorAlmacen(idAlmacen);
        }

        public Producto BuscarPorId(int idProducto)
        {
            return dProducto.BuscarPorId(idProducto);
        }
    }
}
