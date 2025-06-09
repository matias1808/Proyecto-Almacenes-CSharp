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
    public partial class FormTrabajador : Form
    {
        private NTrabajador nTrabajador = new NTrabajador();
        private int idAlmacen;
        private NAlmacen nAlmacen = new NAlmacen();

        public FormTrabajador(int idAlmacen)
        {
            InitializeComponent();

            this.idAlmacen = idAlmacen;

            Almacen almacenActual = nAlmacen.ListarTodo2().FirstOrDefault(a => a.Id_Almacen == idAlmacen);
            if (almacenActual != null)
            {
                label14.Text = "Almacén: " + almacenActual.Nombre;
            }
            else
            {
                label14.Text = "Almacén: No encontrado";
            }

            MostrarTrabajadores(nTrabajador.ListarTodo(idAlmacen));
            MostrarAlmacenes(nAlmacen.ListarTodo2());
            MostrarAlmacenes__2(nAlmacen.ListarTodo2());
        }


        private void MostrarTrabajadores(List<Trabajador> trabajadores)
        {
            if (trabajadores.Count == 0)
            {
                dgTrabajadores.DataSource = null;
                return;
            }
            List<Almacen> almacenes = new NAlmacen().ListarTodo2(); 
            var datos = from t in trabajadores
                        join a in almacenes on t.Id_Almacen equals a.Id_Almacen
                        select new
                        {
                            t.Id_Trabajador,
                            t.Nombre,
                            t.Apellido,
                            t.DNI,
                            t.Telefono,
                            t.Correo,
                            t.Cargo,
                            Almacen = a.Nombre 
                        };
            
            dgTrabajadores.DataSource = datos.ToList();
            lblContador.Text = datos.Count().ToString();
        }


        private void MostrarAlmacenes(List<Almacen> almacens)
        {
            cbAlmacen.DataSource = null;
            if (almacens.Count == 0)
            {
                return;
            }
            else
            {
                cbAlmacen.DataSource = almacens;
                cbAlmacen.ValueMember = "Id_Almacen";
                cbAlmacen.DisplayMember = "Nombre";
            }
            cbAlmacen.SelectedIndex = -1;
        }

        private void MostrarAlmacenes__2(List<Almacen> almacens)
        {
            cbAlmacenBuscar.DataSource = null;
            if (almacens.Count == 0)
            {
                return;
            }
            else
            {
                cbAlmacenBuscar.DataSource = almacens;
                cbAlmacenBuscar.ValueMember = "Id_Almacen";
                cbAlmacenBuscar.DisplayMember = "Nombre";
            }
            cbAlmacenBuscar.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbDNI.Clear();
            tbTelefono.Clear();
            tbCorreo.Clear();
            cbCargo.SelectedIndex = -1;
            cbAlmacen.SelectedIndex = -1;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbApellido.Text) || string.IsNullOrWhiteSpace(tbCorreo.Text) || string.IsNullOrWhiteSpace(tbDNI.Text) ||
                string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbTelefono.Text) || string.IsNullOrWhiteSpace(cbCargo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (cbAlmacen.SelectedIndex != -1)
            {
                MessageBox.Show("No se permite seleccionar un nuevo almacén al registrar. El cambio solo es posible en Modificar.");
                return;
            }

            if (!int.TryParse(tbDNI.Text.Trim(), out int dniParsed))
            {
                MessageBox.Show("El campo DNI debe ser un número entero válido.");
                return;
            }

            Trabajador trabajador = new Trabajador
            {
                Nombre = tbNombre.Text.Trim(),
                Apellido = tbApellido.Text.Trim(),
                DNI = dniParsed,
                Telefono = tbTelefono.Text.Trim(),
                Correo = tbCorreo.Text.Trim(),
                Cargo = cbCargo.Text.Trim(),
                Fecha = DateTime.Now,
                Id_Almacen = idAlmacen
            };

            string resultado = nTrabajador.Registrar(trabajador);
            MessageBox.Show(resultado);
            MostrarTrabajadores(nTrabajador.ListarTodo(idAlmacen));
            LimpiarCampos();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgTrabajadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un trabajador para modificar.");
                return;
            }

            int idTrabajadorSeleccionado = Convert.ToInt32(dgTrabajadores.SelectedRows[0].Cells["Id_Trabajador"].Value);

            if (string.IsNullOrWhiteSpace(tbApellido.Text) || string.IsNullOrWhiteSpace(tbCorreo.Text) || string.IsNullOrWhiteSpace(tbDNI.Text) ||
                string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbTelefono.Text) || string.IsNullOrWhiteSpace(cbCargo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (!int.TryParse(tbDNI.Text.Trim(), out int dniParsed))
            {
                MessageBox.Show("El campo DNI debe ser un número entero válido.");
                return;
            }

            Trabajador trabajador = new Trabajador
            {
                Id_Trabajador = idTrabajadorSeleccionado,
                Nombre = tbNombre.Text.Trim(),
                Apellido = tbApellido.Text.Trim(),
                DNI = dniParsed,
                Telefono = tbTelefono.Text.Trim(),
                Correo = tbCorreo.Text.Trim(),
                Cargo = cbCargo.Text.Trim(),
                Fecha = DateTime.Now,
                Id_Almacen = Convert.ToInt32(cbAlmacen.SelectedValue)
            };

            string resultado = nTrabajador.Modificar(trabajador);
            MessageBox.Show(resultado);
            dgTrabajadores.DataSource = null;
            MostrarTrabajadores(nTrabajador.ListarTodo(idAlmacen));
            lblContador.Text = dgTrabajadores.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgTrabajadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un trabajador para eliminar.");
                return;
            }
            int idTrabajador = Convert.ToInt32(dgTrabajadores.SelectedRows[0].Cells["Id_Trabajador"].Value);
            string resultado = nTrabajador.Eliminar(idTrabajador);
            MessageBox.Show(resultado);
            dgTrabajadores.DataSource = null;
            MostrarTrabajadores(nTrabajador.ListarTodo(idAlmacen));
            lblContador.Text = dgTrabajadores.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();
        }

        private void btnBuscarPorCargo_Click(object sender, EventArgs e)
        {
            if(cbCargoBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un cargo para buscar.");
                return;
            }
            string cargo = cbCargoBuscar.Text.Trim();
            dgTrabajadores.DataSource = null;
            MostrarTrabajadores(nTrabajador.BuscarPorCargo(idAlmacen, cargo));
            lblContador.Text = dgTrabajadores.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
        }

        private void btnBuscarPorAlmacen_Click(object sender, EventArgs e)
        {
            if(cbAlmacenBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un almacén para buscar.");
                return;
            }
            int idAlmacenBuscar = Convert.ToInt32(cbAlmacenBuscar.SelectedValue);
            dgTrabajadores.DataSource = null;
            MostrarTrabajadores(nTrabajador.BuscarPorAlmacen(idAlmacenBuscar));
            lblContador.Text = dgTrabajadores.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            MostrarTrabajadores(nTrabajador.ListarTodo(idAlmacen));
        }

        private void btnMostrarTodo2_Click(object sender, EventArgs e)
        {
            MostrarTrabajadores(nTrabajador.ListarTodo(idAlmacen));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgTrabajadores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgTrabajadores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgTrabajadores.SelectedRows[0];
                tbNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                tbApellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
                tbDNI.Text = selectedRow.Cells["DNI"].Value.ToString();
                tbTelefono.Text = selectedRow.Cells["Telefono"].Value.ToString();
                tbCorreo.Text = selectedRow.Cells["Correo"].Value.ToString();
                cbCargo.Text = selectedRow.Cells["Cargo"].Value.ToString();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           
        }

        private void cbAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tbCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbAlmacenBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbCargoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void dgTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
