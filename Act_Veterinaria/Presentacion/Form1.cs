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

namespace Act_Veterinaria
{
    public partial class Form1 : Form
    {
        
        DBHelper ayudanteDB = new DBHelper();
        Form2 nuevoCliente = new Form2();
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            lblMCliente.Text = dgvClientes.CurrentCell.Value.ToString();
            cargarMascotas(dgvMascotas);
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
            cargarAtenciones(dgvAtenciones);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoCliente.ShowDialog();
            this.Dispose();

        }
        
    }
}
