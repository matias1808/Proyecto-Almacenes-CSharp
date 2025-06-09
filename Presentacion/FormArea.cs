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
    public partial class FormArea : Form
    {
        private NArea nArea = new NArea();

        public FormArea()
        {
            InitializeComponent();
            MostrarAreas(nArea.ListarTodo());
        }

        private void MostrarAreas(List<Area_Operativa_Produccion> areas)
        {
            if (areas.Count == 0)
            {
                dgAreaOperativaProduccion.DataSource = null;
                return;
            }           
            var datos = areas.Select(a => new
            {
                a.Id_Area,
                a.Seccion,
                a.Fecha
            }).ToList();

            dgAreaOperativaProduccion.DataSource = datos;      
            lblContador.Text = datos.Count.ToString();
        }


        private void LimpiarCampos()
        {
            tbSeccion.Text = string.Empty;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSeccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Area_Operativa_Produccion area = new Area_Operativa_Produccion
            {
                Seccion = tbSeccion.Text,
                Fecha = DateTime.Now
            };
            string mensaje = nArea.Registrar(area);
            MessageBox.Show(mensaje);
            MostrarAreas(nArea.ListarTodo());
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgAreaOperativaProduccion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un área para eliminar.");
                return;
            }
            int idArea = Convert.ToInt32(dgAreaOperativaProduccion.SelectedRows[0].Cells["Id_Area"].Value);
            if (string.IsNullOrEmpty(tbSeccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Area_Operativa_Produccion area = new Area_Operativa_Produccion
            {
                Id_Area = idArea,
                Seccion = tbSeccion.Text,
                Fecha = DateTime.Now
            };
            string mensaje = nArea.Modificar(area);
            MessageBox.Show(mensaje);
            dgAreaOperativaProduccion.DataSource = null;
            MostrarAreas(nArea.ListarTodo());
            lblContador.Text = dgAreaOperativaProduccion.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();
        }

        private void btnVerAsignacionAreaProducto_Click(object sender, EventArgs e)
        {
            FormArea_Producto formArea_Producto = new FormArea_Producto();
            formArea_Producto.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgAreaOperativaProduccion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un área para eliminar.");
                return;
            }
            int idArea = Convert.ToInt32(dgAreaOperativaProduccion.SelectedRows[0].Cells["Id_Area"].Value);
            String mensaje = nArea.Eliminar(idArea);
            MessageBox.Show(mensaje);
            dgAreaOperativaProduccion.DataSource = null;
            MostrarAreas(nArea.ListarTodo());
            lblContador.Text = dgAreaOperativaProduccion.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPorSeccion_Click(object sender, EventArgs e)
        {
            if(tbBuscarSeccion.Text == "")
            {
                MessageBox.Show("Por favor, ingrese una sección para buscar.");
                return;
            }
            String seccion = tbBuscarSeccion.Text;
            dgAreaOperativaProduccion.DataSource = null;
            MostrarAreas(nArea.BuscarPorSeccion(seccion));
            lblContador.Text = dgAreaOperativaProduccion.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            MostrarAreas(nArea.ListarTodo());
        }

        private void dgAreaOperativaProduccion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAreaOperativaProduccion.SelectedRows.Count > 0)
            {
                tbSeccion.Text = dgAreaOperativaProduccion.SelectedRows[0].Cells["Seccion"].Value.ToString();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
        }
    }
}