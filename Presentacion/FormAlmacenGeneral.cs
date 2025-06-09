using Datos1;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAlmacenGeneral : Form
    {
        private NAlmacenGeneral nAlmacenGeneral = new NAlmacenGeneral();

        public FormAlmacenGeneral()
        {
            InitializeComponent();
            MostrarAlmacenesGenerales(nAlmacenGeneral.ListarTodo());
        }

        private void MostrarAlmacenesGenerales(List<Almacen_General> almacenesGenerales)
        {
            if (almacenesGenerales.Count == 0)
            {
                dgAlmacenGeneral.DataSource = null;
                return;
            }

            var datos = almacenesGenerales.Select(ag => new
            {
                ag.Id_AlmacenGeneral,
                ag.Area_Recepcion,
                ag.Fecha,
                ag.Area_Despacho,
                ag.Nombre
            }).ToList();

            dgAlmacenGeneral.DataSource = datos;          

            lblContador.Text = datos.Count.ToString();
        }


        private void LimpiarCampos()
        {
            tbAreaDespacho.Text = string.Empty;
            tbAreaRecepcion.Text = string.Empty;
            tbNombre.Text = string.Empty;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbAreaDespacho.Text) || string.IsNullOrEmpty(tbAreaRecepcion.Text) || string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Almacen_General almacenGeneral = new Almacen_General
            {
                Area_Despacho = tbAreaDespacho.Text,
                Area_Recepcion = tbAreaRecepcion.Text,
                Nombre = tbNombre.Text,
                Fecha = DateTime.Now
            };
            string mensaje = nAlmacenGeneral.Registrar(almacenGeneral);
            MessageBox.Show(mensaje);
            MostrarAlmacenesGenerales(nAlmacenGeneral.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgAlmacenGeneral.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un almacén para eliminar.");
                return;
            }
            if (string.IsNullOrEmpty(tbAreaDespacho.Text) || string.IsNullOrEmpty(tbAreaRecepcion.Text) || string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            int idAlmacenGeneral = Convert.ToInt32(dgAlmacenGeneral.SelectedRows[0].Cells["Id_AlmacenGeneral"].Value);
            Almacen_General almacenGeneral = new Almacen_General
            {
                Id_AlmacenGeneral = idAlmacenGeneral,
                Area_Despacho = tbAreaDespacho.Text,
                Area_Recepcion = tbAreaRecepcion.Text,
                Nombre = tbNombre.Text,
                Fecha = DateTime.Now
            };
            string mensaje = nAlmacenGeneral.Modificar(almacenGeneral);
            MessageBox.Show(mensaje);
            MostrarAlmacenesGenerales(nAlmacenGeneral.ListarTodo());
            LimpiarCampos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgAlmacenGeneral.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un almacén para eliminar.");
                return;
            }
            int idAlmacenGeneral = Convert.ToInt32(dgAlmacenGeneral.SelectedRows[0].Cells["Id_AlmacenGeneral"].Value);
            string mensaje = nAlmacenGeneral.Eliminar(idAlmacenGeneral);
            MessageBox.Show(mensaje);
            dgAlmacenGeneral.DataSource = null;
            MostrarAlmacenesGenerales(nAlmacenGeneral.ListarTodo());
            lblContador.Text = dgAlmacenGeneral.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();
        }

        private void btnVerAlmacenes_Click(object sender, EventArgs e)
        {
            if(dgAlmacenGeneral.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un almacén general para ver sus almacenes.");
                return;
            }

            int id_AlmacenGeneral = Convert.ToInt32(dgAlmacenGeneral.SelectedRows[0].Cells["Id_AlmacenGeneral"].Value);
            FormAlmacen form = new FormAlmacen(id_AlmacenGeneral);
            form.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgAlmacenGeneral_SelectionChanged(object sender, EventArgs e)
        {
            if(dgAlmacenGeneral.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgAlmacenGeneral.SelectedRows[0];
                tbNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                tbAreaDespacho.Text = selectedRow.Cells["Area_Despacho"].Value.ToString();
                tbAreaRecepcion.Text = selectedRow.Cells["Area_Recepcion"].Value.ToString();
            }         
        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscarNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.");
                return;
            }
            string nombre = tbBuscarNombre.Text;
            List<Almacen_General> resultados = nAlmacenGeneral.BuscarPorNombre(nombre);
            dgAlmacenGeneral.DataSource = null;
            MostrarAlmacenesGenerales(nAlmacenGeneral.ListarTodo());
            lblContador.Text = dgAlmacenGeneral.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
        }

        private void brnReportes_Click(object sender, EventArgs e)
        {
            

        }
    }
}
