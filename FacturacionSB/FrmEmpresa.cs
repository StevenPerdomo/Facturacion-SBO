using BLFacturacionSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionSB
{
    public partial class FrmEmpresa : Form
    {
        EmpresaBL _empresa;

        public FrmEmpresa()
        {
            InitializeComponent();

            _empresa = new EmpresaBL();
            listaEmpresasBindingSource.DataSource = _empresa.ObtenerEmpresas();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _empresa.AgregarEmpresa();
            listaEmpresasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {

                var resultado = MessageBox.Show("Desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }

            }
        }

        private void Eliminar(int id)
        {

            var resultado = _empresa.EliminarEmpresa(id);

            if (resultado == true)
            {
                listaEmpresasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error a Eliminar esta Empresa");
            }
        }


        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void listaEmpresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _empresa.AgregarEmpresa();
            listaEmpresasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

        }


        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripLabel1.Visible = !valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empresa = (Empresa)listaEmpresasBindingSource.Current;

            var archivo = openFileDialog1.FileName;
            openFileDialog1.ShowDialog();

            if (empresa.ImagEmpresa != null)
            {

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    imagEmpresaPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un Producto ante de Agregar una imagen");
            }
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            imagEmpresaPictureBox = null;
        }
    }
}
