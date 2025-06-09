using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1
{
    public class DTrabajador
    {
        public string Registrar(Trabajador trabajador)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Trabajador.Add(trabajador);
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
                return "Error al registrar trabajador: " + inner.Message + "\n\n" + inner.ToString();
            }
        }

        public String Modificar(Trabajador trabajador)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Trabajador trabajadorTemp = context.Trabajador.Find(trabajador.Id_Trabajador);
                    trabajadorTemp.Nombre = trabajador.Nombre;
                    trabajadorTemp.Apellido = trabajador.Apellido;
                    trabajadorTemp.DNI = trabajador.DNI;
                    trabajadorTemp.Telefono = trabajador.Telefono;
                    trabajadorTemp.Correo = trabajador.Correo;
                    trabajadorTemp.Cargo = trabajador.Cargo;
                    trabajadorTemp.Id_Almacen = trabajador.Id_Almacen;
                    context.SaveChanges();
                }
                return "Modificado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Eliminar(int Id_Trabajador)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Trabajador trabajadorTemp = context.Trabajador.Find(Id_Trabajador);
                    context.Trabajador.Remove(trabajadorTemp);
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Trabajador> ListarTodo(int idAlmacen)
        {
            List<Trabajador> trabajadors = new List<Trabajador>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    trabajadors = context.Trabajador.Where(a => a.Id_Almacen == idAlmacen).ToList();
                }
                return trabajadors;
            }
            catch (Exception ex)
            {
                return trabajadors;
            }
        }

        public List<Trabajador> BuscarPorCargo(int idAlmacen, String cargo)
        {
            List<Trabajador> trabajadors = new List<Trabajador>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    trabajadors = context.Trabajador.Where(a => a.Id_Almacen == idAlmacen && a.Cargo == cargo).ToList();
                }
                return trabajadors;
            }
            catch (Exception ex)
            {
                return trabajadors;
            }
        }

        public List<Trabajador> BuscarPorAlmacen(int idAlmacen)
        {
            List<Trabajador> trabajadors = new List<Trabajador>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    trabajadors = context.Trabajador.Where(a => a.Id_Almacen == idAlmacen).ToList();
                }
                return trabajadors;
            }
            catch (Exception ex)
            {
                return trabajadors;
            }
        }

    }
}
