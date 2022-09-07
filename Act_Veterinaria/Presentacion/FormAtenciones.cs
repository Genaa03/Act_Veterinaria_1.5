using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Act_Veterinaria.Dominio;
using Act_Veterinaria.BaseDatos;

namespace Act_Veterinaria.Presentacion
{
    public partial class FormAtenciones : Form
    {
        DBHelper ayudante = new DBHelper();
        Mascota mascota;
        Atenciones atencion;
        public FormAtenciones()
        {
            InitializeComponent();
        }

        private void FormAtenciones_Load(object sender, EventArgs e)
        {
            cargarMascotas();
            ProximaAtencion();
            limpiar();
        }

        private void limpiar()
        {
            txtDescripcion.Text = "";
            txtImporte.Text = "";
            cboListaMascotas.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            ProximaAtencion();
        }

        private void ProximaAtencion()
        {
            int next = ayudante.ProximaAtencion();
            if (next > 0)
                lblNro.Text = next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cargarMascotas()
        {
            DataTable tabla = ayudante.consultaBD("SP_COMBO_MASCOTAS");
            cboListaMascotas.DataSource = tabla;
            cboListaMascotas.DisplayMember = tabla.Columns[2].ColumnName;
            cboListaMascotas.ValueMember = "id_mascota";
            cboListaMascotas.SelectedIndex = -1;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                mascota = new Mascota();
                mascota.pId_mascota = (int)cboListaMascotas.SelectedValue;
                atencion = new Atenciones(ayudante.ProximaAtencion(), mascota, dtpFecha.Value, txtDescripcion.Text, Convert.ToDouble(txtImporte.Text));

                ayudante.InsertarAtencion(atencion);
                limpiar();
                this.Close();
            }
        }

        private bool validar()
        {
            
            if(String.IsNullOrEmpty(txtImporte.Text) || String.IsNullOrEmpty(txtDescripcion.Text) || cboListaMascotas.SelectedIndex == -1)
            {
                MessageBox.Show("Algun campo esta vacio. \nPor favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if(int.TryParse(txtImporte.Text, out int a)){
                    MessageBox.Show("Se ha cargado con exito la atencion", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Algun campo esta vacio. \nPor favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
