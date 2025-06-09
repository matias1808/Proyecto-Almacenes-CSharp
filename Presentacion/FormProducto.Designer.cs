namespace Presentacion
{
    partial class FormProducto
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
            this.label14 = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAlmacenBuscar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMostrarTodo2 = new System.Windows.Forms.Button();
            this.btnBuscarPorAlmacen = new System.Windows.Forms.Button();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProductoBuscar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnBuscarPorCargo = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.cbUnidaddeMedidaBuscar = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMostrarTodo3 = new System.Windows.Forms.Button();
            this.btnBuscarUnidadDeMedida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 116;
            this.label14.Text = "-";
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(67, 325);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(246, 20);
            this.tbStock.TabIndex = 114;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 113;
            this.label12.Text = "Stock:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(95, 190);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(218, 20);
            this.tbDescripcion.TabIndex = 112;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Tipo de Producto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Unidad de Medida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(81, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 26);
            this.label9.TabIndex = 108;
            this.label9.Text = "Solo usar cuando se requiera el cambio \r\nde almacen - modificar\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbAlmacenBuscar.Location = new System.Drawing.Point(428, 114);
            this.cbAlmacenBuscar.Name = "cbAlmacenBuscar";
            this.cbAlmacenBuscar.Size = new System.Drawing.Size(166, 21);
            this.cbAlmacenBuscar.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 106;
            this.label8.Text = "Almacen:";
            // 
            // btnMostrarTodo2
            // 
            this.btnMostrarTodo2.Location = new System.Drawing.Point(694, 114);
            this.btnMostrarTodo2.Name = "btnMostrarTodo2";
            this.btnMostrarTodo2.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo2.TabIndex = 105;
            this.btnMostrarTodo2.Text = "Mostrar Todo";
            this.btnMostrarTodo2.UseVisualStyleBackColor = true;
            this.btnMostrarTodo2.Click += new System.EventHandler(this.btnMostrarTodo2_Click);
            // 
            // btnBuscarPorAlmacen
            // 
            this.btnBuscarPorAlmacen.Location = new System.Drawing.Point(600, 113);
            this.btnBuscarPorAlmacen.Name = "btnBuscarPorAlmacen";
            this.btnBuscarPorAlmacen.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorAlmacen.TabIndex = 104;
            this.btnBuscarPorAlmacen.Text = "Buscar";
            this.btnBuscarPorAlmacen.UseVisualStyleBackColor = true;
            this.btnBuscarPorAlmacen.Click += new System.EventHandler(this.btnBuscarPorAlmacen_Click);
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(84, 404);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(229, 21);
            this.cbAlmacen.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Almacen: ";
            // 
            // cbProductoBuscar
            // 
            this.cbProductoBuscar.FormattingEnabled = true;
            this.cbProductoBuscar.Items.AddRange(new object[] {
            "Materia Prima Metálica",
            "Materia Prima Plástica",
            "Materia Prima Textil",
            "Repuestos Eléctricos",
            "Repuestos Electrónicos",
            "Repuestos Mecánicos",
            "Componentes Hidráulicos",
            "Componentes Neumáticos",
            "Piezas de Maquinaria",
            "Accesorios Industriales",
            "Lubricantes y Fluidos",
            "Tornillería y Fijaciones",
            "Cables y Conectores",
            "Filtros y Sellos",
            "Rodamientos y Chumaceras",
            "Herramientas de Corte",
            "Material de Empaque",
            "Pinturas e Insumos de Acabado",
            "Instrumentos de Medición",
            "Equipos de Protección Personal"});
            this.cbProductoBuscar.Location = new System.Drawing.Point(455, 70);
            this.cbProductoBuscar.Name = "cbProductoBuscar";
            this.cbProductoBuscar.Size = new System.Drawing.Size(139, 21);
            this.cbProductoBuscar.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Tipo Producto: ";
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Items.AddRange(new object[] {
            "Materia Prima Metálica",
            "Materia Prima Plástica",
            "Materia Prima Textil",
            "Repuestos Eléctricos",
            "Repuestos Electrónicos",
            "Repuestos Mecánicos",
            "Componentes Hidráulicos",
            "Componentes Neumáticos",
            "Piezas de Maquinaria",
            "Accesorios Industriales",
            "Lubricantes y Fluidos",
            "Tornillería y Fijaciones",
            "Cables y Conectores",
            "Filtros y Sellos",
            "Rodamientos y Chumaceras",
            "Herramientas de Corte",
            "Material de Empaque",
            "Pinturas e Insumos de Acabado",
            "Instrumentos de Medición",
            "Equipos de Protección Personal"});
            this.cbTipoProducto.Location = new System.Drawing.Point(121, 279);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(192, 21);
            this.cbTipoProducto.TabIndex = 99;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(694, 70);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo.TabIndex = 98;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnBuscarPorCargo
            // 
            this.btnBuscarPorCargo.Location = new System.Drawing.Point(600, 69);
            this.btnBuscarPorCargo.Name = "btnBuscarPorCargo";
            this.btnBuscarPorCargo.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorCargo.TabIndex = 97;
            this.btnBuscarPorCargo.Text = "Buscar";
            this.btnBuscarPorCargo.UseVisualStyleBackColor = true;
            this.btnBuscarPorCargo.Click += new System.EventHandler(this.btnBuscarPorCargo_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(76, 101);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(237, 20);
            this.tbNombre.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Nombre:";
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(84, 144);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(229, 20);
            this.tbCosto.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Contador de productos:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(518, 485);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 92;
            this.lblContador.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(707, 480);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 91;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgProducto
            // 
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Location = new System.Drawing.Point(374, 159);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.Size = new System.Drawing.Size(408, 304);
            this.dgProducto.TabIndex = 90;
            this.dgProducto.SelectionChanged += new System.EventHandler(this.dgTrabajadores_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(123, 518);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 22);
            this.btnEliminar.TabIndex = 89;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(197, 460);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 25);
            this.btnModificar.TabIndex = 88;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(43, 460);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 25);
            this.btnRegistrar.TabIndex = 87;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Costo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 42);
            this.label1.TabIndex = 84;
            this.label1.Text = "Producto";
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Items.AddRange(new object[] {
            "Unidad",
            "Caja",
            "Paquete",
            "Bolsa",
            "Litro",
            "Mililitro",
            "Metro",
            "Centímetro",
            "Milímetro",
            "Metro Cuadrado",
            "Metro Cúbico",
            "Kilogramo",
            "Gramo",
            "Tonelada",
            "Pieza",
            "Juego",
            "Par",
            "Galón",
            "Tambor",
            "Rollo",
            "Bobina",
            "Frasco",
            "Tubo",
            "Balde",
            "Saco"});
            this.cbUnidadMedida.Location = new System.Drawing.Point(123, 235);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(190, 21);
            this.cbUnidadMedida.TabIndex = 117;
            // 
            // cbUnidaddeMedidaBuscar
            // 
            this.cbUnidaddeMedidaBuscar.FormattingEnabled = true;
            this.cbUnidaddeMedidaBuscar.Items.AddRange(new object[] {
            "Unidad",
            "Caja",
            "Paquete",
            "Bolsa",
            "Litro",
            "Mililitro",
            "Metro",
            "Centímetro",
            "Milímetro",
            "Metro Cuadrado",
            "Metro Cúbico",
            "Kilogramo",
            "Gramo",
            "Tonelada",
            "Pieza",
            "Juego",
            "Par",
            "Galón",
            "Tambor",
            "Rollo",
            "Bobina",
            "Frasco",
            "Tubo",
            "Balde",
            "Saco"});
            this.cbUnidaddeMedidaBuscar.Location = new System.Drawing.Point(477, 30);
            this.cbUnidaddeMedidaBuscar.Name = "cbUnidaddeMedidaBuscar";
            this.cbUnidaddeMedidaBuscar.Size = new System.Drawing.Size(117, 21);
            this.cbUnidaddeMedidaBuscar.TabIndex = 121;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 120;
            this.label13.Text = "Unidad de Medida: ";
            // 
            // btnMostrarTodo3
            // 
            this.btnMostrarTodo3.Location = new System.Drawing.Point(694, 30);
            this.btnMostrarTodo3.Name = "btnMostrarTodo3";
            this.btnMostrarTodo3.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo3.TabIndex = 119;
            this.btnMostrarTodo3.Text = "Mostrar Todo";
            this.btnMostrarTodo3.UseVisualStyleBackColor = true;
            this.btnMostrarTodo3.Click += new System.EventHandler(this.btnMostrarTodo3_Click);
            // 
            // btnBuscarUnidadDeMedida
            // 
            this.btnBuscarUnidadDeMedida.Location = new System.Drawing.Point(600, 29);
            this.btnBuscarUnidadDeMedida.Name = "btnBuscarUnidadDeMedida";
            this.btnBuscarUnidadDeMedida.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarUnidadDeMedida.TabIndex = 118;
            this.btnBuscarUnidadDeMedida.Text = "Buscar";
            this.btnBuscarUnidadDeMedida.UseVisualStyleBackColor = true;
            this.btnBuscarUnidadDeMedida.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.cbUnidaddeMedidaBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnMostrarTodo3);
            this.Controls.Add(this.btnBuscarUnidadDeMedida);
            this.Controls.Add(this.cbUnidadMedida);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAlmacenBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMostrarTodo2);
            this.Controls.Add(this.btnBuscarPorAlmacen);
            this.Controls.Add(this.cbAlmacen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProductoBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipoProducto);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscarPorCargo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAlmacenBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMostrarTodo2;
        private System.Windows.Forms.Button btnBuscarPorAlmacen;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbProductoBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoProducto;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnBuscarPorCargo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
        private System.Windows.Forms.ComboBox cbUnidaddeMedidaBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMostrarTodo3;
        private System.Windows.Forms.Button btnBuscarUnidadDeMedida;
    }
}