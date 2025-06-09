using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1
{
    public class DAlmacen
    {
        public string Registrar(Almacen almacen)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Almacen.Add(almacen);
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
                return "Error al registrar almacen: " + inner.Message + "\n\n" + inner.ToString();
            }
        }

        public String Modificar(Almacen almacen)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Almacen almacenTemp = context.Almacen.Find(almacen.Id_Almacen);
                    almacenTemp.Nombre = almacen.Nombre;
                    almacenTemp.Telefono = almacen.Telefono;
                    almacenTemp.Tipo_Almacen = almacen.Tipo_Almacen;
                    almacenTemp.Id_AlmacenGeneral = almacen.Id_AlmacenGeneral;
                    context.SaveChanges();
                }
                return "Modificado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Eliminar(int Id_Almacen)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Almacen almacenTemp = context.Almacen.Find(Id_Almacen);
                    context.Almacen.Remove(almacenTemp);
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Almacen> ListarTodo(int idAlmacen_General)
        {
            List<Almacen> almacens = new List<Almacen>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    almacens = context.Almacen.Where(a => a.Id_AlmacenGeneral == idAlmacen_General).ToList();
                }
                return almacens;
            }
            catch (Exception ex)
            {
                return almacens;
            }
        }
        public List<Almacen> ListarTodo2()
        {
            List<Almacen> almacens = new List<Almacen>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    almacens = context.Almacen.ToList();
                }
                return almacens;
            }
            catch (Exception ex)
            {
                return almacens;
            }
        }

        public List<Almacen> BuscarPorTipoAlmacen(int idAlmacen_General, String tipo_almacen)
        {
            List<Almacen> almacens = new List<Almacen>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    almacens = context.Almacen.Where(a => a.Id_AlmacenGeneral == idAlmacen_General && a.Tipo_Almacen == tipo_almacen).ToList();
                }
                return almacens;
            }
            catch (Exception ex)
            {
                return almacens;
            }
        }

        public List<Almacen> BuscarPorAlmacenGeneral(int idAlmacen_General)
        {
            List<Almacen> almacens = new List<Almacen>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    almacens = context.Almacen.Where(a => a.Id_AlmacenGeneral == idAlmacen_General).ToList();
                }
                return almacens;
            }
            catch (Exception ex)
            {
                return almacens;
            }
        }     
    }
}
