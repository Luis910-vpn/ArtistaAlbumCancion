using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAlbum
    {
        public String Registrar(Album album)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Album.Add(album);
                    context.SaveChanges();
                }
                return "Album registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Album album)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Album albumTemporal = context.Album.Find(album.IdAlbum);
                    albumTemporal.Titulo = album.Titulo;
                    albumTemporal.AnioLanzamiento = album.AnioLanzamiento;
                    albumTemporal.DuracionTotal = album.DuracionTotal;
                    context.SaveChanges();
                }
                return "Album modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idalbum)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Album album = context.Album.Find(idalbum);
                    context.Album.Remove(album);
                    context.SaveChanges();
                }
                return "Album eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Album> ListarTodo(int idartista)
        {
            List<Album> albums = new List<Album>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    albums = context.Album.Where(a => a.IdArtista == idartista).ToList();
                }
                return albums;
            }
            catch (Exception ex)
            {
                return albums;
            }
        }

        

    }
}
