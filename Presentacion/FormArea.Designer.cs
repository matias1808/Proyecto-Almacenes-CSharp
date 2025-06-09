namespace Presentacion
{
    partial class FormArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSeccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerAsignacionAreaProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgAreaOperativaProduccion = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnBuscarPorSeccion = new System.Windows.Forms.Button();
            this.tbBuscarSeccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAreaOperativaProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSeccion
            // 
            this.tbSeccion.Location = new System.Drawing.Point(71, 84);
            this.tbSeccion.Name = "tbSeccion";
            this.tbSeccion.Size = new System.Drawing.Size(237, 20);
            this.tbSeccion.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sección:";
            // 
            // btnVerAsignacionAreaProducto
            // 
            this.btnVerAsignacionAreaProducto.Location = new System.Drawing.Point(99, 236);
            this.btnVerAsignacionAreaProducto.Name = "btnVerAsignacionAreaProducto";
            this.btnVerAsignacionAreaProducto.Size = new System.Drawing.Size(169, 23);
            this.btnVerAsignacionAreaProducto.TabIndex = 28;
            this.btnVerAsignacionAreaProducto.Text = "Ver Asignación Area y Producto";
            this.btnVerAsignacionAreaProducto.UseVisualStyleBackColor = true;
            this.btnVerAsignacionAreaProducto.Click += new System.EventHandler(this.btnVerAsignacionAreaProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contador de áreas operativas de producción:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(594, 311);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 24;
            this.lblContador.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(702, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgAreaOperativaProduccion
            // 
            this.dgAreaOperativaProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAreaOperativaProduccion.Location = new System.Drawing.Point(369, 117);
            this.dgAreaOperativaProduccion.Name = "dgAreaOperativaProduccion";
            this.dgAreaOperativaProduccion.Size = new System.Drawing.Size(408, 178);
            this.dgAreaOperativaProduccion.TabIndex = 22;
            this.dgAreaOperativaProduccion.SelectionChanged += new System.EventHandler(this.dgAreaOperativaProduccion_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(99, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(169, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(99, 182);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(169, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(99, 132);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(169, 23);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Área Operativa de Producción ";
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(689, 78);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo.TabIndex = 34;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnBuscarPorSeccion
            // 
            this.btnBuscarPorSeccion.Location = new System.Drawing.Point(581, 78);
            this.btnBuscarPorSeccion.Name = "btnBuscarPorSeccion";
            this.btnBuscarPorSeccion.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorSeccion.TabIndex = 33;
            this.btnBuscarPorSeccion.Text = "Buscar";
            this.btnBuscarPorSeccion.UseVisualStyleBackColor = true;
            this.btnBuscarPorSeccion.Click += new System.EventHandler(this.btnBuscarPorSeccion_Click);
            // 
            // tbBuscarSeccion
            // 
            this.tbBuscarSeccion.Location = new System.Drawing.Point(422, 81);
            this.tbBuscarSeccion.Name = "tbBuscarSeccion";
            this.tbBuscarSeccion.Size = new System.Drawing.Size(140, 20);
            this.tbBuscarSeccion.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sección: ";
            // 
            // FormArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscarPorSeccion);
            this.Controls.Add(this.tbBuscarSeccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSeccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerAsignacionAreaProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgAreaOperativaProduccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "FormArea";
            this.Text = "FormArea";
            ((System.ComponentModel.ISupportInitialize)(this.dgAreaOperativaProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSeccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerAsignacionAreaProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgAreaOperativaProduccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnBuscarPorSeccion;
        private System.Windows.Forms.TextBox tbBuscarSeccion;
        private System.Windows.Forms.Label label6;
    }
}