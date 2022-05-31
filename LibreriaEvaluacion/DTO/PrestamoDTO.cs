using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    public class PrestamoDTO
    {
        // ToDo: atributos
        private int id;
        private int monto;
        private int montomasinteres;
        private int montomasatraso;
        // ToDo: propiedades
        public int Id { get => id; set => id = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Montomasinteres { get => montomasinteres; set => montomasinteres = value; }
        public int Montomasatraso { get => montomasatraso; set => montomasatraso = value; }
        // ToDo: métodos
        public static List<PrestamoDTO> datos = new List<PrestamoDTO>()
        {
          new PrestamoDTO() { id = 1, Monto = 2, montomasinteres = 3, Montomasatraso = 4 },
          new PrestamoDTO() { id = 2, Monto = 3, montomasinteres = 4, Montomasatraso = 5 },
          new PrestamoDTO() { id = 3, Monto = 4, montomasinteres = 5, Montomasatraso = 6 },
        };
        public static bool Add(PrestamoDTO datos)
        {
            try
            {
                datos.Add(datos);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static int Find(int id)
        {
            try
            {
                datos.Find(id);
                return id;
            }
            catch (Exception)
            {

                return  -1;
            }
        }
        public static PrestamoDTO Find(PrestamoDTO datos)
        {
            try
            {
                datos.Find(datos);
                return datos;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public static bool Edit(PrestamoDTO datos, int index)
        {
            try
            {
                datos.Edit(datos, index);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool RemoveAtIndex(PrestamoDTO datos, int index)
        {
            try
            {
                datos.RemoveAtIndex(datos, index);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool RemoveById(PrestamoDTO datos, int index)
        {
            try
            {
                datos.RemoveById(datos, index);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public override string ToString()
        {
            return $"Id: {id}, Monto: {monto}, MontoMasInteres: {montomasinteres}, MontoMasAtraso: {montomasatraso}";
        }
    }
}
