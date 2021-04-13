using BLFacturacionSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionSB
{
    public partial class FrmSubReporte : Form
    {
        public FrmSubReporte()
        {
    
            InitializeComponent();

            var _clientesBL = new ClientesBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _clientesBL.ObtenerClientes();

            var reporte = new SubReporte();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();


        }
    }
    
}
