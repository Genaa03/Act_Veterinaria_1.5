namespace Act_Veterinaria
{
    partial class Form2
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
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblSexoC = new System.Windows.Forms.Label();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblNroMasc = new System.Windows.Forms.Label();
            this.lblNroM = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblEdadM = new System.Windows.Forms.Label();
            this.txtEdadM = new System.Windows.Forms.TextBox();
            this.lblTipoM = new System.Windows.Forms.Label();
            this.cboTiposM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(122, 402);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 24);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.Location = new System.Drawing.Point(149, 177);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(82, 20);
            this.lblMascota.TabIndex = 5;
            this.lblMascota.Text = "Mascota:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(155, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.Location = new System.Drawing.Point(11, 92);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(136, 16);
            this.lblNombreC.TabIndex = 7;
            this.lblNombreC.Text = "Nombre Completo:";
            // 
            // lblSexoC
            // 
            this.lblSexoC.AutoSize = true;
            this.lblSexoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoC.Location = new System.Drawing.Point(85, 139);
            this.lblSexoC.Name = "lblSexoC";
            this.lblSexoC.Size = new System.Drawing.Size(62, 16);
            this.lblSexoC.TabIndex = 8;
            this.lblSexoC.Text = "Genero:";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasc.Location = new System.Drawing.Point(154, 139);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(103, 20);
            this.rdbMasc.TabIndex = 9;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "1 - Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFem.Location = new System.Drawing.Point(263, 139);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(102, 20);
            this.rdbFem.TabIndex = 10;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "2 - Femenino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(153, 92);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(240, 20);
            this.txtNombreC.TabIndex = 11;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCliente.Location = new System.Drawing.Point(59, 50);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(88, 16);
            this.lblNroCliente.TabIndex = 12;
            this.lblNroCliente.Text = "Nro Cliente:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(155, 47);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(0, 20);
            this.lblNro.TabIndex = 13;
            // 
            // lblNroMasc
            // 
            this.lblNroMasc.AutoSize = true;
            this.lblNroMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMasc.Location = new System.Drawing.Point(50, 220);
            this.lblNroMasc.Name = "lblNroMasc";
            this.lblNroMasc.Size = new System.Drawing.Size(99, 16);
            this.lblNroMasc.TabIndex = 14;
            this.lblNroMasc.Text = "Nro Mascota:";
            // 
            // lblNroM
            // 
            this.lblNroM.AutoSize = true;
            this.lblNroM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroM.Location = new System.Drawing.Point(155, 216);
            this.lblNroM.Name = "lblNroM";
            this.lblNroM.Size = new System.Drawing.Size(0, 20);
            this.lblNroM.TabIndex = 15;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(153, 300);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(240, 20);
            this.txtNombreM.TabIndex = 17;
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreM.Location = new System.Drawing.Point(81, 302);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(66, 16);
            this.lblNombreM.TabIndex = 16;
            this.lblNombreM.Text = "Nombre:";
            // 
            // lblEdadM
            // 
            this.lblEdadM.AutoSize = true;
            this.lblEdadM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadM.Location = new System.Drawing.Point(99, 351);
            this.lblEdadM.Name = "lblEdadM";
            this.lblEdadM.Size = new System.Drawing.Size(48, 16);
            this.lblEdadM.TabIndex = 18;
            this.lblEdadM.Text = "Edad:";
            // 
            // txtEdadM
            // 
            this.txtEdadM.Location = new System.Drawing.Point(153, 349);
            this.txtEdadM.Name = "txtEdadM";
            this.txtEdadM.Size = new System.Drawing.Size(87, 20);
            this.txtEdadM.TabIndex = 19;
            // 
            // lblTipoM
            // 
            this.lblTipoM.AutoSize = true;
            this.lblTipoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoM.Location = new System.Drawing.Point(104, 259);
            this.lblTipoM.Name = "lblTipoM";
            this.lblTipoM.Size = new System.Drawing.Size(43, 16);
            this.lblTipoM.TabIndex = 20;
            this.lblTipoM.Text = "Tipo:";
            // 
            // cboTiposM
            // 
            this.cboTiposM.FormattingEnabled = true;
            this.cboTiposM.Location = new System.Drawing.Point(153, 257);
            this.cboTiposM.Name = "cboTiposM";
            this.cboTiposM.Size = new System.Drawing.Size(121, 21);
            this.cboTiposM.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 440);
            this.Controls.Add(this.cboTiposM);
            this.Controls.Add(this.lblTipoM);
            this.Controls.Add(this.txtEdadM);
            this.Controls.Add(this.lblEdadM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.lblNombreM);
            this.Controls.Add(this.lblNroM);
            this.Controls.Add(this.lblNroMasc);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.rdbFem);
            this.Controls.Add(this.rdbMasc);
            this.Controls.Add(this.lblSexoC);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form2";
            this.Text = "Nuevo Cliente-Mascota";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblSexoC;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblNroMasc;
        private System.Windows.Forms.Label lblNroM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblEdadM;
        private System.Windows.Forms.TextBox txtEdadM;
        private System.Windows.Forms.Label lblTipoM;
        private System.Windows.Forms.ComboBox cboTiposM;
    }
}