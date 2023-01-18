namespace Recorrer_JSON {
    partial class Inicio {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.pnlPropietario = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.lblTituloPropietario = new System.Windows.Forms.Label();
            this.pnlPropiedad = new System.Windows.Forms.Panel();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblCuotaAlquiler = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblTituloPropiedad = new System.Windows.Forms.Label();
            this.btnAnteriorPropietario = new System.Windows.Forms.Button();
            this.btnPosteriorPropietario = new System.Windows.Forms.Button();
            this.btnAnteriorPropiedad = new System.Windows.Forms.Button();
            this.btnPosteriorPropiedad = new System.Windows.Forms.Button();
            this.btnModificarPropietario = new System.Windows.Forms.Button();
            this.btnGuardarPropietario = new System.Windows.Forms.Button();
            this.btnEliminarPropietario = new System.Windows.Forms.Button();
            this.btnEliminarPropiedad = new System.Windows.Forms.Button();
            this.btnGuardarPropiedad = new System.Windows.Forms.Button();
            this.btnModificarPropiedad = new System.Windows.Forms.Button();
            this.pnlPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPropiedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPropietario
            // 
            this.pnlPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPropietario.BackColor = System.Drawing.Color.White;
            this.pnlPropietario.Controls.Add(this.btnEliminarPropietario);
            this.pnlPropietario.Controls.Add(this.btnGuardarPropietario);
            this.pnlPropietario.Controls.Add(this.btnModificarPropietario);
            this.pnlPropietario.Controls.Add(this.btnPosteriorPropietario);
            this.pnlPropietario.Controls.Add(this.btnAnteriorPropietario);
            this.pnlPropietario.Controls.Add(this.dataGridView1);
            this.pnlPropietario.Controls.Add(this.lblEmail);
            this.pnlPropietario.Controls.Add(this.lblTelefono);
            this.pnlPropietario.Controls.Add(this.lblNombre);
            this.pnlPropietario.Controls.Add(this.lblDNI);
            this.pnlPropietario.Controls.Add(this.txtNombre);
            this.pnlPropietario.Controls.Add(this.txtEmail);
            this.pnlPropietario.Controls.Add(this.txtTelefono);
            this.pnlPropietario.Controls.Add(this.txtDNI);
            this.pnlPropietario.Controls.Add(this.lblTituloPropietario);
            this.pnlPropietario.Location = new System.Drawing.Point(12, 12);
            this.pnlPropietario.Name = "pnlPropietario";
            this.pnlPropietario.Size = new System.Drawing.Size(579, 592);
            this.pnlPropietario.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 396);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 108);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(6, 52);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(90, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(144, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(90, 105);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(144, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(90, 49);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(144, 22);
            this.txtDNI.TabIndex = 1;
            // 
            // lblTituloPropietario
            // 
            this.lblTituloPropietario.AutoSize = true;
            this.lblTituloPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPropietario.Location = new System.Drawing.Point(3, 11);
            this.lblTituloPropietario.Name = "lblTituloPropietario";
            this.lblTituloPropietario.Size = new System.Drawing.Size(231, 31);
            this.lblTituloPropietario.TabIndex = 0;
            this.lblTituloPropietario.Text = "PROPIETARIOS";
            // 
            // pnlPropiedad
            // 
            this.pnlPropiedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPropiedad.BackColor = System.Drawing.Color.White;
            this.pnlPropiedad.Controls.Add(this.btnEliminarPropiedad);
            this.pnlPropiedad.Controls.Add(this.btnGuardarPropiedad);
            this.pnlPropiedad.Controls.Add(this.btnModificarPropiedad);
            this.pnlPropiedad.Controls.Add(this.btnPosteriorPropiedad);
            this.pnlPropiedad.Controls.Add(this.btnAnteriorPropiedad);
            this.pnlPropiedad.Controls.Add(this.txtCuota);
            this.pnlPropiedad.Controls.Add(this.txtDescripcion);
            this.pnlPropiedad.Controls.Add(this.txtLocalidad);
            this.pnlPropiedad.Controls.Add(this.lblCuotaAlquiler);
            this.pnlPropiedad.Controls.Add(this.txtDireccion);
            this.pnlPropiedad.Controls.Add(this.dataGridView2);
            this.pnlPropiedad.Controls.Add(this.lblDescripcion);
            this.pnlPropiedad.Controls.Add(this.lblLocalidad);
            this.pnlPropiedad.Controls.Add(this.lblDireccion);
            this.pnlPropiedad.Controls.Add(this.lblReferencia);
            this.pnlPropiedad.Controls.Add(this.txtReferencia);
            this.pnlPropiedad.Controls.Add(this.lblTituloPropiedad);
            this.pnlPropiedad.Location = new System.Drawing.Point(605, 12);
            this.pnlPropiedad.Name = "pnlPropiedad";
            this.pnlPropiedad.Size = new System.Drawing.Size(579, 592);
            this.pnlPropiedad.TabIndex = 1;
            // 
            // txtCuota
            // 
            this.txtCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuota.Location = new System.Drawing.Point(124, 161);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(144, 22);
            this.txtCuota.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(124, 133);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(144, 22);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(124, 105);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(144, 22);
            this.txtLocalidad.TabIndex = 7;
            // 
            // lblCuotaAlquiler
            // 
            this.lblCuotaAlquiler.AutoSize = true;
            this.lblCuotaAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaAlquiler.Location = new System.Drawing.Point(6, 164);
            this.lblCuotaAlquiler.Name = "lblCuotaAlquiler";
            this.lblCuotaAlquiler.Size = new System.Drawing.Size(112, 16);
            this.lblCuotaAlquiler.TabIndex = 11;
            this.lblCuotaAlquiler.Text = "Cuota de Alquiler:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(124, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(144, 22);
            this.txtDireccion.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(573, 396);
            this.dataGridView2.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(6, 108);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(6, 52);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(76, 16);
            this.lblReferencia.TabIndex = 5;
            this.lblReferencia.Text = "Referencia:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(124, 49);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(144, 22);
            this.txtReferencia.TabIndex = 5;
            // 
            // lblTituloPropiedad
            // 
            this.lblTituloPropiedad.AutoSize = true;
            this.lblTituloPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPropiedad.Location = new System.Drawing.Point(3, 11);
            this.lblTituloPropiedad.Name = "lblTituloPropiedad";
            this.lblTituloPropiedad.Size = new System.Drawing.Size(222, 31);
            this.lblTituloPropiedad.TabIndex = 0;
            this.lblTituloPropiedad.Text = "PROPIEDADES";
            // 
            // btnAnteriorPropietario
            // 
            this.btnAnteriorPropietario.Location = new System.Drawing.Point(240, 21);
            this.btnAnteriorPropietario.Name = "btnAnteriorPropietario";
            this.btnAnteriorPropietario.Size = new System.Drawing.Size(26, 23);
            this.btnAnteriorPropietario.TabIndex = 11;
            this.btnAnteriorPropietario.Text = "<";
            this.btnAnteriorPropietario.UseVisualStyleBackColor = true;
            // 
            // btnPosteriorPropietario
            // 
            this.btnPosteriorPropietario.Location = new System.Drawing.Point(550, 21);
            this.btnPosteriorPropietario.Name = "btnPosteriorPropietario";
            this.btnPosteriorPropietario.Size = new System.Drawing.Size(26, 23);
            this.btnPosteriorPropietario.TabIndex = 12;
            this.btnPosteriorPropietario.Text = ">";
            this.btnPosteriorPropietario.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorPropiedad
            // 
            this.btnAnteriorPropiedad.Location = new System.Drawing.Point(231, 21);
            this.btnAnteriorPropiedad.Name = "btnAnteriorPropiedad";
            this.btnAnteriorPropiedad.Size = new System.Drawing.Size(26, 23);
            this.btnAnteriorPropiedad.TabIndex = 12;
            this.btnAnteriorPropiedad.Text = "<";
            this.btnAnteriorPropiedad.UseVisualStyleBackColor = true;
            // 
            // btnPosteriorPropiedad
            // 
            this.btnPosteriorPropiedad.Location = new System.Drawing.Point(550, 21);
            this.btnPosteriorPropiedad.Name = "btnPosteriorPropiedad";
            this.btnPosteriorPropiedad.Size = new System.Drawing.Size(26, 23);
            this.btnPosteriorPropiedad.TabIndex = 13;
            this.btnPosteriorPropiedad.Text = ">";
            this.btnPosteriorPropiedad.UseVisualStyleBackColor = true;
            // 
            // btnModificarPropietario
            // 
            this.btnModificarPropietario.Location = new System.Drawing.Point(272, 21);
            this.btnModificarPropietario.Name = "btnModificarPropietario";
            this.btnModificarPropietario.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPropietario.TabIndex = 13;
            this.btnModificarPropietario.Text = "Modificar";
            this.btnModificarPropietario.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPropietario
            // 
            this.btnGuardarPropietario.Location = new System.Drawing.Point(371, 21);
            this.btnGuardarPropietario.Name = "btnGuardarPropietario";
            this.btnGuardarPropietario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPropietario.TabIndex = 14;
            this.btnGuardarPropietario.Text = "Guardar";
            this.btnGuardarPropietario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPropietario
            // 
            this.btnEliminarPropietario.Location = new System.Drawing.Point(469, 21);
            this.btnEliminarPropietario.Name = "btnEliminarPropietario";
            this.btnEliminarPropietario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPropietario.TabIndex = 15;
            this.btnEliminarPropietario.Text = "Eliminar";
            this.btnEliminarPropietario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPropiedad
            // 
            this.btnEliminarPropiedad.Location = new System.Drawing.Point(469, 21);
            this.btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            this.btnEliminarPropiedad.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPropiedad.TabIndex = 18;
            this.btnEliminarPropiedad.Text = "Eliminar";
            this.btnEliminarPropiedad.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPropiedad
            // 
            this.btnGuardarPropiedad.Location = new System.Drawing.Point(366, 21);
            this.btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            this.btnGuardarPropiedad.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPropiedad.TabIndex = 17;
            this.btnGuardarPropiedad.Text = "Guardar";
            this.btnGuardarPropiedad.UseVisualStyleBackColor = true;
            // 
            // btnModificarPropiedad
            // 
            this.btnModificarPropiedad.Location = new System.Drawing.Point(263, 21);
            this.btnModificarPropiedad.Name = "btnModificarPropiedad";
            this.btnModificarPropiedad.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPropiedad.TabIndex = 16;
            this.btnModificarPropiedad.Text = "Modificar";
            this.btnModificarPropiedad.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1196, 616);
            this.Controls.Add(this.pnlPropiedad);
            this.Controls.Add(this.pnlPropietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.pnlPropietario.ResumeLayout(false);
            this.pnlPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPropiedad.ResumeLayout(false);
            this.pnlPropiedad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPropietario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.Label lblTituloPropietario;
        private System.Windows.Forms.Panel pnlPropiedad;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblTituloPropiedad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblCuotaAlquiler;
        private System.Windows.Forms.Button btnPosteriorPropietario;
        private System.Windows.Forms.Button btnAnteriorPropietario;
        private System.Windows.Forms.Button btnPosteriorPropiedad;
        private System.Windows.Forms.Button btnAnteriorPropiedad;
        private System.Windows.Forms.Button btnEliminarPropietario;
        private System.Windows.Forms.Button btnGuardarPropietario;
        private System.Windows.Forms.Button btnModificarPropietario;
        private System.Windows.Forms.Button btnEliminarPropiedad;
        private System.Windows.Forms.Button btnGuardarPropiedad;
        private System.Windows.Forms.Button btnModificarPropiedad;
    }
}

