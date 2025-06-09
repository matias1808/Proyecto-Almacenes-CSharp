using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos1
{
    public class DArea
    {
        public String Registrar(Area_Operativa_Produccion area)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Area_Operativa_Produccion.Add(area);
                    context.SaveChanges();
                }
                return "Registrado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Area_Operativa_Produccion area)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Area_Operativa_Produccion area_Operativa_ProduccionTemp = context.Area_Operativa_Produccion.Find(area.Id_Area);
                    area_Operativa_ProduccionTemp.Seccion = area.Seccion;
                    context.SaveChanges();
                }
                return "Modificado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int Id_Area)
        {
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    Area_Operativa_Produccion area_Operativa_ProduccionTemp = context.Area_Operativa_Produccion.Find(Id_Area);
                    context.Area_Operativa_Produccion.Remove(area_Operativa_ProduccionTemp);
                    context.SaveChanges();
                }
                return "Eliminado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Area_Operativa_Produccion> ListarTodo()
        {
            List<Area_Operativa_Produccion> area_Operativa_Produccions = new List<Area_Operativa_Produccion>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    area_Operativa_Produccions = context.Area_Operativa_Produccion.ToList();
                }
                return area_Operativa_Produccions;
            }
            catch (Exception ex)
            {
                return area_Operativa_Produccions;
            }
        }

        public List<Area_Operativa_Produccion> BuscarPorSeccion(String Seccion)
        {
            List<Area_Operativa_Produccion> area_Operativa_Produccions = new List<Area_Operativa_Produccion>();
            try
            {
                using (var context = new db_proyecto_3Entities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    area_Operativa_Produccions = context.Area_Operativa_Produccion.Where(ag => ag.Seccion.Equals(Seccion)).ToList();
                }
                return area_Operativa_Produccions;
            }
            catch (Exception ex)
            {
                return area_Operativa_Produccions;
            }
        }
    }
}
