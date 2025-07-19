using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class FormReporte : Form
    {
        private NAlbum nAlbum = new NAlbum();
        private NArtista nArtista = new NArtista();

        private NCancion nCancion = new NCancion();
        public FormReporte()
        {
            InitializeComponent();
            
            
        }

        private void MostrarAlbumes(List<Album> albumes)
        {
            
            dgAlbumes.DataSource = null;
            if (albumes.Count != 0)
            { 
                dgAlbumes.DataSource = albumes;
               
            }
        }

        private void MostrarCanciones(List<Cancion> canciones)
        {
            dgCanciones.DataSource = null;
            if (canciones.Count != 0)
            {
                dgCanciones.DataSource = canciones;
            }
        }

        private void btnCanciónMayorDuracion_Click(object sender, EventArgs e)
        {
            MostrarCanciones(nCancion.CanciónesMayorDuración());

        }

        private void btnCancionesYoutubeMusic_Click(object sender, EventArgs e)
        {
            MostrarCanciones(nCancion.CancionesYoutubeMusic());
        }
    }
}
