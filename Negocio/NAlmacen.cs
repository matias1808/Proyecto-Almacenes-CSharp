using Datos1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlmacen
    {
        private DAlmacen dAlmacen = new DAlmacen();
        public string Registrar(Almacen almacen)
        {
           return dAlmacen.Registrar(almacen);
        }
        public String Modificar(Almacen almacen)
        {
            return dAlmacen.Modificar(almacen);
        }
        public String Eliminar(int Id_Almacen)
        {
            return dAlmacen.Eliminar(Id_Almacen);
        }
        public List<Almacen> ListarTodo(int idAlmacen_General)
        {
            return dAlmacen.ListarTodo(idAlmacen_General);
        }
        public List<Almacen> ListarTodo2()
        {
           return dAlmacen.ListarTodo2();
        }

        public List<Almacen> BuscarPorTipoAlmacen(int idAlmacen_General, String tipo_almacen)
        {
           return dAlmacen.BuscarPorTipoAlmacen(idAlmacen_General, tipo_almacen);
        }
        public List<Almacen> BuscarPorAlmacenGeneral(int idAlmacen_General)
        {
            return dAlmacen.BuscarPorAlmacenGeneral(idAlmacen_General);
        }       
       

    }
}
