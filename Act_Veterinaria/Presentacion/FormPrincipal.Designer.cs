namespace Act_Veterinaria
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblMascotas = new System.Windows.Forms.Label();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.lblMCliente = new System.Windows.Forms.Label();
            this.btnAtencion = new System.Windows.Forms.Button();
            this.lblAtencion = new System.Windows.Forms.Label();
            this.dgvAtenciones = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionesPorMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(76, 80);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(189, 25);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(64, 151);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClientes.Size = new System.Drawing.Size(201, 356);
            this.dgvClientes.TabIndex = 2;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(111, 549);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(118, 24);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotas.Location = new System.Drawing.Point(440, 80);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(160, 25);
            this.lblMascotas.TabIndex = 4;
            this.lblMascotas.Text = "Mascota/s de:";
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.AllowUserToAddRows = false;
            this.dgvMascotas.AllowUserToDeleteRows = false;
            this.dgvMascotas.AllowUserToOrderColumns = true;
            this.dgvMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMascotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(334, 151);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.ReadOnly = true;
            this.dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMascotas.Size = new System.Drawing.Size(365, 356);
            this.dgvMascotas.TabIndex = 5;
            // 
            // lblMCliente
            // 
            this.lblMCliente.AutoSize = true;
            this.lblMCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCliente.Location = new System.Drawing.Point(457, 115);
            this.lblMCliente.Name = "lblMCliente";
            this.lblMCliente.Size = new System.Drawing.Size(15, 24);
            this.lblMCliente.TabIndex = 6;
            this.lblMCliente.Text = " ";
            // 
            // btnAtencion
            // 
            this.btnAtencion.Location = new System.Drawing.Point(461, 549);
            this.btnAtencion.Name = "btnAtencion";
            this.btnAtencion.Size = new System.Drawing.Size(118, 24);
            this.btnAtencion.TabIndex = 7;
            this.btnAtencion.Text = "Ver Atenciones";
            this.btnAtencion.UseVisualStyleBackColor = true;
            this.btnAtencion.Click += new System.EventHandler(this.btnAtencion_Click);
            // 
            // lblAtencion
            // 
            this.lblAtencion.AutoSize = true;
            this.lblAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencion.Location = new System.Drawing.Point(945, 80);
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(136, 25);
            this.lblAtencion.TabIndex = 8;
            this.lblAtencion.Text = "Atenciones:";
            // 
            // dgvAtenciones
            // 
            this.dgvAtenciones.AllowUserToAddRows = false;
            this.dgvAtenciones.AllowUserToDeleteRows = false;
            this.dgvAtenciones.AllowUserToOrderColumns = true;
            this.dgvAtenciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtenciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtenciones.Location = new System.Drawing.Point(740, 151);
            this.dgvAtenciones.Name = "dgvAtenciones";
            this.dgvAtenciones.ReadOnly = true;
            this.dgvAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtenciones.Size = new System.Drawing.Size(546, 356);
            this.dgvAtenciones.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.atencionesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1368, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.darBajaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // darBajaToolStripMenuItem
            // 
            this.darBajaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.darBajaToolStripMenuItem.Name = "darBajaToolStripMenuItem";
            this.darBajaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.darBajaToolStripMenuItem.Text = "Baja/Alta";
            this.darBajaToolStripMenuItem.Click += new System.EventHandler(this.darBajaToolStripMenuItem_Click);
            // 
            // atencionesToolStripMenuItem
            // 
            this.atencionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem1});
            this.atencionesToolStripMenuItem.Name = "atencionesToolStripMenuItem";
            this.atencionesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atencionesToolStripMenuItem.Text = "Atenciones";
            // 
            // nuevaToolStripMenuItem1
            // 
            this.nuevaToolStripMenuItem1.Name = "nuevaToolStripMenuItem1";
            this.nuevaToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.nuevaToolStripMenuItem1.Text = "Nueva";
            this.nuevaToolStripMenuItem1.Click += new System.EventHandler(this.nuevaToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.atencionesPorMascotaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.nuevoToolStripMenuItem1.Text = "Todas las Atenciones";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // atencionesPorMascotaToolStripMenuItem
            // 
            this.atencionesPorMascotaToolStripMenuItem.Name = "atencionesPorMascotaToolStripMenuItem";
            this.atencionesPorMascotaToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.atencionesPorMascotaToolStripMenuItem.Text = "Cantidad de Atenciones por Mascota";
            this.atencionesPorMascotaToolStripMenuItem.Click += new System.EventHandler(this.atencionesPorMascotaToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 662);
            this.Controls.Add(this.dgvAtenciones);
            this.Controls.Add(this.lblAtencion);
            this.Controls.Add(this.btnAtencion);
            this.Controls.Add(this.lblMCliente);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.lblMascotas);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Veterinaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtenciones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Label lblMCliente;
        private System.Windows.Forms.Button btnAtencion;
        private System.Windows.Forms.Label lblAtencion;
        private System.Windows.Forms.DataGridView dgvAtenciones;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atencionesPorMascotaToolStripMenuItem;
    }
}

