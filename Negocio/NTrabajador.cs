using Datos1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{public class NTrabajador
    {
        private DTrabajador dTrabajador = new DTrabajador();

        public string Registrar(Trabajador trabajador)
        {
            return dTrabajador.Registrar(trabajador);
        }

        public String Modificar(Trabajador trabajador)
        {
            return dTrabajador.Modificar(trabajador);
        }
        public String Eliminar(int Id_Trabajador)
        {
           return dTrabajador.Eliminar(Id_Trabajador);
        }
        public List<Trabajador> ListarTodo(int idAlmacen)
        {
            return dTrabajador.ListarTodo(idAlmacen);
        }

        public List<Trabajador> BuscarPorCargo(int idAlmacen, String cargo)
        {
           return dTrabajador.BuscarPorCargo(idAlmacen, cargo);
        }

        public List<Trabajador> BuscarPorAlmacen(int idAlmacen)
        {
            return dTrabajador.BuscarPorAlmacen(idAlmacen);
        }      
        
    }
}
