using Datos1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class NArea
    {
        private DArea dArea = new DArea();

        public String Registrar(Area_Operativa_Produccion area)
        {
            return dArea.Registrar(area);
        }

        public String Modificar(Area_Operativa_Produccion area)
        {
           return dArea.Modificar(area);
        }

        public String Eliminar(int Id_Area)
        {
            return dArea.Eliminar(Id_Area);
        }

        public List<Area_Operativa_Produccion> ListarTodo()
        {
            return dArea.ListarTodo();
        }

        public List<Area_Operativa_Produccion> BuscarPorSeccion(String Seccion)
        {
           return dArea.BuscarPorSeccion(Seccion);
        }

    }
}
