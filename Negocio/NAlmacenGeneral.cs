using Datos1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlmacenGeneral
    {
        private DAlmacenGeneral dAlmacenGeneral = new DAlmacenGeneral();
        public String Registrar(Almacen_General almacen_general)
        {
           return dAlmacenGeneral.Registrar(almacen_general);
        }

        public String Modificar(Almacen_General almacen_general)
        {
            return dAlmacenGeneral.Modificar(almacen_general);
        }

        public String Eliminar(int Id_AlmacenGeneral)
        {
            return dAlmacenGeneral.Eliminar(Id_AlmacenGeneral);
        }

        public List<Almacen_General> ListarTodo()
        {
            return dAlmacenGeneral.ListarTodo();
        }
        public List<Almacen_General> BuscarPorNombre(String nombre)
        {
            return dAlmacenGeneral.BuscarPorNombre(nombre);
        }
    }
}
