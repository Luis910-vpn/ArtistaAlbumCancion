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
    public partial class FormArtista : Form
    {

        private NArtista nArtista = new NArtista();

        public FormArtista()
        {
            InitializeComponent();
            MostrarArtistas(nArtista.ListarTodo());
        }

        private void MostrarArtistas(List<Artista> artistas)
        {
            dgArtistas.DataSource = null;
            if (artistas.Count != 0)
            {
                dgArtistas.DataSource = artistas;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (tbNombre.Text == "" || tbGenero.Text == "" || tbPais.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos primero.");
                return;
            }

            // Crear un nuevo artista
            Artista artista = new Artista()
            {
                Nombre = tbNombre.Text,
                Genero = tbGenero.Text,
                Pais = tbPais.Text,
                Estado = cbEstado.Text
            };

            String mensaje = nArtista.Registrar(artista);
            MessageBox.Show(mensaje);

            MostrarArtistas(nArtista.ListarTodo());

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (tbNombre.Text == "" || tbGenero.Text == "" || tbPais.Text == "" || cbEstado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos primero.");
                return;
            }

            // Validacion de seleccion
            if (dgArtistas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione primero una fila.");
                return;
            }

            // Obtener el artista seleccionado
            int idArtista = int.Parse(dgArtistas.SelectedRows[0].Cells[0].Value.ToString());

            Artista artista = new Artista()
            {
                IdArtista = idArtista,
                Nombre = tbNombre.Text,
                Genero = tbGenero.Text,
                Pais = tbPais.Text,
                Estado = cbEstado.Text
            };

            String mensaje = nArtista.Modificar(artista);
            MessageBox.Show(mensaje);
            MostrarArtistas(nArtista.ListarTodo());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validacion de seleccion
            if (dgArtistas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione primero una fila.");
                return;
            }

            int idArtista = int.Parse(dgArtistas.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nArtista.Eliminar(idArtista);
            MessageBox.Show(mensaje);
            MostrarArtistas(nArtista.ListarTodo());
        }

        private void btnVerAlbumes_Click(object sender, EventArgs e)
        {
            // Validacion de seleccion
            if (dgArtistas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione primero una fila.");
                return;
            }

            int idArtista = int.Parse(dgArtistas.SelectedRows[0].Cells[0].Value.ToString());

            FormAlbum form = new FormAlbum(idArtista);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
