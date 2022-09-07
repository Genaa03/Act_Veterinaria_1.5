using Act_Veterinaria.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_Veterinaria.Presentacion
{
    public partial class FormReporteCantidad : Form
    {

        DBHelper ayudante = new DBHelper();
        public FormReporteCantidad()
        {
            InitializeComponent();
        }

        private void FormReporteCantidad_Load(object sender, EventArgs e)
        {
            DataTable tabla = ayudante.reporteCantidad();
            rvCantidad.LocalReport.DataSources.Clear();
            rvCantidad.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", tabla));
            rvCantidad.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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


    }
}
