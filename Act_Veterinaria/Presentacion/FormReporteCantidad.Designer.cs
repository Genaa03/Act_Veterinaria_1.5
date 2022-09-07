namespace Act_Veterinaria.Presentacion
{
    partial class FormReporteCantidad
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
            this.components = new System.ComponentModel.Container();
            this.rvCantidad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataSet2 = new Act_Veterinaria.Presentacion.Reportes.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvCantidad
            // 
            this.rvCantidad.LocalReport.ReportEmbeddedResource = "Act_Veterinaria.Presentacion.Reportes.rptCantidadAtenciones.rdlc";
            this.rvCantidad.Location = new System.Drawing.Point(12, 12);
            this.rvCantidad.Name = "rvCantidad";
            this.rvCantidad.ServerReport.BearerToken = null;
            this.rvCantidad.Size = new System.Drawing.Size(776, 388);
            this.rvCantidad.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(343, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // FormReporteCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.rvCantidad);
            this.Name = "FormReporteCantidad";
            this.Text = "FormReporteCantidad";
            this.Load += new System.EventHandler(this.FormReporteCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCantidad;
        private System.Windows.Forms.Button btnCerrar;
        private Reportes.DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
    }
}