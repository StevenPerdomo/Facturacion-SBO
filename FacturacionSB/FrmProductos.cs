using System;
using System.Windows.Forms;
using BLFacturacionSB;
using System.IO;
using System.Drawing;

namespace FacturacionSB
{
    public partial class FrmProductos : Form
    {
      
        ProductosBL _productos;
        CategoriasBL _categorias;
        

        public FrmProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _categorias = new CategoriasBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();

        }



        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

        private void ToolstripButtonSalvar_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var producto = (Producto)listaProductosBindingSource.Current;

            if(imagProdPictureBox.Image != null)
            {
                producto.ImagProd = Program.ImageToByteArray(imagProdPictureBox.Image);
            }
            else
            {
                producto.ImagProd = null;
            }

            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Almacenamiento Exitoso");
            }
            else
            {
                MessageBox.Show("Ocurrio un error guardando este producto");
            }
        }

        private void ToolstripButtonAgregar_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

        }


        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;

            ToolstripButtonAgregar.Enabled = valor;
            ToolstripButtonEliminar.Enabled = valor;
            ToolstripButtonCancelar.Visible = !valor;

        }


        private void ToolstripButtonEliminar_Click(object sender, EventArgs e)
        {
            

            if (idTextBox.Text != "")
            {

                var resultado = MessageBox.Show("Desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado ==  DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
                    
            }

        }

        private void Eliminar(int id)
        {

            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error a Eliminar este Producto");
            }
        }



        private void ToolstripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void imagProdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void AgregarFoto_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;

            var archivo = openFileDialog2.FileName;
            openFileDialog2.ShowDialog();
          
            if (producto.ImagProd != null)
            {
                
                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    imagProdPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Cree un Producto ante de Agregar una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imagProdPictureBox = null;
        }
    }
}