using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Act_Veterinaria.BaseDatos;

namespace Act_Veterinaria { 

    public partial class Form2 : Form
    {

        DBHelper ayudante = new DBHelper();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ProximoCodCliente();
            ProximaMascota();
            CargarTipos();
        }

        private void CargarTipos()
        {
            DataTable tabla = ayudante.consultaBD("SP_OBTENER_TIPOS");
            cboTiposM.DataSource = tabla;
            cboTiposM.ValueMember = tabla.Columns[0].ColumnName;
            cboTiposM.DisplayMember = tabla.Columns[1].ColumnName;
            cboTiposM.SelectedIndex = -1;
        }

        private void ProximaMascota()
        {
            int next = ayudante.ProximaMascota();
            if (next > 0)
                lblNroM.Text = next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ProximoCodCliente()
        {
            int next = ayudante.ProximoCliente();
            if (next > 0)
                lblNro.Text = next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}