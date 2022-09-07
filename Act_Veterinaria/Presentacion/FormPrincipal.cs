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
using Act_Veterinaria.Presentacion;

namespace Act_Veterinaria
{
    public partial class FormPrincipal : Form
    {
        
        DBHelper ayudanteDB = new DBHelper();
        Form2 nuevoCliente = new Form2();
        FormAtenciones nuevaAtencion = new FormAtenciones();
        FormBaja bajaAlta = new FormBaja();
        FormReporte reporte = new FormReporte();
        FormReporteCantidad rCantidadAtenciones = new FormReporteCantidad();


        public FormPrincipal()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cargarClientes(dgvClientes);

        }



        private void cargarClientes(DataGridView dgv)
        {
            DataTable tabla = ayudanteDB.consultaBD("SP_LISTA_CLIENTES");
            dgv.DataSource = tabla;

        }

        private int obtenerID()
        {
            DataTable tabla2 = ayudanteDB.consultaBDParametros_ID("SP_OBTENER_ID", Convert.ToString(dgvClientes.CurrentCell.Value));
            int cod_cliente = Convert.ToInt32(tabla2.Rows[0]["cod_cliente"]);
            return cod_cliente;
        }

        private int obtenerIDMascota()
        {
            DataTable tabla2 = ayudanteDB.consultaBDParametros_ID("SP_OBTENER_ID_M", Convert.ToString(dgvMascotas.CurrentRow.Cells[0].Value));
            int id_mascota = Convert.ToInt32(tabla2.Rows[0]["id_mascota"]);
            return id_mascota;
        }

        private void cargarMascotas(DataGridView dgv)
        {
                int id = obtenerID();
                DataTable tabla = ayudanteDB.consultaBDParametros_Masc("SP_LISTA_MASCOTAS", id);
                dgv.DataSource = tabla;
        }

        private void cargarAtenciones(DataGridView dgv)
        {
            int id = obtenerIDMascota();

            DataTable tabla = ayudanteDB.consultaBDParametros_Masc("SP_LISTA_ATENCIONES", id);
            dgv.DataSource = tabla;

        }
        public void RecargarClientes()
        {
            cargarClientes(dgvClientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedCells.Count == 1)
            {
                lblMCliente.Text = dgvClientes.CurrentCell.Value.ToString();
                cargarMascotas(dgvMascotas);
                dgvAtenciones.DataSource = null;

            }
            else
            {
                MessageBox.Show("Por favor selecciona solo UN cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere salir?",
                "SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvAtenciones.DataSource = null;
            dgvMascotas.DataSource = null;
            dgvClientes.ClearSelection();
            lblMCliente.Text = "";
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.SelectedRows.Count == 1)
            {
                cargarAtenciones(dgvAtenciones);
            }
            else
            {
                MessageBox.Show("Por favor selecciona solo UNA mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoCliente.ShowDialog();
            cargarClientes(dgvClientes);
        }

        private void nuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nuevaAtencion.ShowDialog();
        }

        private void darBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bajaAlta.ShowDialog();
            cargarClientes(dgvClientes);
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reporte.ShowDialog();
        }

        private void atencionesPorMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCantidadAtenciones.ShowDialog();
        }
    }
}
