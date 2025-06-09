using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1
{
    public class DAlmacenGeneral
    {
        public String Registrar(Almacen_General almacen_general)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Almacen_General.Add(almacen_general);
                    context.SaveChanges();
                }
                return "Registrado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Almacen_General almacen_general)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Almacen_General almacen_GeneralTemp = context.Almacen_General.Find(almacen_general.Id_AlmacenGeneral);
                    almacen_GeneralTemp.Area_Recepcion = almacen_general.Area_Recepcion;
                    almacen_GeneralTemp.Area_Despacho = almacen_general.Area_Despacho;
                    almacen_GeneralTemp.Nombre = almacen_general.Nombre;
                    context.SaveChanges();
                }
                return "Modificado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int Id_AlmacenGeneral)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Almacen_General almacen_General = context.Almacen_General.Find(Id_AlmacenGeneral);
                    context.Almacen_General.Remove(almacen_General);
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Almacen_General> ListarTodo()
        {
            List<Almacen_General> almacen_Generals = new List<Almacen_General>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    almacen_Generals = context.Almacen_General.ToList();
                }
                return almacen_Generals;
            }
            catch (Exception ex)
            {
                return almacen_Generals;
            }
        }

        public List<Almacen_General> BuscarPorNombre(String nombre)
        {
            List<Almacen_General> almacen_Generals = new List<Almacen_General>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    almacen_Generals = context.Almacen_General.Where(ag=>ag.Nombre.Equals(nombre)).ToList();
                }
                return almacen_Generals;
            }
            catch (Exception ex)
            {
                return almacen_Generals;
            }
        }

    }
}
