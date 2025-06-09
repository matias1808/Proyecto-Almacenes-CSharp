using Datos1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NArea_Producto
    {
        private DArea_Producto dArea_Producto = new DArea_Producto();
        public String Asignar(Area_Producto area_Producto)
        {
            return dArea_Producto.Asignar(area_Producto);
        }

        public String Eliminar(int numeroDocumento)
        {
            return dArea_Producto.Eliminar(numeroDocumento);
        }

        public List<Area_Producto> ListarTodo()
        {
            return dArea_Producto.ListarTodo();
        }

        public List<Area_Producto> BuscarPorIdArea(int id_Area)
        {
           return dArea_Producto.BuscarPorIdArea(id_Area);
        }

        public List<Area_Producto> BuscarPorIdProducto(int id_Producto)
        {
            return dArea_Producto.BuscarPorIdProducto(id_Producto);
        }
    }
}
