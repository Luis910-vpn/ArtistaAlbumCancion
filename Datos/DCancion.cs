using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCancion
    {
        public String Registrar(Cancion cancion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Cancion.Add(cancion);
                    context.SaveChanges();
                }
                return "Cancion registrada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Cancion cancion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cancion cancionTemporal = context.Cancion.Find(cancion.IdCancion);
                    cancionTemporal.Titulo = cancion.Titulo;
                    cancionTemporal.Duracion = cancion.Duracion;
                    cancionTemporal.Plataforma = cancion.Plataforma;
                    context.SaveChanges();
                }
                return "Cancion modificada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idcancion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cancion cancion = context.Cancion.Find(idcancion);
                    context.Cancion.Remove(cancion);
                    context.SaveChanges();
                }
                return "Cancion eliminada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Cancion> ListarTodo(int idalbum)
        {
            List<Cancion> canciones = new List<Cancion>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    canciones = context.Cancion.Where(a => a.IdAlbum == idalbum).ToList();
                }
                return canciones;
            }
            catch (Exception ex)
            {
                return canciones;
            }
        }
        public List<Cancion> CanciónesMayorDuración()
        {
            List<Cancion> canciones = new List<Cancion>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    canciones = context.Cancion.OrderByDescending(c => c.Duracion).ToList();
                }
                return canciones;
            }
            catch (Exception ex)
            {
                return canciones;
            }
        }

        public List<Cancion> CancionesYoutubeMusic()
        {
            List<Cancion> canciones = new List<Cancion>();  
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    canciones = context.Cancion.Where(c => c.Plataforma.Equals("Youtube Music")).ToList();
                }
                return canciones;
            }
            catch (Exception ex)
            {
                return canciones;
            }
        }
    }
}
