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
using Act_Veterinaria.Dominio;

namespace Act_Veterinaria { 

    public partial class Form2 : Form
    {

        DBHelper ayudante = new DBHelper();
        Mascota mascota;
        Cliente cliente;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ProximoCodCliente();
            ProximaMascota();
            CargarTipos();
            limpiar();
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
            if (validar())
            {
                int sexo;
                if (rdbMasc.Checked)
                {
                    sexo = 1;
                } else { 
                    sexo = 2;
                }
                cliente = new Cliente(ayudante.ProximoCliente(), sexo, txtNombreC.Text); 
                mascota = new Mascota(ayudante.ProximaMascota(), Convert.ToInt32(txtEdadM.Text), (int)cboTiposM.SelectedValue, txtNombreM.Text, cliente);

                ayudante.InsertarCliente(cliente);
                ayudante.InsertarMascota(mascota);
                limpiar();
                this.Close();
                
            }
        }

        private void limpiar()
        {
            txtNombreC.Text = "";
            txtEdadM.Text = "";
            txtNombreM.Text = "";
            cboTiposM.SelectedIndex = -1;
            rdbFem.Checked = false;
            rdbMasc.Checked = false;
            ProximoCodCliente();
            ProximaMascota();
        }

        private bool validar()
        {
            if (String.IsNullOrEmpty(txtNombreC.Text) || (rdbMasc.Checked == false && rdbFem.Checked == false) 
                || cboTiposM.SelectedIndex == -1 || String.IsNullOrEmpty(txtNombreM.Text) || String.IsNullOrEmpty(txtEdadM.Text))
            {
                MessageBox.Show("Algun campo esta vacio. \nPor favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (int.TryParse(txtEdadM.Text, out int a))
                {
                    MessageBox.Show("Se ha cargado con exito el cliente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("La edad debe ser solo numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}