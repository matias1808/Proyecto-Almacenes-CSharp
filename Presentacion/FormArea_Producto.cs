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
using System.Xml.Serialization;

namespace Presentacion
{
    public partial class FormArea_Producto : Form
    {
        private NProducto nProducto = new NProducto();
        private NArea nArea = new NArea();
        private NArea_Producto nArea_Producto = new NArea_Producto();


        public FormArea_Producto()
        {
            InitializeComponent();
            MostrarAreaProducto(nArea_Producto.ListarTodo());
            MostrarArea(nArea.ListarTodo());
            MostrarArea__2(nArea.ListarTodo());
            MostrarProducto(nProducto.ListarTodo2());
            MostrarProducto__2(nProducto.ListarTodo2());
        }

        private void MostrarAreaProducto(List<Area_Producto> area_Productos)
        {
            if(area_Productos.Count == 0)
            {
                return;
            }
            else
            {
                dataGridView1.DataSource = area_Productos;
                lblContador.Text =  area_Productos.Count.ToString();
            }
        }

        private void MostrarArea(List<Area_Operativa_Produccion> areas)
        {
            cbArea.DataSource = null;
            if (areas.Count == 0)
            {
                return;
            }
            else
            {
                cbArea.DataSource = areas;
                cbArea.DisplayMember = "Seccion";
                cbArea.ValueMember = "Id_Area";
            }

            cbArea.SelectedIndex = -1;
        }

        private void MostrarArea__2(List<Area_Operativa_Produccion> areas)
        {
            cbAreaBuscar.DataSource = null;
            if (areas.Count == 0)
            {
                return;
            }
            else
            {
                cbAreaBuscar.DataSource = areas;
                cbAreaBuscar.DisplayMember = "Seccion";
                cbAreaBuscar.ValueMember = "Id_Area";
            }

            cbAreaBuscar.SelectedIndex = -1;
        }

        private void MostrarProducto(List<Producto> productos)
        {
            cbProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                cbProducto.DataSource = productos;
                cbProducto.DisplayMember = "Nombre";
                cbProducto.ValueMember = "Codigo";
            }

            cbProducto.SelectedIndex = -1;
        }

        private void MostrarProducto__2(List<Producto> productos)
        {
            cbProductoBuscar.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                cbProductoBuscar.DataSource = productos;
                cbProductoBuscar.DisplayMember = "Nombre";
                cbProductoBuscar.ValueMember = "Codigo";
            }

            cbProductoBuscar.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbArea.SelectedIndex == -1 || cbProducto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(tbCantidad.Text))
            {
                MessageBox.Show("Debe seleccionar un área, un producto y una cantidad.");
                return;
            }

            if (!int.TryParse(tbCantidad.Text.Trim(), out int cantidadSeleccionada) || cantidadSeleccionada <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero positivo.");
                return;
            }

            int idProducto = Convert.ToInt32(cbProducto.SelectedValue);
            Producto producto = nProducto.BuscarPorId(idProducto);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            if (cantidadSeleccionada > producto.Stock)
            {
                MessageBox.Show($"No hay suficiente stock disponible. Stock actual: {producto.Stock}");
                return;
            }

            Area_Producto area_Producto = new Area_Producto
            {
                Id_Area = Convert.ToInt32(cbArea.SelectedValue),
                Codigo = idProducto,
                Cantidad = cantidadSeleccionada,
                Fecha = DateTime.Now
            };

            string mensaje = nArea_Producto.Asignar(area_Producto);

            
            producto.Stock -= cantidadSeleccionada;
            nProducto.Modificar(producto);

            MessageBox.Show(mensaje);
            MostrarAreaProducto(nArea_Producto.ListarTodo());

            cbArea.SelectedIndex = -1;
            cbProducto.SelectedIndex = -1;
            tbCantidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar.");
                return;
            }

            int numeroDocumento = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Numero_Documento"].Value);
            int cantidadADevolver = Convert.ToInt32(tbCantidad.Text);
            int idProducto = Convert.ToInt32(cbProducto.SelectedValue);

            string mensaje = nArea_Producto.Eliminar(numeroDocumento);

            Producto producto = nProducto.BuscarPorId(idProducto);
            if (producto != null)
            {
                producto.Stock += cantidadADevolver;
                nProducto.Modificar(producto);
            }

            MessageBox.Show(mensaje);
            MostrarAreaProducto(nArea_Producto.ListarTodo());

            cbArea.SelectedIndex = -1;
            cbProducto.SelectedIndex = -1;
            tbCantidad.Clear();
        }


        private void btnBuscarArea_Click(object sender, EventArgs e)
        {
            if(cbAreaBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un área para buscar");
                return;
            }
            int idArea = Convert.ToInt32(cbAreaBuscar.SelectedValue);
            dataGridView1.DataSource = null;
            MostrarAreaProducto(nArea_Producto.BuscarPorIdArea(idArea));
            lblContador.Text = nArea_Producto.BuscarPorIdArea(idArea).Count.ToString();
            cbArea.SelectedIndex = -1;
            cbProducto.SelectedIndex = -1;
            tbCantidad.Clear();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if(cbProductoBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto para buscar");
                return;
            }
            int idProducto = Convert.ToInt32(cbProductoBuscar.SelectedValue);
            dataGridView1.DataSource = null;
            MostrarAreaProducto(nArea_Producto.BuscarPorIdProducto(idProducto));
            lblContador.Text = nArea_Producto.BuscarPorIdProducto(idProducto).Count.ToString();
            cbArea.SelectedIndex = -1;
            cbProducto.SelectedIndex = -1;
            tbCantidad.Clear();
        }

        private void btnMostraTodo_Click(object sender, EventArgs e)
        {
            MostrarAreaProducto(nArea_Producto.ListarTodo());
        }

        private void btnMostrarTodo2_Click(object sender, EventArgs e)
        {
            MostrarAreaProducto(nArea_Producto.ListarTodo());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSAlir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                cbArea.SelectedValue = row.Cells["Id_Area"].Value;
                cbProducto.SelectedValue = row.Cells["Codigo"].Value;
                tbCantidad.Text = row.Cells["Cantidad"].Value.ToString();
            }
            else
            {
                cbArea.SelectedIndex = -1;
                cbProducto.SelectedIndex = -1;
                tbCantidad.Clear();
            }
    }
}
}