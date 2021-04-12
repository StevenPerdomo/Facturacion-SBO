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
    public partial class FrmReporteFacturas : Form
    {
        public FrmReporteFacturas()
        {
            InitializeComponent();

            var _facturaBL = new FacturaBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturaBL.ObtenerFacturas();

            var reporte = new ReporteFacturas();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();


        }

    
    }
}
