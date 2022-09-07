namespace Act_Veterinaria.Presentacion
{
    partial class FormAtenciones
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
            this.lblAtencion = new System.Windows.Forms.Label();
            this.lblNroAtencion = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.cboListaMascotas = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAtencion
            // 
            this.lblAtencion.AutoSize = true;
            this.lblAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencion.Location = new System.Drawing.Point(232, 23);
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(99, 24);
            this.lblAtencion.TabIndex = 7;
            this.lblAtencion.Text = "Atencion:";
            // 
            // lblNroAtencion
            // 
            this.lblNroAtencion.AutoSize = true;
            this.lblNroAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroAtencion.Location = new System.Drawing.Point(16, 74);
            this.lblNroAtencion.Name = "lblNroAtencion";
            this.lblNroAtencion.Size = new System.Drawing.Size(111, 18);
            this.lblNroAtencion.TabIndex = 13;
            this.lblNroAtencion.Text = "Nro Atencion:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(130, 75);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(0, 16);
            this.lblNro.TabIndex = 14;
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.Location = new System.Drawing.Point(46, 120);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(78, 18);
            this.lblMascota.TabIndex = 15;
            this.lblMascota.Text = "Mascota:";
            // 
            // cboListaMascotas
            // 
            this.cboListaMascotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboListaMascotas.FormattingEnabled = true;
            this.cboListaMascotas.Location = new System.Drawing.Point(130, 120);
            this.cboListaMascotas.Name = "cboListaMascotas";
            this.cboListaMascotas.Size = new System.Drawing.Size(160, 23);
            this.cboListaMascotas.TabIndex = 16;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(62, 182);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 18);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(130, 181);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(109, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(22, 236);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 18);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(130, 237);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(434, 97);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.Text = "";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(37, 368);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(75, 18);
            this.lblImporte.TabIndex = 21;
            this.lblImporte.Text = "Importe: ";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(130, 367);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(136, 20);
            this.txtImporte.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "$";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(219, 425);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(112, 23);
            this.btnCargar.TabIndex = 24;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FormAtenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 460);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboListaMascotas);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.lblNroAtencion);
            this.Controls.Add(this.lblAtencion);
            this.Name = "FormAtenciones";
            this.Text = "Nueva Atencion";
            this.Load += new System.EventHandler(this.FormAtenciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtencion;
        private System.Windows.Forms.Label lblNroAtencion;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.ComboBox cboListaMascotas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
    }
}