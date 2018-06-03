namespace GestionUniversisdad
{
    partial class Form_Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alumnos));
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label fechaTituloLabel;
            System.Windows.Forms.Label nombreTituloLabel;
            System.Windows.Forms.Label centroAcademicoLabel;
            this.relaccionesxsd = new GestionUniversisdad.Relaccionesxsd();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new GestionUniversisdad.RelaccionesxsdTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager();
            this.alumnosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alumnosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.alumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.fechaTituloDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTituloTextBox = new System.Windows.Forms.TextBox();
            this.centroAcademicoTextBox = new System.Windows.Forms.TextBox();
            dNILabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            fechaTituloLabel = new System.Windows.Forms.Label();
            nombreTituloLabel = new System.Windows.Forms.Label();
            centroAcademicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).BeginInit();
            this.alumnosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaccionesxsd
            // 
            this.relaccionesxsd.DataSetName = "Relaccionesxsd";
            this.relaccionesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.relaccionesxsd;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.FacultadesTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.NominaTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumnosBindingNavigator
            // 
            this.alumnosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alumnosBindingNavigator.BindingSource = this.alumnosBindingSource;
            this.alumnosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alumnosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alumnosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.alumnosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.alumnosBindingNavigatorSaveItem});
            this.alumnosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alumnosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alumnosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alumnosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alumnosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alumnosBindingNavigator.Name = "alumnosBindingNavigator";
            this.alumnosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alumnosBindingNavigator.Size = new System.Drawing.Size(1273, 27);
            this.alumnosBindingNavigator.TabIndex = 0;
            this.alumnosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // alumnosBindingNavigatorSaveItem
            // 
            this.alumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alumnosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosBindingNavigatorSaveItem.Image")));
            this.alumnosBindingNavigatorSaveItem.Name = "alumnosBindingNavigatorSaveItem";
            this.alumnosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.alumnosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.alumnosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alumnosBindingNavigatorSaveItem_Click_1);
            // 
            // alumnosDataGridView
            // 
            this.alumnosDataGridView.AutoGenerateColumns = false;
            this.alumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.alumnosDataGridView.DataSource = this.alumnosBindingSource;
            this.alumnosDataGridView.Location = new System.Drawing.Point(37, 362);
            this.alumnosDataGridView.Name = "alumnosDataGridView";
            this.alumnosDataGridView.RowTemplate.Height = 24;
            this.alumnosDataGridView.Size = new System.Drawing.Size(1145, 329);
            this.alumnosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn2.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fechaNacimiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "fechaNacimiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "domicilio";
            this.dataGridViewTextBoxColumn5.HeaderText = "domicilio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codigoPostal";
            this.dataGridViewTextBoxColumn6.HeaderText = "codigoPostal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "e-mail";
            this.dataGridViewTextBoxColumn8.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fechaTitulo";
            this.dataGridViewTextBoxColumn9.HeaderText = "fechaTitulo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nombreTitulo";
            this.dataGridViewTextBoxColumn10.HeaderText = "nombreTitulo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "centroAcademico";
            this.dataGridViewTextBoxColumn11.HeaderText = "centroAcademico";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(446, 49);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(35, 17);
            dNILabel.TabIndex = 2;
            dNILabel.Text = "DNI:";
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(577, 46);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(200, 22);
            this.dNITextBox.TabIndex = 3;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(446, 77);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(68, 17);
            apellidosLabel.TabIndex = 4;
            apellidosLabel.Text = "apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(577, 74);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 22);
            this.apellidosTextBox.TabIndex = 5;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(446, 105);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(577, 102);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreTextBox.TabIndex = 7;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(446, 134);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(121, 17);
            fechaNacimientoLabel.TabIndex = 8;
            fechaNacimientoLabel.Text = "fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alumnosBindingSource, "fechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(577, 130);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaNacimientoDateTimePicker.TabIndex = 9;
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(446, 161);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(66, 17);
            domicilioLabel.TabIndex = 10;
            domicilioLabel.Text = "domicilio:";
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(577, 158);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(200, 22);
            this.domicilioTextBox.TabIndex = 11;
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(446, 189);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(97, 17);
            codigoPostalLabel.TabIndex = 12;
            codigoPostalLabel.Text = "codigo Postal:";
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "codigoPostal", true));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(577, 186);
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(200, 22);
            this.codigoPostalTextBox.TabIndex = 13;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(446, 217);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(63, 17);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(577, 214);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 22);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(446, 245);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(50, 17);
            e_mailLabel.TabIndex = 16;
            e_mailLabel.Text = "e-mail:";
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "e-mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(577, 242);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(200, 22);
            this.e_mailTextBox.TabIndex = 17;
            // 
            // fechaTituloLabel
            // 
            fechaTituloLabel.AutoSize = true;
            fechaTituloLabel.Location = new System.Drawing.Point(446, 274);
            fechaTituloLabel.Name = "fechaTituloLabel";
            fechaTituloLabel.Size = new System.Drawing.Size(86, 17);
            fechaTituloLabel.TabIndex = 18;
            fechaTituloLabel.Text = "fecha Titulo:";
            // 
            // fechaTituloDateTimePicker
            // 
            this.fechaTituloDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alumnosBindingSource, "fechaTitulo", true));
            this.fechaTituloDateTimePicker.Location = new System.Drawing.Point(577, 270);
            this.fechaTituloDateTimePicker.Name = "fechaTituloDateTimePicker";
            this.fechaTituloDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaTituloDateTimePicker.TabIndex = 19;
            // 
            // nombreTituloLabel
            // 
            nombreTituloLabel.AutoSize = true;
            nombreTituloLabel.Location = new System.Drawing.Point(446, 301);
            nombreTituloLabel.Name = "nombreTituloLabel";
            nombreTituloLabel.Size = new System.Drawing.Size(99, 17);
            nombreTituloLabel.TabIndex = 20;
            nombreTituloLabel.Text = "nombre Titulo:";
            // 
            // nombreTituloTextBox
            // 
            this.nombreTituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "nombreTitulo", true));
            this.nombreTituloTextBox.Location = new System.Drawing.Point(577, 298);
            this.nombreTituloTextBox.Name = "nombreTituloTextBox";
            this.nombreTituloTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreTituloTextBox.TabIndex = 21;
            // 
            // centroAcademicoLabel
            // 
            centroAcademicoLabel.AutoSize = true;
            centroAcademicoLabel.Location = new System.Drawing.Point(446, 329);
            centroAcademicoLabel.Name = "centroAcademicoLabel";
            centroAcademicoLabel.Size = new System.Drawing.Size(125, 17);
            centroAcademicoLabel.TabIndex = 22;
            centroAcademicoLabel.Text = "centro Academico:";
            // 
            // centroAcademicoTextBox
            // 
            this.centroAcademicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "centroAcademico", true));
            this.centroAcademicoTextBox.Location = new System.Drawing.Point(577, 326);
            this.centroAcademicoTextBox.Name = "centroAcademicoTextBox";
            this.centroAcademicoTextBox.Size = new System.Drawing.Size(200, 22);
            this.centroAcademicoTextBox.TabIndex = 23;
            // 
            // Form_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 726);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.domicilioTextBox);
            this.Controls.Add(codigoPostalLabel);
            this.Controls.Add(this.codigoPostalTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(fechaTituloLabel);
            this.Controls.Add(this.fechaTituloDateTimePicker);
            this.Controls.Add(nombreTituloLabel);
            this.Controls.Add(this.nombreTituloTextBox);
            this.Controls.Add(centroAcademicoLabel);
            this.Controls.Add(this.centroAcademicoTextBox);
            this.Controls.Add(this.alumnosDataGridView);
            this.Controls.Add(this.alumnosBindingNavigator);
            this.Name = "Form_Alumnos";
            this.Text = "Form_Alumnos";
            this.Load += new System.EventHandler(this.Form_Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).EndInit();
            this.alumnosBindingNavigator.ResumeLayout(false);
            this.alumnosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaccionesxsd relaccionesxsd;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private RelaccionesxsdTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private RelaccionesxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alumnosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton alumnosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView alumnosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.DateTimePicker fechaTituloDateTimePicker;
        private System.Windows.Forms.TextBox nombreTituloTextBox;
        private System.Windows.Forms.TextBox centroAcademicoTextBox;
    }
}