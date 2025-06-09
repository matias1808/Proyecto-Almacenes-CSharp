namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlmacenGeneral = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAreaProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO AL PROGRAMA DE ALMACENES";
            // 
            // btnAlmacenGeneral
            // 
            this.btnAlmacenGeneral.Location = new System.Drawing.Point(26, 56);
            this.btnAlmacenGeneral.Name = "btnAlmacenGeneral";
            this.btnAlmacenGeneral.Size = new System.Drawing.Size(208, 31);
            this.btnAlmacenGeneral.TabIndex = 1;
            this.btnAlmacenGeneral.Text = "Almacenes Generales";
            this.btnAlmacenGeneral.UseVisualStyleBackColor = true;
            this.btnAlmacenGeneral.Click += new System.EventHandler(this.btnAlmacenGeneral_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.Location = new System.Drawing.Point(26, 107);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(208, 31);
            this.btnAreas.TabIndex = 2;
            this.btnAreas.Text = "Areas Operativas y de Producción";
            this.btnAreas.UseVisualStyleBackColor = true;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 31);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAreaProducto
            // 
            this.btnAreaProducto.Location = new System.Drawing.Point(29, 162);
            this.btnAreaProducto.Name = "btnAreaProducto";
            this.btnAreaProducto.Size = new System.Drawing.Size(208, 31);
            this.btnAreaProducto.TabIndex = 4;
            this.btnAreaProducto.Text = "Asignar Areas y Productos";
            this.btnAreaProducto.UseVisualStyleBackColor = true;
            this.btnAreaProducto.Click += new System.EventHandler(this.btnAreaProducto_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 285);
            this.Controls.Add(this.btnAreaProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.btnAlmacenGeneral);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlmacenGeneral;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAreaProducto;
    }
}

