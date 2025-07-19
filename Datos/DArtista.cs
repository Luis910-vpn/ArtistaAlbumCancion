using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DArtista
    {
        public String Registrar(Artista artista)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Artista.Add(artista);
                    context.SaveChanges();
                }
                return "Artista registrado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Artista artista)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Artista artistaTemporal = context.Artista.Find(artista.IdArtista);
                    artistaTemporal.Nombre = artista.Nombre;
                    artistaTemporal.Genero = artista.Genero;
                    artistaTemporal.Pais = artista.Pais;
                    artistaTemporal.Estado = artista.Estado;
                    context.SaveChanges();
                }
                return "Artista modificado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int idartista)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Artista artista = context.Artista.Find(idartista);
                    context.Artista.Remove(artista);
                    context.SaveChanges();
                }
                return "Artista eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Artista> ListarTodo()
        {
            List<Artista> artistas = new List<Artista>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    artistas = context.Artista.ToList();
                }
                return artistas;
            }
            catch (Exception ex)
            {
                return artistas;
            }
        }

    }
}
