namespace Presentacion
{
    partial class FormAlmacen
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
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnBuscarPorTipoAlmacen = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerTrabajadores = new System.Windows.Forms.Button();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgAlmacen = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoAlmacen = new System.Windows.Forms.ComboBox();
            this.cbTipoAlmacenBuscar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAlmacenGeneral = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAlmacenGeneralBuscar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarTodo2 = new System.Windows.Forms.Button();
            this.btnBuscarPorAlmacenGeneral = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(688, 48);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo.TabIndex = 38;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnBuscarPorTipoAlmacen
            // 
            this.btnBuscarPorTipoAlmacen.Location = new System.Drawing.Point(594, 47);
            this.btnBuscarPorTipoAlmacen.Name = "btnBuscarPorTipoAlmacen";
            this.btnBuscarPorTipoAlmacen.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorTipoAlmacen.TabIndex = 37;
            this.btnBuscarPorTipoAlmacen.Text = "Buscar";
            this.btnBuscarPorTipoAlmacen.UseVisualStyleBackColor = true;
            this.btnBuscarPorTipoAlmacen.Click += new System.EventHandler(this.btnBuscarPorTipoAlmacen_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(70, 108);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(237, 20);
            this.tbNombre.TabIndex = 34;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nombre:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnVerTrabajadores
            // 
            this.btnVerTrabajadores.Location = new System.Drawing.Point(70, 358);
            this.btnVerTrabajadores.Name = "btnVerTrabajadores";
            this.btnVerTrabajadores.Size = new System.Drawing.Size(102, 22);
            this.btnVerTrabajadores.TabIndex = 32;
            this.btnVerTrabajadores.Text = "Ver Trabajadores";
            this.btnVerTrabajadores.UseVisualStyleBackColor = true;
            this.btnVerTrabajadores.Click += new System.EventHandler(this.btnVerTrabajadores_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(78, 151);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(229, 20);
            this.tbTelefono.TabIndex = 30;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Contador de almacenes:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(548, 357);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 28;
            this.lblContador.Text = "0";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(701, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgAlmacen
            // 
            this.dgAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlmacen.Location = new System.Drawing.Point(368, 135);
            this.dgAlmacen.Name = "dgAlmacen";
            this.dgAlmacen.Size = new System.Drawing.Size(408, 203);
            this.dgAlmacen.TabIndex = 26;
            this.dgAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlmacen_CellContentClick);
            this.dgAlmacen.SelectionChanged += new System.EventHandler(this.dgAlmacenGeneral_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(252, 316);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 22);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(129, 313);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 25);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(20, 313);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 25);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo Almacén: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Teléfono: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Almacen ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbTipoAlmacen
            // 
            this.cbTipoAlmacen.FormattingEnabled = true;
            this.cbTipoAlmacen.Items.AddRange(new object[] {
            "Repuestos",
            "Suministros",
            "Economato",
            "Materia Prima",
            "Productos Terminados",
            "Envases y Embalajes"});
            this.cbTipoAlmacen.Location = new System.Drawing.Point(101, 197);
            this.cbTipoAlmacen.Name = "cbTipoAlmacen";
            this.cbTipoAlmacen.Size = new System.Drawing.Size(206, 21);
            this.cbTipoAlmacen.TabIndex = 39;
            this.cbTipoAlmacen.SelectedIndexChanged += new System.EventHandler(this.cbTipoAlmacen_SelectedIndexChanged);
            // 
            // cbTipoAlmacenBuscar
            // 
            this.cbTipoAlmacenBuscar.FormattingEnabled = true;
            this.cbTipoAlmacenBuscar.Items.AddRange(new object[] {
            "Repuestos",
            "Suministros",
            "Economato",
            "Materia Prima",
            "Productos Terminados",
            "Envases y Embalajes"});
            this.cbTipoAlmacenBuscar.Location = new System.Drawing.Point(449, 48);
            this.cbTipoAlmacenBuscar.Name = "cbTipoAlmacenBuscar";
            this.cbTipoAlmacenBuscar.Size = new System.Drawing.Size(139, 21);
            this.cbTipoAlmacenBuscar.TabIndex = 41;
            this.cbTipoAlmacenBuscar.SelectedIndexChanged += new System.EventHandler(this.cbTipoAlmacenBuscar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tipo Almacén: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbAlmacenGeneral
            // 
            this.cbAlmacenGeneral.FormattingEnabled = true;
            this.cbAlmacenGeneral.Location = new System.Drawing.Point(117, 271);
            this.cbAlmacenGeneral.Name = "cbAlmacenGeneral";
            this.cbAlmacenGeneral.Size = new System.Drawing.Size(190, 21);
            this.cbAlmacenGeneral.TabIndex = 43;
            this.cbAlmacenGeneral.SelectedIndexChanged += new System.EventHandler(this.cbAlmacenGeneral_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Almacen General: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbAlmacenGeneralBuscar
            // 
            this.cbAlmacenGeneralBuscar.FormattingEnabled = true;
            this.cbAlmacenGeneralBuscar.Items.AddRange(new object[] {
            "Repuestos",
            "Suministros",
            "Economato",
            "Materia Prima",
            "Productos Terminados",
            "Envases y Embalajes"});
            this.cbAlmacenGeneralBuscar.Location = new System.Drawing.Point(462, 92);
            this.cbAlmacenGeneralBuscar.Name = "cbAlmacenGeneralBuscar";
            this.cbAlmacenGeneralBuscar.Size = new System.Drawing.Size(126, 21);
            this.cbAlmacenGeneralBuscar.TabIndex = 47;
            this.cbAlmacenGeneralBuscar.SelectedIndexChanged += new System.EventHandler(this.cbAlmacenGeneralBuscar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Almacen General:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnMostrarTodo2
            // 
            this.btnMostrarTodo2.Location = new System.Drawing.Point(688, 92);
            this.btnMostrarTodo2.Name = "btnMostrarTodo2";
            this.btnMostrarTodo2.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo2.TabIndex = 45;
            this.btnMostrarTodo2.Text = "Mostrar Todo";
            this.btnMostrarTodo2.UseVisualStyleBackColor = true;
            this.btnMostrarTodo2.Click += new System.EventHandler(this.btnMostrarTodo2_Click);
            // 
            // btnBuscarPorAlmacenGeneral
            // 
            this.btnBuscarPorAlmacenGeneral.Location = new System.Drawing.Point(594, 91);
            this.btnBuscarPorAlmacenGeneral.Name = "btnBuscarPorAlmacenGeneral";
            this.btnBuscarPorAlmacenGeneral.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorAlmacenGeneral.TabIndex = 44;
            this.btnBuscarPorAlmacenGeneral.Text = "Buscar";
            this.btnBuscarPorAlmacenGeneral.UseVisualStyleBackColor = true;
            this.btnBuscarPorAlmacenGeneral.Click += new System.EventHandler(this.btnBuscarPorAlmacenGeneral_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(75, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 26);
            this.label9.TabIndex = 48;
            this.label9.Text = "Solo usar cuando se requiera el cambio \r\nde almacen general - modificar\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 22);
            this.button1.TabIndex = 50;
            this.button1.Text = "Ver Productos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAlmacenGeneralBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMostrarTodo2);
            this.Controls.Add(this.btnBuscarPorAlmacenGeneral);
            this.Controls.Add(this.cbAlmacenGeneral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipoAlmacenBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipoAlmacen);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscarPorTipoAlmacen);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerTrabajadores);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgAlmacen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlmacen";
            this.Text = "Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnBuscarPorTipoAlmacen;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerTrabajadores;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgAlmacen;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoAlmacen;
        private System.Windows.Forms.ComboBox cbTipoAlmacenBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAlmacenGeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAlmacenGeneralBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMostrarTodo2;
        private System.Windows.Forms.Button btnBuscarPorAlmacenGeneral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}