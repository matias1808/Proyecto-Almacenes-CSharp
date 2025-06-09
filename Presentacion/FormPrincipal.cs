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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlmacenGeneral_Click(object sender, EventArgs e)
        {
            FormAlmacenGeneral formAlmacenGeneral = new FormAlmacenGeneral();
            formAlmacenGeneral.Show();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            FormArea formArea = new FormArea();
            formArea.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAreaProducto_Click(object sender, EventArgs e)
        {
            FormArea_Producto formArea_Producto = new FormArea_Producto();
            formArea_Producto.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
