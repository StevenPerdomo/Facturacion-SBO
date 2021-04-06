namespace FacturacionSB
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombrecontLabel;
            System.Windows.Forms.Label puestoLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label rtnClienteLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label idLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.listaClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombrecontTextBox = new System.Windows.Forms.TextBox();
            this.puestoTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.rtnClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.listaTermPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTipoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            activoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombrecontLabel = new System.Windows.Forms.Label();
            puestoLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            rtnClienteLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaClienteBindingNavigator)).BeginInit();
            this.listaClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTermPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(49, 317);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 3;
            activoLabel.Text = "Activo:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(49, 212);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(63, 81);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // nombrecontLabel
            // 
            nombrecontLabel.AutoSize = true;
            nombrecontLabel.Location = new System.Drawing.Point(31, 158);
            nombrecontLabel.Name = "nombrecontLabel";
            nombrecontLabel.Size = new System.Drawing.Size(53, 13);
            nombrecontLabel.TabIndex = 9;
            nombrecontLabel.Text = "Contacto:";
            // 
            // puestoLabel
            // 
            puestoLabel.AutoSize = true;
            puestoLabel.Location = new System.Drawing.Point(41, 184);
            puestoLabel.Name = "puestoLabel";
            puestoLabel.Size = new System.Drawing.Size(43, 13);
            puestoLabel.TabIndex = 11;
            puestoLabel.Text = "Puesto:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(16, 106);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 13;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // rtnClienteLabel
            // 
            rtnClienteLabel.AutoSize = true;
            rtnClienteLabel.Location = new System.Drawing.Point(27, 129);
            rtnClienteLabel.Name = "rtnClienteLabel";
            rtnClienteLabel.Size = new System.Drawing.Size(62, 13);
            rtnClienteLabel.TabIndex = 15;
            rtnClienteLabel.Text = "Rtn Cliente:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(32, 236);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 17;
            telefonoLabel.Text = "Telefono:";
            telefonoLabel.Click += new System.EventHandler(this.telefonoLabel_Click);
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(20, 289);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(62, 13);
            idLabel2.TabIndex = 20;
            idLabel2.Text = "Term. Pago";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(49, 262);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(31, 13);
            idLabel1.TabIndex = 21;
            idLabel1.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficha de Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listaClienteBindingNavigator
            // 
            this.listaClienteBindingNavigator.AddNewItem = null;
            this.listaClienteBindingNavigator.BindingSource = this.listaClienteBindingSource;
            this.listaClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaClienteBindingNavigator.DeleteItem = null;
            this.listaClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaClienteBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaClienteBindingNavigator.Name = "listaClienteBindingNavigator";
            this.listaClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaClienteBindingNavigator.Size = new System.Drawing.Size(1172, 25);
            this.listaClienteBindingNavigator.TabIndex = 10;
            this.listaClienteBindingNavigator.Text = "bindingNavigator1";
            this.listaClienteBindingNavigator.RefreshItems += new System.EventHandler(this.listaClienteBindingNavigator_RefreshItems);
            // 
            // listaClienteBindingSource
            // 
            this.listaClienteBindingSource.DataSource = typeof(BLFacturacionSB.Cliente);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaClienteBindingNavigatorSaveItem
            // 
            this.listaClienteBindingNavigatorSaveItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listaClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaClienteBindingNavigatorSaveItem.Image")));
            this.listaClienteBindingNavigatorSaveItem.Name = "listaClienteBindingNavigatorSaveItem";
            this.listaClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaClienteBindingNavigatorSaveItem.Text = "Save Data";
            this.listaClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaClienteBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // listaClienteDataGridView
            // 
            this.listaClienteDataGridView.AutoGenerateColumns = false;
            this.listaClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.listaClienteDataGridView.DataSource = this.listaClienteBindingSource;
            this.listaClienteDataGridView.Location = new System.Drawing.Point(244, 77);
            this.listaClienteDataGridView.Name = "listaClienteDataGridView";
            this.listaClienteDataGridView.Size = new System.Drawing.Size(849, 352);
            this.listaClienteDataGridView.TabIndex = 9;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaClienteBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(95, 310);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 8;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClienteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(95, 207);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClienteBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 77);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // nombrecontTextBox
            // 
            this.nombrecontTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClienteBindingSource, "Nombrecont", true));
            this.nombrecontTextBox.Location = new System.Drawing.Point(95, 155);
            this.nombrecontTextBox.Name = "nombrecontTextBox";
            this.nombrecontTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombrecontTextBox.TabIndex = 3;
            // 
            // puestoTextBox
            // 
            this.puestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClienteBindingSource, "Puesto", true));
            this.puestoTextBox.Location = new System.Drawing.Point(95, 181);
            this.puestoTextBox.Name = "puestoTextBox";
            this.puestoTextBox.Size = new System.Drawing.Size(121, 20);
            this.puestoTextBox.TabIndex = 4;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClienteBindingSource, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(95, 103);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(121, 20);
            this.razonSocialTextBox.TabIndex = 1;
            // 
            // rtnClienteTextBox
            // 
            this.rtnClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClienteBindingSource, "RtnCliente", true));
            this.rtnClienteTextBox.Location = new System.Drawing.Point(95, 129);
            this.rtnClienteTextBox.Name = "rtnClienteTextBox";
            this.rtnClienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.rtnClienteTextBox.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaClienteBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(95, 233);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefonoTextBox.TabIndex = 6;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClienteBindingSource, "TermPagoId", true));
            this.idComboBox.DataSource = this.listaTermPagoBindingSource;
            this.idComboBox.DisplayMember = "Descripcion";
            this.idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(95, 286);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(121, 21);
            this.idComboBox.TabIndex = 8;
            this.idComboBox.ValueMember = "Id";
            // 
            // listaTermPagoBindingSource
            // 
            this.listaTermPagoBindingSource.DataSource = typeof(BLFacturacionSB.TermPago);
            // 
            // listaTipoClienteBindingSource
            // 
            this.listaTipoClienteBindingSource.DataSource = typeof(BLFacturacionSB.TipoCliente);
            // 
            // idComboBox1
            // 
            this.idComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaClienteBindingSource, "TipoClienteId", true));
            this.idComboBox1.DataSource = this.listaTipoClienteBindingSource;
            this.idComboBox1.DisplayMember = "Descripcion";
            this.idComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idComboBox1.FormattingEnabled = true;
            this.idComboBox1.Location = new System.Drawing.Point(95, 259);
            this.idComboBox1.Name = "idComboBox1";
            this.idComboBox1.Size = new System.Drawing.Size(121, 21);
            this.idComboBox1.TabIndex = 7;
            this.idComboBox1.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RazonSocial";
            this.dataGridViewTextBoxColumn2.HeaderText = "RazonSocial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RtnCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "RtnCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombrecont";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombrecont";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Puesto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 448);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idComboBox1);
            this.Controls.Add(idLabel2);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombrecontLabel);
            this.Controls.Add(this.nombrecontTextBox);
            this.Controls.Add(puestoLabel);
            this.Controls.Add(this.puestoTextBox);
            this.Controls.Add(razonSocialLabel);
            this.Controls.Add(this.razonSocialTextBox);
            this.Controls.Add(rtnClienteLabel);
            this.Controls.Add(this.rtnClienteTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.listaClienteDataGridView);
            this.Controls.Add(this.listaClienteBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaClienteBindingNavigator)).EndInit();
            this.listaClienteBindingNavigator.ResumeLayout(false);
            this.listaClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTermPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource listaClienteBindingSource;
        private System.Windows.Forms.BindingNavigator listaClienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaClienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listaClienteDataGridView;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombrecontTextBox;
        private System.Windows.Forms.TextBox puestoTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox rtnClienteTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingSource listaTermPagoBindingSource;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource listaTipoClienteBindingSource;
        private System.Windows.Forms.ComboBox idComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}