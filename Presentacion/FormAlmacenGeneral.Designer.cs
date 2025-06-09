namespace Presentacion
{
    partial class FormAlmacenGeneral
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgAlmacenGeneral = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAreaRecepcion = new System.Windows.Forms.TextBox();
            this.tbAreaDespacho = new System.Windows.Forms.TextBox();
            this.btnVerAlmacenes = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlmacenGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacen General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Área Recepción: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Área Despacho: ";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(36, 235);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 25);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(206, 235);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 25);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 280);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 22);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgAlmacenGeneral
            // 
            this.dgAlmacenGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlmacenGeneral.Location = new System.Drawing.Point(368, 85);
            this.dgAlmacenGeneral.Name = "dgAlmacenGeneral";
            this.dgAlmacenGeneral.Size = new System.Drawing.Size(408, 212);
            this.dgAlmacenGeneral.TabIndex = 7;
            this.dgAlmacenGeneral.SelectionChanged += new System.EventHandler(this.dgAlmacenGeneral_SelectionChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(701, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(548, 313);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 9;
            this.lblContador.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contador de almacenes generales:";
            // 
            // tbAreaRecepcion
            // 
            this.tbAreaRecepcion.Location = new System.Drawing.Point(114, 129);
            this.tbAreaRecepcion.Name = "tbAreaRecepcion";
            this.tbAreaRecepcion.Size = new System.Drawing.Size(193, 20);
            this.tbAreaRecepcion.TabIndex = 11;
            // 
            // tbAreaDespacho
            // 
            this.tbAreaDespacho.Location = new System.Drawing.Point(114, 175);
            this.tbAreaDespacho.Name = "tbAreaDespacho";
            this.tbAreaDespacho.Size = new System.Drawing.Size(193, 20);
            this.tbAreaDespacho.TabIndex = 12;
            // 
            // btnVerAlmacenes
            // 
            this.btnVerAlmacenes.Location = new System.Drawing.Point(206, 280);
            this.btnVerAlmacenes.Name = "btnVerAlmacenes";
            this.btnVerAlmacenes.Size = new System.Drawing.Size(88, 22);
            this.btnVerAlmacenes.TabIndex = 13;
            this.btnVerAlmacenes.Text = "Ver Almacenes";
            this.btnVerAlmacenes.UseVisualStyleBackColor = true;
            this.btnVerAlmacenes.Click += new System.EventHandler(this.btnVerAlmacenes_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(70, 86);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(237, 20);
            this.tbNombre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre: ";
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(421, 45);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(140, 20);
            this.tbBuscarNombre.TabIndex = 17;
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(580, 42);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(88, 25);
            this.btnBuscarPorNombre.TabIndex = 18;
            this.btnBuscarPorNombre.Text = "Buscar";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = true;
            this.btnBuscarPorNombre.Click += new System.EventHandler(this.btnBuscarPorNombre_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(688, 42);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(88, 25);
            this.btnMostrarTodo.TabIndex = 19;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            // 
            // FormAlmacenGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.tbBuscarNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerAlmacenes);
            this.Controls.Add(this.tbAreaDespacho);
            this.Controls.Add(this.tbAreaRecepcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgAlmacenGeneral);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlmacenGeneral";
            this.Text = "Almacen General";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlmacenGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgAlmacenGeneral;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAreaRecepcion;
        private System.Windows.Forms.TextBox tbAreaDespacho;
        private System.Windows.Forms.Button btnVerAlmacenes;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}