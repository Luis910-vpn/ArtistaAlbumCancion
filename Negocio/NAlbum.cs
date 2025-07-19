using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NAlbum
    {
        private DAlbum dAlbum = new DAlbum();

        public String Registrar(Album album)
        {
            return dAlbum.Registrar(album);
        }

        public String Modificar(Album album)
        {
            return dAlbum.Modificar(album);
        }

        public String Eliminar(int idalbum)
        {
            return dAlbum.Eliminar(idalbum);
        }
        public List<Album> ListarTodo(int idartista)
        {
            return dAlbum.ListarTodo(idartista);
        }
        
    }
}
