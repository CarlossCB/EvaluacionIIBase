using LibreriaEvaluacion.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DAL
{
    public class PrestamoDAL
    {
        // ToDo: métodos
        public bool Insertar(PrestamoDTO datos)
        {
            return PrestamoDTO.Add(datos);
        }

        public bool Actualizar(PrestamoDTO datos)
        {

        }

        public bool Eliminar(PrestamoDTO datos)
        {

        }

        public List<PrestamoDTO> Listar()
        {
            return PrestamoDTO.datos;
        }

        public int BuscarPorIdSimple(int id)
        {
            for(int i = 0; i < PrestamoDTO.datos.Count; i++)
            {
                if(PrestamoDTO.datos[i].Id == id)
                {
                    return i;
                }
            }
        }

        public bool EliminarPorIndice(int indice)
        {
            int indiceElementoBuscado = BuscarPorIdSimple(id);

            if (indiceElementoBuscado >= 0)
            {
                return PrestamoDTO.RemoveAtIndex(indiceElementoBuscado);
            }

            return false;
        }

        public PrestamoDTO BuscarPorId(int id)
        {

        }
    }
}
