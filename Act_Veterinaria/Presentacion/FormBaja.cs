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

namespace Act_Veterinaria.Presentacion
{
    public partial class FormBaja : Form
    {
        DBHelper ayudante = new DBHelper();
        public FormBaja()
        {
            InitializeComponent();
        }

        private void FormBaja_Load(object sender, EventArgs e)
        {
            cargarAmbas(dgvDadosBaja,dgvHabilitados);
        }

        private void cargarAmbas(DataGridView dgvDadosBaja, DataGridView dgvHabilitados)
        {
            DataTable tabla = ayudante.consultaBD("SP_LISTA_CLIENTES");
            dgvHabilitados.DataSource = tabla;

            DataTable tabla2 = ayudante.consultaBD("SP_LISTA_CLIENTES_BAJA");
            dgvDadosBaja.DataSource = tabla2;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            
            if (dgvDadosBaja.SelectedCells.Count == 1)
            {
                ayudante.altaBaja_Cliente("SP_ALTA_CLIENTE", dgvDadosBaja.CurrentCell.Value.ToString());
                cargarAmbas(dgvDadosBaja, dgvHabilitados);
                MessageBox.Show("Se ha dado de ALTA al cliente correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor selecciona solo UN cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvHabilitados.SelectedCells.Count == 1)
            {
                ayudante.altaBaja_Cliente("SP_BAJA_CLIENTE", dgvHabilitados.CurrentCell.Value.ToString());
                cargarAmbas(dgvDadosBaja, dgvHabilitados);
                MessageBox.Show("Se ha dado de BAJA al cliente correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor selecciona solo UN cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
