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
    public partial class FormReporte : Form
    {

        DBHelper ayudante = new DBHelper();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {

            this.rvAtenciones.RefreshReport();
            this.rvAtenciones.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha desde es mayor que la de hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fechaDesde = Convert.ToDateTime(dtpDesde.Value.ToString());
                DateTime fechaHasta = Convert.ToDateTime(dtpHasta.Value.ToString());
                DataTable tabla = ayudante.reporteFechas(fechaDesde, fechaHasta);

                rvAtenciones.LocalReport.DataSources.Clear();
                rvAtenciones.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tabla));
                rvAtenciones.RefreshReport();
            }
        }
    }
}
