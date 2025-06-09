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
    public partial class FormProducto : Form
    {
        private NProducto nProducto = new NProducto();
        private NAlmacen nAlmacen = new NAlmacen();
        int idAlmacen;

        public FormProducto(int idAlmacen)
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
            MostrarProductos(nProducto.ListarTodo(idAlmacen));
            MostrarAlmacenes(nAlmacen.ListarTodo2());
            MostrarAlmacenes__2(nAlmacen.ListarTodo2());
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

        private void MostrarProductos(List<Producto> productos)
        {
            if (productos.Count == 0)
            {
                dgProducto.DataSource = null;
                return;
            }

            List<Almacen> almacenes = new NAlmacen().ListarTodo2(); 

            var datos = from p in productos
                        join a in almacenes on p.Id_Almacen equals a.Id_Almacen
                        select new
                        {
                            Codigo = p.Codigo,
                            p.Nombre,
                            p.Costo,
                            p.Descripcion,
                            p.Unidad_Medida,
                            p.Tipo_Producto,
                            p.Stock,
                            Almacen = a.Nombre,
                            p.Fecha
                        };

            dgProducto.DataSource = datos.ToList();
            lblContador.Text = datos.Count().ToString();
        }



        private void LimpiarCampos()
        {
            tbNombre.Clear();
            tbDescripcion.Clear();
            tbCosto.Clear();
            tbStock.Clear();
            cbTipoProducto.SelectedIndex = -1;
            cbUnidadMedida.SelectedIndex = -1;
            cbAlmacen.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(tbCosto.Text) || string.IsNullOrEmpty(cbTipoProducto.Text)
                || string.IsNullOrEmpty(tbDescripcion.Text) || string.IsNullOrEmpty(tbStock.Text) ||
                string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(cbUnidadMedida.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!int.TryParse(tbStock.Text.Trim(), out int stockParsed))
            {
                MessageBox.Show("El campo Stock debe ser un número entero válido.");
                return;
            }

            if (!decimal.TryParse(tbCosto.Text.Trim(), out decimal costoParsed))
            {
                MessageBox.Show("El campo Costo debe ser un número decimal válido.");
                return;
            }

            Almacen almacenActual = nAlmacen.ListarTodo2().FirstOrDefault(a => a.Id_Almacen == idAlmacen);
            if (almacenActual == null)
            {
                MessageBox.Show("El almacén asociado no existe. No se puede registrar el producto.", "Error de clave foránea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = new Producto
            {
                Nombre = tbNombre.Text.Trim(),
                Descripcion = tbDescripcion.Text.Trim(),
                Costo = costoParsed,
                Stock = stockParsed,
                Tipo_Producto = cbTipoProducto.Text.Trim(),
                Unidad_Medida = cbUnidadMedida.Text.Trim(),
                Id_Almacen = idAlmacen,  
                Fecha = DateTime.Now
            };

            string resultado = nProducto.Registrar(producto);
            MessageBox.Show(resultado);
            MostrarProductos(nProducto.ListarTodo(idAlmacen));
            LimpiarCampos();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.");
                return;
            }
            if (string.IsNullOrEmpty(tbCosto.Text) || string.IsNullOrEmpty(cbTipoProducto.Text)
                || string.IsNullOrEmpty(tbDescripcion.Text) || string.IsNullOrEmpty(tbStock.Text) ||
                    string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(cbUnidadMedida.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            int idProducto = Convert.ToInt32(dgProducto.SelectedRows[0].Cells["Codigo"].Value);

            if (!int.TryParse(tbStock.Text.Trim(), out int stockParsed))
            {
                MessageBox.Show("El campo Stock debe ser un número entero válido.");
                return;
            }
            if (!decimal.TryParse(tbCosto.Text.Trim(), out decimal costoParsed))
            {
                MessageBox.Show("El campo Costo debe ser un número decimal válido.");
                return;
            }
            Producto producto = new Producto
            {
                Nombre = tbNombre.Text.Trim(),
                Descripcion = tbDescripcion.Text.Trim(),
                Costo = costoParsed,
                Stock = stockParsed,
                Tipo_Producto = cbTipoProducto.Text.Trim(),
                Unidad_Medida = cbUnidadMedida.Text.Trim(),
                Id_Almacen = idAlmacen,
                Fecha = DateTime.Now
            };

            string resultado = nProducto.Modificar(producto);
            MessageBox.Show(resultado);
            dgProducto.DataSource = null;
            MostrarProductos(nProducto.ListarTodo(idAlmacen));
            lblContador.Text = dgProducto.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }
            int idProducto = Convert.ToInt32(dgProducto.SelectedRows[0].Cells["Codigo"].Value);
            string resultado = nProducto.Eliminar(idProducto);
            MessageBox.Show(resultado);
            dgProducto.DataSource = null;
            MostrarProductos(nProducto.ListarTodo(idAlmacen));
            lblContador.Text = dgProducto.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
            LimpiarCampos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Buscar unidad Medida
            if (string.IsNullOrEmpty(cbUnidaddeMedidaBuscar.Text) || cbAlmacenBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            string unidadMedida = cbUnidaddeMedidaBuscar.Text.Trim();
            dgProducto.DataSource = null;
            MostrarProductos(nProducto.BuscarPorTipoUnidadMedida(idAlmacen, unidadMedida));
            lblContador.Text = dgProducto.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();

        }

        private void btnBuscarPorCargo_Click(object sender, EventArgs e)
        {
            //Buscar por tipo de producto
            if (string.IsNullOrEmpty(cbProductoBuscar.Text) || cbAlmacenBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            string tipoProducto = cbProductoBuscar.Text.Trim();
            dgProducto.DataSource = null;
            MostrarProductos(nProducto.BuscarPorTipoProducto(idAlmacen, tipoProducto));
            lblContador.Text = dgProducto.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
        }

        private void btnBuscarPorAlmacen_Click(object sender, EventArgs e)
        {
            if(cbAlmacenBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un almacén.");
                return;
            }
            int idAlmacenBuscar = Convert.ToInt32(cbAlmacenBuscar.SelectedValue);
            dgProducto.DataSource = null;
            MostrarProductos(nProducto.BuscarPorAlmacen(idAlmacenBuscar));
            lblContador.Text = dgProducto.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();
        }

        private void btnMostrarTodo3_Click(object sender, EventArgs e)
        {
            MostrarProductos(nProducto.ListarTodo(idAlmacen));
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            MostrarProductos(nProducto.ListarTodo(idAlmacen));

        }

        private void btnMostrarTodo2_Click(object sender, EventArgs e)
        {
            MostrarProductos(nProducto.ListarTodo(idAlmacen));

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgTrabajadores_SelectionChanged(object sender, EventArgs e)
        {
            if(dgProducto.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgProducto.SelectedRows[0];
                tbNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                tbDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                tbCosto.Text = selectedRow.Cells["Costo"].Value.ToString();
                tbStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                cbTipoProducto.Text = selectedRow.Cells["Tipo_Producto"].Value.ToString();
                cbUnidadMedida.Text = selectedRow.Cells["Unidad_Medida"].Value.ToString();
            }
        }
    }
}
