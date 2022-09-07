namespace Act_Veterinaria.Presentacion
{
    partial class FormBaja
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.dgvHabilitados = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.dgvDadosBaja = new System.Windows.Forms.DataGridView();
            this.lblBajaT = new System.Windows.Forms.Label();
            this.lblAlta = new System.Windows.Forms.Label();
            this.lblBaja = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(95, 468);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(118, 24);
            this.btnBaja.TabIndex = 6;
            this.btnBaja.Text = "Dar Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvHabilitados
            // 
            this.dgvHabilitados.AllowUserToAddRows = false;
            this.dgvHabilitados.AllowUserToDeleteRows = false;
            this.dgvHabilitados.AllowUserToOrderColumns = true;
            this.dgvHabilitados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabilitados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHabilitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabilitados.Location = new System.Drawing.Point(54, 91);
            this.dgvHabilitados.Name = "dgvHabilitados";
            this.dgvHabilitados.ReadOnly = true;
            this.dgvHabilitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHabilitados.Size = new System.Drawing.Size(201, 356);
            this.dgvHabilitados.TabIndex = 5;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(60, 20);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(189, 25);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "Lista de Clientes";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(408, 468);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(118, 24);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Dar Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // dgvDadosBaja
            // 
            this.dgvDadosBaja.AllowUserToAddRows = false;
            this.dgvDadosBaja.AllowUserToDeleteRows = false;
            this.dgvDadosBaja.AllowUserToOrderColumns = true;
            this.dgvDadosBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosBaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDadosBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosBaja.Location = new System.Drawing.Point(367, 91);
            this.dgvDadosBaja.Name = "dgvDadosBaja";
            this.dgvDadosBaja.ReadOnly = true;
            this.dgvDadosBaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDadosBaja.Size = new System.Drawing.Size(201, 356);
            this.dgvDadosBaja.TabIndex = 8;
            // 
            // lblBajaT
            // 
            this.lblBajaT.AutoSize = true;
            this.lblBajaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaT.Location = new System.Drawing.Point(373, 20);
            this.lblBajaT.Name = "lblBajaT";
            this.lblBajaT.Size = new System.Drawing.Size(189, 25);
            this.lblBajaT.TabIndex = 7;
            this.lblBajaT.Text = "Lista de Clientes";
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.Location = new System.Drawing.Point(421, 54);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(92, 25);
            this.lblAlta.TabIndex = 10;
            this.lblAlta.Text = "de Baja";
            // 
            // lblBaja
            // 
            this.lblBaja.AutoSize = true;
            this.lblBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaja.Location = new System.Drawing.Point(111, 54);
            this.lblBaja.Name = "lblBaja";
            this.lblBaja.Size = new System.Drawing.Size(86, 25);
            this.lblBaja.TabIndex = 11;
            this.lblBaja.Text = "de Alta";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(240, 508);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(118, 24);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 544);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblBaja);
            this.Controls.Add(this.lblAlta);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvDadosBaja);
            this.Controls.Add(this.lblBajaT);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dgvHabilitados);
            this.Controls.Add(this.lblClientes);
            this.Name = "FormBaja";
            this.Text = "Baja Cliente";
            this.Load += new System.EventHandler(this.FormBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabilitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosBaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridView dgvHabilitados;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridView dgvDadosBaja;
        private System.Windows.Forms.Label lblBajaT;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.Label lblBaja;
        private System.Windows.Forms.Button btnCerrar;
    }
}