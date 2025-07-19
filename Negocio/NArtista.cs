using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NArtista
    {
        private DArtista dArtista = new DArtista();

        public String Registrar(Artista artista)
        {
            return dArtista.Registrar(artista);
        }

        public String Modificar(Artista artista)
        {
            return dArtista.Modificar(artista);
        }

        public String Eliminar(int idartista)
        {
           return dArtista.Eliminar(idartista);
        }
        public List<Artista> ListarTodo()
        {
            return dArtista.ListarTodo();
        }
    }
}
