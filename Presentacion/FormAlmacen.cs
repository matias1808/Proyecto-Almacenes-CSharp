using Datos1;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAlmacen : Form
    {
        private int id_AlmacenGeneral;
        private NAlmacen NAlmacen = new NAlmacen();
        private NAlmacenGeneral NAlmacenGeneral = new NAlmacenGeneral();

        public FormAlmacen(int id_AlmacenGeneral)
        {
            InitializeComponent();
            this.id_AlmacenGeneral = id_AlmacenGeneral;
            MostrarAlmacen(NAlmacen.ListarTodo(id_AlmacenGeneral));
            MostrarAlmacenesGeneral(NAlmacenGeneral.ListarTodo());
            MostrarAlmacenesGeneral__2(NAlmacenGeneral.ListarTodo());

            Almacen_General almacen_Generalactual = NAlmacenGeneral.ListarTodo().FirstOrDefault(a => a.Id_AlmacenGeneral == id_AlmacenGeneral);
            if (almacen_Generalactual != null)
            {
                label10.Text = "Almacén: " + almacen_Generalactual.Nombre;
            }
            else
            {
                label10.Text = "Almacén: No encontrado";
            }
        }

        private void MostrarAlmacenesGeneral(List<Almacen_General> almacen_Generals)
        {
            cbAlmacenGeneral.DataSource = null;
            if (almacen_Generals.Count == 0)
            {
                return;
            }
            else
            {
                cbAlmacenGeneral.DataSource = almacen_Generals;
                cbAlmacenGeneral.ValueMember = "Id_AlmacenGeneral";
                cbAlmacenGeneral.DisplayMember = "Nombre";
            }
            cbAlmacenGeneral.SelectedIndex = -1;
        }

        private void MostrarAlmacenesGeneral__2(List<Almacen_General> almacen_Generals)
        {
            cbAlmacenGeneralBuscar.DataSource = null;
            if (almacen_Generals.Count == 0)
            {
                return;
            }
            else
            {
                cbAlmacenGeneralBuscar.DataSource = almacen_Generals;
                cbAlmacenGeneralBuscar.ValueMember = "Id_AlmacenGeneral";
                cbAlmacenGeneralBuscar.DisplayMember = "Nombre";
            }
            cbAlmacenGeneralBuscar.SelectedIndex = -1;
        }

        private void MostrarAlmacen(List<Almacen> almacens)
        {
            if (almacens.Count == 0)
            {
                dgAlmacen.DataSource = null;
                return;
            }
            List<Almacen_General> almacenesGenerales = NAlmacenGeneral.ListarTodo();
            var datosPersonalizados = from a in almacens
                                      join ag in almacenesGenerales
                                      on a.Id_AlmacenGeneral equals ag.Id_AlmacenGeneral
                                      select new
                                      {
                                          a.Id_Almacen,
                                          a.Nombre,
                                          a.Telefono,
                                          a.Tipo_Almacen,
                                          a.Fecha,
                                          AlmacenGeneral = ag.Nombre 

                                      };

            dgAlmacen.DataSource = datosPersonalizados.ToList(); 
            lblContador.Text = datosPersonalizados.Count().ToString();
        }


        private void LimpiarCampos()
        {
            tbNombre.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            cbTipoAlmacen.SelectedIndex = -1;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbTelefono.Text) || string.IsNullOrEmpty(cbTipoAlmacen.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (cbAlmacenGeneral.SelectedIndex != -1)
            {
                MessageBox.Show("No se permite cambiar el Almacén General al registrar. Solo puede hacerse al modificar.");
                return;
            }

            Almacen almacen = new Almacen
            {
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                Tipo_Almacen = cbTipoAlmacen.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Id_AlmacenGeneral = this.id_AlmacenGeneral
            };

            string resultado = NAlmacen.Registrar(almacen);
            MessageBox.Show(resultado);
            MostrarAlmacen(NAlmacen.ListarTodo(this.id_AlmacenGeneral));
            LimpiarCampos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgAlmacen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un almacén para eliminar.");
                return;
            }
            int idAlmacen = Convert.ToInt32(dgAlmacen.SelectedRows[0].Cells["Id_Almacen"].Value);
            string resultado = NAlmacen.Eliminar(idAlmacen);
            MessageBox.Show(resultado);
            dgAlmacen.DataSource = null;
            MostrarAlmacen(NAlmacen.ListarTodo(this.id_AlmacenGeneral));
            lblContador.Text = dgAlmacen.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgAlmacen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un almacén para modificar.");
                return;
            }
            int idAlmacen = Convert.ToInt32(dgAlmacen.SelectedRows[0].Cells["Id_Almacen"].Value);
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbTelefono.Text) || string.IsNullOrEmpty(cbTipoAlmacen.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Almacen almacen = new Almacen
            {
                Id_Almacen = idAlmacen,
                Nombre = tbNombre.Text,
                Telefono = tbTelefono.Text,
                Tipo_Almacen = cbTipoAlmacen.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Id_AlmacenGeneral = Convert.ToInt32(cbAlmacenGeneral.SelectedValue) 
            };

            string resultado = NAlmacen.Modificar(almacen);
            MessageBox.Show(resultado);
            dgAlmacen.DataSource = null;
            MostrarAlmacen(NAlmacen.ListarTodo(id_AlmacenGeneral));
            lblContador.Text = dgAlmacen.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();
        }

        private void btnVerTrabajadores_Click(object sender, EventArgs e)
        {
            if(dgAlmacen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un almacén para ver los trabajadores.");
                return;
            }
            int idAlmacen = Convert.ToInt32(dgAlmacen.SelectedRows[0].Cells["Id_Almacen"].Value);
            FormTrabajador formTrabajador = new FormTrabajador(idAlmacen);
            formTrabajador.Show();
        }

        private void btnBuscarPorTipoAlmacen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTipoAlmacenBuscar.Text))
            {
                MessageBox.Show("Por favor, seleccione un tipo de almacén.");
                return;
            }
            string tipoAlmacen = cbTipoAlmacenBuscar.SelectedItem.ToString();
            dgAlmacen.DataSource = null;
            MostrarAlmacen(NAlmacen.BuscarPorTipoAlmacen(this.id_AlmacenGeneral, tipoAlmacen));
            lblContador.Text = dgAlmacen.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            MostrarAlmacen(NAlmacen.ListarTodo(this.id_AlmacenGeneral));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgAlmacenGeneral_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAlmacen.SelectedRows.Count > 0)
            {
                tbNombre.Text = dgAlmacen.SelectedRows[0].Cells["Nombre"].Value.ToString();
                tbTelefono.Text = dgAlmacen.SelectedRows[0].Cells["Telefono"].Value.ToString();
                cbTipoAlmacen.SelectedItem = dgAlmacen.SelectedRows[0].Cells["Tipo_Almacen"].Value.ToString();
                cbAlmacenGeneral.SelectedValue = dgAlmacen.SelectedRows[0].Cells["AlmacenGeneral"].Value.ToString();

            }
        }

        private void btnBuscarPorAlmacenGeneral_Click(object sender, EventArgs e)
        {
            if(cbAlmacenGeneralBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un almacén general.");
                return;
            }
            int idAlmacenGeneral = Convert.ToInt32(cbAlmacenGeneralBuscar.SelectedValue);
            dgAlmacen.DataSource = null;
            MostrarAlmacen(NAlmacen.BuscarPorAlmacenGeneral(idAlmacenGeneral));
            lblContador.Text = dgAlmacen.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
        }

        private void btnMostrarTodo2_Click(object sender, EventArgs e)
        {
            MostrarAlmacen(NAlmacen.ListarTodo(this.id_AlmacenGeneral));
        }

        private void cbAlmacenGeneralBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbAlmacenGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoAlmacenBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void dgAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgAlmacen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un almacén para ver los trabajadores.");
                return;
            }
            int idAlmacen = Convert.ToInt32(dgAlmacen.SelectedRows[0].Cells["Id_Almacen"].Value);
            FormProducto formTrabajador = new FormProducto(idAlmacen);
            formTrabajador.Show();
        }

        
    }
}
