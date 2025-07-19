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
    public partial class FormAlbum : Form
    {

        private NAlbum nAlbum = new NAlbum();

        private int idArtista;
        public FormAlbum(int idArtista)
        {
            InitializeComponent();
            this.idArtista = idArtista;
            MostrarAlbumes(nAlbum.ListarTodo(idArtista));
        }

        private void MostrarAlbumes(List<Album> albumes)
        {
            dgAlbumes.DataSource = null;
            if (albumes.Count != 0)
            {
                dgAlbumes.DataSource = albumes;
                dgAlbumes.Columns["Artista"].Visible = false;
                dgAlbumes.Columns["Cancion"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbTitulo.Text == "" || dtpAnioLanzamiento.Text == "" || tbDuracionTotal.Text == "")
            {
                MessageBox.Show("Complete todos los campos primero.");
                return;
            }

            Album album = new Album()
            {
                Titulo = tbTitulo.Text,
                AnioLanzamiento = dtpAnioLanzamiento.Value.Date,
                DuracionTotal = decimal.Parse(tbDuracionTotal.Text),
                IdArtista = idArtista
            };

            String mensaje = nAlbum.Registrar(album);
            MessageBox.Show(mensaje);
            MostrarAlbumes(nAlbum.ListarTodo(idArtista));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbTitulo.Text == "" || dtpAnioLanzamiento.Text == "" || tbDuracionTotal.Text == "")
            {
                MessageBox.Show("Complete todos los campos primero.");
                return;
            }

            if (dgAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila primero");
                return;
            }

            int idAlbum = int.Parse(dgAlbumes.SelectedRows[0].Cells[0].Value.ToString());

            Album album = new Album()
            {
                IdAlbum = idAlbum,
                Titulo = tbTitulo.Text,
                AnioLanzamiento = dtpAnioLanzamiento.Value.Date,
                DuracionTotal = decimal.Parse(tbDuracionTotal.Text), 
            };

            String mensaje = nAlbum.Modificar(album);
            MessageBox.Show(mensaje);
            MostrarAlbumes(nAlbum.ListarTodo(idArtista));

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila primero");
                return;
            }

            int idAlbum = int.Parse(dgAlbumes.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nAlbum.Eliminar(idAlbum);
            MessageBox.Show(mensaje);
            MostrarAlbumes(nAlbum.ListarTodo(idArtista));
        }

        private void btnVerCanciones_Click(object sender, EventArgs e)
        {
            if (dgAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila primero");
                return;
            }

            int idAlbum = int.Parse(dgAlbumes.SelectedRows[0].Cells[0].Value.ToString());

            FormCancion form = new FormCancion(idAlbum);
            form.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
