namespace Presentacion
{
    partial class FormTrabajador
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbAlmacenBuscar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarTodo2 = new System.Windows.Forms.Button();
            this.btnBuscarPorAlmacen = new System.Windows.Forms.Button();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCargoBuscar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnBuscarPorCargo = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgTrabajadores = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(74, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 26);
            this.label9.TabIndex = 74;
            this.label9.Text = "Solo usar cuando se requiera el cambio \r\nde almacen - modificar\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbAlmacenBuscar
            // 
            this.cbAlmacenBuscar.FormattingEnabled = true;
            this.cbAlmacenBuscar.Items.AddRange(new object[] {
            "Repuestos",
            "Suministros",
            "Economato",
            "Materia Prima",
            "Productos Terminados",
            "Envases y Embalajes"});
            this.cbAlmacenBuscar.Location = new System.Drawing.Point(421, 84);
            this.cbAlmacenBuscar.Name = "cbAlmacenBuscar";
            this.cbAlmacenBuscar.Size = new System.Drawing.Size(166, 21);
            this.cbAlmacenBuscar.TabIndex = 73;
            this.cbAlmacenBuscar.SelectedIndexChanged += new System.EventHandler(this.cbAlmacenBuscar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Almacen:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnMostrarTodo2
            // 
            this.btnMostrarTodo2.Location = new System.Drawing.Point(687, 84);
            this.btnMostrarTodo2.Name = "btnMostrarTodo2";
            this.btnMostrarTodo2.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo2.TabIndex = 71;
            this.btnMostrarTodo2.Text = "Mostrar Todo";
            this.btnMostrarTodo2.UseVisualStyleBackColor = true;
            this.btnMostrarTodo2.Click += new System.EventHandler(this.btnMostrarTodo2_Click);
            // 
            // btnBuscarPorAlmacen
            // 
            this.btnBuscarPorAlmacen.Location = new System.Drawing.Point(593, 83);
            this.btnBuscarPorAlmacen.Name = "btnBuscarPorAlmacen";
            this.btnBuscarPorAlmacen.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorAlmacen.TabIndex = 70;
            this.btnBuscarPorAlmacen.Text = "Buscar";
            this.btnBuscarPorAlmacen.UseVisualStyleBackColor = true;
            this.btnBuscarPorAlmacen.Click += new System.EventHandler(this.btnBuscarPorAlmacen_Click);
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(77, 409);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(229, 21);
            this.cbAlmacen.TabIndex = 69;
            this.cbAlmacen.SelectedIndexChanged += new System.EventHandler(this.cbAlmacen_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Almacen: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbCargoBuscar
            // 
            this.cbCargoBuscar.FormattingEnabled = true;
            this.cbCargoBuscar.Items.AddRange(new object[] {
            "Jefe de Almacenes",
            "Encargado Asistente",
            "Almaceneros"});
            this.cbCargoBuscar.Location = new System.Drawing.Point(448, 40);
            this.cbCargoBuscar.Name = "cbCargoBuscar";
            this.cbCargoBuscar.Size = new System.Drawing.Size(139, 21);
            this.cbCargoBuscar.TabIndex = 67;
            this.cbCargoBuscar.SelectedIndexChanged += new System.EventHandler(this.cbCargoBuscar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Tipo Cargo: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Jefe de Almacenes",
            "Encargado Asistente",
            "Almaceneros"});
            this.cbCargo.Location = new System.Drawing.Point(77, 284);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(229, 21);
            this.cbCargo.TabIndex = 65;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(687, 40);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo.TabIndex = 64;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnBuscarPorCargo
            // 
            this.btnBuscarPorCargo.Location = new System.Drawing.Point(593, 39);
            this.btnBuscarPorCargo.Name = "btnBuscarPorCargo";
            this.btnBuscarPorCargo.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorCargo.TabIndex = 63;
            this.btnBuscarPorCargo.Text = "Buscar";
            this.btnBuscarPorCargo.UseVisualStyleBackColor = true;
            this.btnBuscarPorCargo.Click += new System.EventHandler(this.btnBuscarPorCargo_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(69, 106);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(237, 20);
            this.tbNombre.TabIndex = 62;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Nombre:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(77, 149);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(229, 20);
            this.tbApellido.TabIndex = 59;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Contador de trabajadores:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(511, 490);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 57;
            this.lblContador.Text = "0";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(700, 485);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgTrabajadores
            // 
            this.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrabajadores.Location = new System.Drawing.Point(367, 127);
            this.dgTrabajadores.Name = "dgTrabajadores";
            this.dgTrabajadores.Size = new System.Drawing.Size(408, 341);
            this.dgTrabajadores.TabIndex = 55;
            this.dgTrabajadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTrabajadores_CellContentClick);
            this.dgTrabajadores.SelectionChanged += new System.EventHandler(this.dgTrabajadores_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(116, 523);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 22);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(190, 465);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 25);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(36, 465);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 25);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "DNI: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 42);
            this.label1.TabIndex = 49;
            this.label1.Text = "Trabajador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(77, 240);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(229, 20);
            this.tbTelefono.TabIndex = 76;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Teléfono";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Cargo:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(77, 330);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(229, 20);
            this.tbCorreo.TabIndex = 80;
            this.tbCorreo.TextChanged += new System.EventHandler(this.tbCorreo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Correo:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(77, 195);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(229, 20);
            this.tbDNI.TabIndex = 78;
            this.tbDNI.TextChanged += new System.EventHandler(this.tbDNI_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "-";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // FormTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAlmacenBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMostrarTodo2);
            this.Controls.Add(this.btnBuscarPorAlmacen);
            this.Controls.Add(this.cbAlmacen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCargoBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscarPorCargo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgTrabajadores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTrabajador";
            this.Text = "Trabajador";
            ((System.ComponentModel.ISupportInitialize)(this.dgTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAlmacenBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMostrarTodo2;
        private System.Windows.Forms.Button btnBuscarPorAlmacen;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCargoBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnBuscarPorCargo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgTrabajadores;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label14;
    }
}