namespace Presentacion
{
    partial class FormArea_Producto
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
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbAreaBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnMostrarTodo2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProductoBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscarArea = new System.Windows.Forms.Button();
            this.btnMostraTodo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSAlir = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(50, 87);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(252, 21);
            this.cbArea.TabIndex = 125;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Items.AddRange(new object[] {
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
            this.cbProducto.Location = new System.Drawing.Point(71, 131);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(231, 21);
            this.cbProducto.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 42);
            this.label3.TabIndex = 122;
            this.label3.Text = "Área  - Producto";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(73, 173);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(229, 20);
            this.tbCantidad.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Cantidad:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(101, 223);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 25);
            this.btnRegistrar.TabIndex = 122;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(101, 272);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 22);
            this.btnEliminar.TabIndex = 122;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 161);
            this.dataGridView1.TabIndex = 122;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cbAreaBuscar
            // 
            this.cbAreaBuscar.FormattingEnabled = true;
            this.cbAreaBuscar.Items.AddRange(new object[] {
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
            this.cbAreaBuscar.Location = new System.Drawing.Point(435, 12);
            this.cbAreaBuscar.Name = "cbAreaBuscar";
            this.cbAreaBuscar.Size = new System.Drawing.Size(117, 21);
            this.cbAreaBuscar.TabIndex = 129;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(558, 51);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarProducto.TabIndex = 122;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnMostrarTodo2
            // 
            this.btnMostrarTodo2.Location = new System.Drawing.Point(652, 52);
            this.btnMostrarTodo2.Name = "btnMostrarTodo2";
            this.btnMostrarTodo2.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo2.TabIndex = 123;
            this.btnMostrarTodo2.Text = "Mostrar Todo";
            this.btnMostrarTodo2.UseVisualStyleBackColor = true;
            this.btnMostrarTodo2.Click += new System.EventHandler(this.btnMostrarTodo2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "Tipo Producto: ";
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
            this.cbProductoBuscar.Location = new System.Drawing.Point(413, 52);
            this.cbProductoBuscar.Name = "cbProductoBuscar";
            this.cbProductoBuscar.Size = new System.Drawing.Size(139, 21);
            this.cbProductoBuscar.TabIndex = 125;
            // 
            // btnBuscarArea
            // 
            this.btnBuscarArea.Location = new System.Drawing.Point(558, 11);
            this.btnBuscarArea.Name = "btnBuscarArea";
            this.btnBuscarArea.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarArea.TabIndex = 126;
            this.btnBuscarArea.Text = "Buscar";
            this.btnBuscarArea.UseVisualStyleBackColor = true;
            this.btnBuscarArea.Click += new System.EventHandler(this.btnBuscarArea_Click);
            // 
            // btnMostraTodo
            // 
            this.btnMostraTodo.Location = new System.Drawing.Point(652, 12);
            this.btnMostraTodo.Name = "btnMostraTodo";
            this.btnMostraTodo.Size = new System.Drawing.Size(88, 25);
            this.btnMostraTodo.TabIndex = 127;
            this.btnMostraTodo.Text = "Mostrar Todo";
            this.btnMostraTodo.UseVisualStyleBackColor = true;
            this.btnMostraTodo.Click += new System.EventHandler(this.btnMostraTodo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Unidad de Medida: ";
            // 
            // btnSAlir
            // 
            this.btnSAlir.Location = new System.Drawing.Point(665, 271);
            this.btnSAlir.Name = "btnSAlir";
            this.btnSAlir.Size = new System.Drawing.Size(75, 23);
            this.btnSAlir.TabIndex = 122;
            this.btnSAlir.Text = "Salir";
            this.btnSAlir.UseVisualStyleBackColor = true;
            this.btnSAlir.Click += new System.EventHandler(this.btnSAlir_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(476, 276);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 123;
            this.lblContador.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Contador de productos:";
            // 
            // FormArea_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 321);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAreaBuscar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSAlir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostraTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarArea);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbProductoBuscar);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMostrarTodo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label1);
            this.Name = "FormArea_Producto";
            this.Text = "FormArea_Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbAreaBuscar;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnMostrarTodo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProductoBuscar;
        private System.Windows.Forms.Button btnBuscarArea;
        private System.Windows.Forms.Button btnMostraTodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSAlir;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label8;
    }
}