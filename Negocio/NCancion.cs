using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NCancion
    {
        private DCancion dCancion = new DCancion();

        public String Registrar(Cancion cancion)
        {
            return dCancion.Registrar(cancion);
        }

        public String Modificar(Cancion cancion)
        {
            return dCancion.Modificar(cancion);
        }

        public String Eliminar(int idcancion)
        {
            return dCancion.Eliminar(idcancion);
        }
        public List<Cancion> ListarTodo(int idalbum)
        {
            return dCancion.ListarTodo(idalbum);
        }
        public List<Cancion> CanciónesMayorDuración()
        {
            return dCancion.CanciónesMayorDuración();
        }

        public List<Cancion> CancionesYoutubeMusic()
        {
            return dCancion.CancionesYoutubeMusic();
        }
    }
}
