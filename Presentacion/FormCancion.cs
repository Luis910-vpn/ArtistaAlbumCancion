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
    public partial class FormCancion : Form
    {

        private NCancion nCancion = new NCancion();
        private int idAlbum;
        public FormCancion(int idAlbum)
        {
            InitializeComponent();
            this.idAlbum = idAlbum;
            MostrarCanciones(nCancion.ListarTodo(idAlbum));
        }

        private void MostrarCanciones(List<Cancion> canciones)
        {
            dgCanciones.DataSource = null;
            if (canciones.Count != 0)
            {
                dgCanciones.DataSource = canciones;
                dgCanciones.Columns["Album"].Visible = false; // Ocultar la columna Album
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbTitulo.Text == "" || tbDuracion.Text == "" || cbPlataforma.Text == "")
            {
                MessageBox.Show("Complete todos los campos primero");
                return;
            }

            Cancion cancion = new Cancion()
            {
                Titulo = tbTitulo.Text,
                Duracion = decimal.Parse(tbDuracion.Text),
                Plataforma = cbPlataforma.Text,
                IdAlbum = idAlbum
            };

            String mensaje = nCancion.Registrar(cancion);
            MessageBox.Show(mensaje);
            MostrarCanciones(nCancion.ListarTodo(idAlbum));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbTitulo.Text == "" || tbDuracion.Text == "" || cbPlataforma.Text == "")
            {
                MessageBox.Show("Complete todos los campos primero");
                return;
            }

            if (dgCanciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila primero");
                return;
            }

            int idCancion = int.Parse(dgCanciones.SelectedRows[0].Cells[0].Value.ToString());

            Cancion cancion = new Cancion()
            {
                IdCancion = idCancion,
                Titulo = tbTitulo.Text,
                Duracion = decimal.Parse(tbDuracion.Text),
                Plataforma = cbPlataforma.Text,
            };
            String mensaje = nCancion.Modificar(cancion);
            MessageBox.Show(mensaje);
            MostrarCanciones(nCancion.ListarTodo(idAlbum));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCanciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila primero");
                return;
            }

            int idCancion = int.Parse(dgCanciones.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nCancion.Eliminar(idCancion);
            MessageBox.Show(mensaje);
            MostrarCanciones(nCancion.ListarTodo(idAlbum));

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
