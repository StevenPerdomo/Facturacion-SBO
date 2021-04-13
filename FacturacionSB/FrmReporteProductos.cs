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
    public partial class FrmReporteProductos : Form
    {
        public FrmReporteProductos()
        {
            InitializeComponent();
             
            var _productosBL = new ProductosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _productosBL.ObtenerProductos();

            var reporte = new ReporteProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();


        }

    
    }
}
