namespace GestionUniversisdad
{
    partial class Form_Facultades
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
            System.Windows.Forms.Label codigoFacultadLabel;
            System.Windows.Forms.Label nombreAsignaturaLabel;
            System.Windows.Forms.Label duracionLabel;
            System.Windows.Forms.Label codigoCursoLabel;
            System.Windows.Forms.Label directorLabel;
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label programaAsignaturaLabel;
            System.Windows.Forms.Label dniProfesorLabel;
            System.Windows.Forms.Label numeroCreditosLabel;
            System.Windows.Forms.Label horasPracticasLabel;
            System.Windows.Forms.Label horasTeoricasLabel;
            System.Windows.Forms.Label periodoLectivoLabel;
            System.Windows.Forms.Label nombreFacultadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Facultades));
            this.relaccionesxsd = new GestionUniversisdad.Relaccionesxsd();
            this.facultadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultadesTableAdapter = new GestionUniversisdad.RelaccionesxsdTableAdapters.FacultadesTableAdapter();
            this.tableAdapterManager = new GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager();
            this.facultadesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.facultadesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.facultadesDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFacultadTextBox = new System.Windows.Forms.TextBox();
            this.nombreAsignaturaTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.codigoCursoTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.programaAsignaturaTextBox = new System.Windows.Forms.TextBox();
            this.dniProfesorTextBox = new System.Windows.Forms.TextBox();
            this.numeroCreditosTextBox = new System.Windows.Forms.TextBox();
            this.horasPracticasTextBox = new System.Windows.Forms.TextBox();
            this.horasTeoricasTextBox = new System.Windows.Forms.TextBox();
            this.periodoLectivoTextBox = new System.Windows.Forms.TextBox();
            this.nombreFacultadTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            codigoFacultadLabel = new System.Windows.Forms.Label();
            nombreAsignaturaLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            codigoCursoLabel = new System.Windows.Forms.Label();
            directorLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            programaAsignaturaLabel = new System.Windows.Forms.Label();
            dniProfesorLabel = new System.Windows.Forms.Label();
            numeroCreditosLabel = new System.Windows.Forms.Label();
            horasPracticasLabel = new System.Windows.Forms.Label();
            horasTeoricasLabel = new System.Windows.Forms.Label();
            periodoLectivoLabel = new System.Windows.Forms.Label();
            nombreFacultadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadesBindingNavigator)).BeginInit();
            this.facultadesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultadesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoFacultadLabel
            // 
            codigoFacultadLabel.AutoSize = true;
            codigoFacultadLabel.Location = new System.Drawing.Point(416, 67);
            codigoFacultadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codigoFacultadLabel.Name = "codigoFacultadLabel";
            codigoFacultadLabel.Size = new System.Drawing.Size(86, 13);
            codigoFacultadLabel.TabIndex = 2;
            codigoFacultadLabel.Text = "codigo Facultad:";
            // 
            // nombreAsignaturaLabel
            // 
            nombreAsignaturaLabel.AutoSize = true;
            nombreAsignaturaLabel.Location = new System.Drawing.Point(416, 89);
            nombreAsignaturaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreAsignaturaLabel.Name = "nombreAsignaturaLabel";
            nombreAsignaturaLabel.Size = new System.Drawing.Size(98, 13);
            nombreAsignaturaLabel.TabIndex = 4;
            nombreAsignaturaLabel.Text = "nombre Asignatura:";
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.Location = new System.Drawing.Point(416, 112);
            duracionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(51, 13);
            duracionLabel.TabIndex = 6;
            duracionLabel.Text = "duracion:";
            // 
            // codigoCursoLabel
            // 
            codigoCursoLabel.AutoSize = true;
            codigoCursoLabel.Location = new System.Drawing.Point(416, 135);
            codigoCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codigoCursoLabel.Name = "codigoCursoLabel";
            codigoCursoLabel.Size = new System.Drawing.Size(72, 13);
            codigoCursoLabel.TabIndex = 8;
            codigoCursoLabel.Text = "codigo Curso:";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new System.Drawing.Point(416, 158);
            directorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new System.Drawing.Size(45, 13);
            directorLabel.TabIndex = 10;
            directorLabel.Text = "director:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(416, 180);
            cursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(36, 13);
            cursoLabel.TabIndex = 12;
            cursoLabel.Text = "curso:";
            // 
            // programaAsignaturaLabel
            // 
            programaAsignaturaLabel.AutoSize = true;
            programaAsignaturaLabel.Location = new System.Drawing.Point(416, 203);
            programaAsignaturaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            programaAsignaturaLabel.Name = "programaAsignaturaLabel";
            programaAsignaturaLabel.Size = new System.Drawing.Size(107, 13);
            programaAsignaturaLabel.TabIndex = 14;
            programaAsignaturaLabel.Text = "programa Asignatura:";
            // 
            // dniProfesorLabel
            // 
            dniProfesorLabel.AutoSize = true;
            dniProfesorLabel.Location = new System.Drawing.Point(416, 226);
            dniProfesorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dniProfesorLabel.Name = "dniProfesorLabel";
            dniProfesorLabel.Size = new System.Drawing.Size(66, 13);
            dniProfesorLabel.TabIndex = 16;
            dniProfesorLabel.Text = "dni Profesor:";
            // 
            // numeroCreditosLabel
            // 
            numeroCreditosLabel.AutoSize = true;
            numeroCreditosLabel.Location = new System.Drawing.Point(416, 249);
            numeroCreditosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroCreditosLabel.Name = "numeroCreditosLabel";
            numeroCreditosLabel.Size = new System.Drawing.Size(86, 13);
            numeroCreditosLabel.TabIndex = 18;
            numeroCreditosLabel.Text = "numero Creditos:";
            // 
            // horasPracticasLabel
            // 
            horasPracticasLabel.AutoSize = true;
            horasPracticasLabel.Location = new System.Drawing.Point(416, 271);
            horasPracticasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            horasPracticasLabel.Name = "horasPracticasLabel";
            horasPracticasLabel.Size = new System.Drawing.Size(83, 13);
            horasPracticasLabel.TabIndex = 20;
            horasPracticasLabel.Text = "horas Practicas:";
            // 
            // horasTeoricasLabel
            // 
            horasTeoricasLabel.AutoSize = true;
            horasTeoricasLabel.Location = new System.Drawing.Point(416, 294);
            horasTeoricasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            horasTeoricasLabel.Name = "horasTeoricasLabel";
            horasTeoricasLabel.Size = new System.Drawing.Size(80, 13);
            horasTeoricasLabel.TabIndex = 22;
            horasTeoricasLabel.Text = "horas Teoricas:";
            // 
            // periodoLectivoLabel
            // 
            periodoLectivoLabel.AutoSize = true;
            periodoLectivoLabel.Location = new System.Drawing.Point(416, 317);
            periodoLectivoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            periodoLectivoLabel.Name = "periodoLectivoLabel";
            periodoLectivoLabel.Size = new System.Drawing.Size(83, 13);
            periodoLectivoLabel.TabIndex = 24;
            periodoLectivoLabel.Text = "periodo Lectivo:";
            // 
            // nombreFacultadLabel
            // 
            nombreFacultadLabel.AutoSize = true;
            nombreFacultadLabel.Location = new System.Drawing.Point(416, 340);
            nombreFacultadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreFacultadLabel.Name = "nombreFacultadLabel";
            nombreFacultadLabel.Size = new System.Drawing.Size(89, 13);
            nombreFacultadLabel.TabIndex = 26;
            nombreFacultadLabel.Text = "nombre Facultad:";
            // 
            // relaccionesxsd
            // 
            this.relaccionesxsd.DataSetName = "Relaccionesxsd";
            this.relaccionesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultadesBindingSource
            // 
            this.facultadesBindingSource.DataMember = "Facultades";
            this.facultadesBindingSource.DataSource = this.relaccionesxsd;
            // 
            // facultadesTableAdapter
            // 
            this.facultadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.FacultadesTableAdapter = this.facultadesTableAdapter;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.NominaTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facultadesBindingNavigator
            // 
            this.facultadesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facultadesBindingNavigator.BindingSource = this.facultadesBindingSource;
            this.facultadesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facultadesBindingNavigator.DeleteItem = null;
            this.facultadesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.facultadesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.facultadesBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.tbBuscar,
            this.toolStripButton2});
            this.facultadesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facultadesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facultadesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facultadesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facultadesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facultadesBindingNavigator.Name = "facultadesBindingNavigator";
            this.facultadesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facultadesBindingNavigator.Size = new System.Drawing.Size(1028, 27);
            this.facultadesBindingNavigator.TabIndex = 0;
            this.facultadesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorAddNewItem.Text = "NUEVO";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // facultadesBindingNavigatorSaveItem
            // 
            this.facultadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.facultadesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facultadesBindingNavigatorSaveItem.Image")));
            this.facultadesBindingNavigatorSaveItem.Name = "facultadesBindingNavigatorSaveItem";
            this.facultadesBindingNavigatorSaveItem.Size = new System.Drawing.Size(65, 24);
            this.facultadesBindingNavigatorSaveItem.Text = "GUARDAR";
            this.facultadesBindingNavigatorSaveItem.Click += new System.EventHandler(this.facultadesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 24);
            this.toolStripButton1.Text = "BUSCAR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(76, 27);
            // 
            // facultadesDataGridView
            // 
            this.facultadesDataGridView.AutoGenerateColumns = false;
            this.facultadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.facultadesDataGridView.DataSource = this.facultadesBindingSource;
            this.facultadesDataGridView.Location = new System.Drawing.Point(9, 419);
            this.facultadesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facultadesDataGridView.Name = "facultadesDataGridView";
            this.facultadesDataGridView.RowTemplate.Height = 24;
            this.facultadesDataGridView.Size = new System.Drawing.Size(1084, 179);
            this.facultadesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoFacultad";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigoFacultad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreAsignatura";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombreAsignatura";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "duracion";
            this.dataGridViewTextBoxColumn3.HeaderText = "duracion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codigoCurso";
            this.dataGridViewTextBoxColumn4.HeaderText = "codigoCurso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "director";
            this.dataGridViewTextBoxColumn5.HeaderText = "director";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "curso";
            this.dataGridViewTextBoxColumn6.HeaderText = "curso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "programaAsignatura";
            this.dataGridViewTextBoxColumn7.HeaderText = "programaAsignatura";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dniProfesor";
            this.dataGridViewTextBoxColumn8.HeaderText = "dniProfesor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "numeroCreditos";
            this.dataGridViewTextBoxColumn9.HeaderText = "numeroCreditos";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "horasPracticas";
            this.dataGridViewTextBoxColumn10.HeaderText = "horasPracticas";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "horasTeoricas";
            this.dataGridViewTextBoxColumn11.HeaderText = "horasTeoricas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "periodoLectivo";
            this.dataGridViewTextBoxColumn12.HeaderText = "periodoLectivo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "nombreFacultad";
            this.dataGridViewTextBoxColumn13.HeaderText = "nombreFacultad";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // codigoFacultadTextBox
            // 
            this.codigoFacultadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "codigoFacultad", true));
            this.codigoFacultadTextBox.Location = new System.Drawing.Point(530, 64);
            this.codigoFacultadTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoFacultadTextBox.Name = "codigoFacultadTextBox";
            this.codigoFacultadTextBox.Size = new System.Drawing.Size(76, 20);
            this.codigoFacultadTextBox.TabIndex = 3;
            // 
            // nombreAsignaturaTextBox
            // 
            this.nombreAsignaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "nombreAsignatura", true));
            this.nombreAsignaturaTextBox.Location = new System.Drawing.Point(530, 87);
            this.nombreAsignaturaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreAsignaturaTextBox.Name = "nombreAsignaturaTextBox";
            this.nombreAsignaturaTextBox.Size = new System.Drawing.Size(76, 20);
            this.nombreAsignaturaTextBox.TabIndex = 5;
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "duracion", true));
            this.duracionTextBox.Location = new System.Drawing.Point(530, 110);
            this.duracionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.Size = new System.Drawing.Size(76, 20);
            this.duracionTextBox.TabIndex = 7;
            // 
            // codigoCursoTextBox
            // 
            this.codigoCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "codigoCurso", true));
            this.codigoCursoTextBox.Location = new System.Drawing.Point(530, 132);
            this.codigoCursoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoCursoTextBox.Name = "codigoCursoTextBox";
            this.codigoCursoTextBox.Size = new System.Drawing.Size(76, 20);
            this.codigoCursoTextBox.TabIndex = 9;
            // 
            // directorTextBox
            // 
            this.directorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "director", true));
            this.directorTextBox.Location = new System.Drawing.Point(530, 155);
            this.directorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(76, 20);
            this.directorTextBox.TabIndex = 11;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(530, 178);
            this.cursoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(76, 20);
            this.cursoTextBox.TabIndex = 13;
            // 
            // programaAsignaturaTextBox
            // 
            this.programaAsignaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "programaAsignatura", true));
            this.programaAsignaturaTextBox.Location = new System.Drawing.Point(530, 201);
            this.programaAsignaturaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.programaAsignaturaTextBox.Name = "programaAsignaturaTextBox";
            this.programaAsignaturaTextBox.Size = new System.Drawing.Size(76, 20);
            this.programaAsignaturaTextBox.TabIndex = 15;
            // 
            // dniProfesorTextBox
            // 
            this.dniProfesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "dniProfesor", true));
            this.dniProfesorTextBox.Location = new System.Drawing.Point(530, 223);
            this.dniProfesorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dniProfesorTextBox.Name = "dniProfesorTextBox";
            this.dniProfesorTextBox.Size = new System.Drawing.Size(76, 20);
            this.dniProfesorTextBox.TabIndex = 17;
            // 
            // numeroCreditosTextBox
            // 
            this.numeroCreditosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "numeroCreditos", true));
            this.numeroCreditosTextBox.Location = new System.Drawing.Point(530, 246);
            this.numeroCreditosTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroCreditosTextBox.Name = "numeroCreditosTextBox";
            this.numeroCreditosTextBox.Size = new System.Drawing.Size(76, 20);
            this.numeroCreditosTextBox.TabIndex = 19;
            // 
            // horasPracticasTextBox
            // 
            this.horasPracticasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "horasPracticas", true));
            this.horasPracticasTextBox.Location = new System.Drawing.Point(530, 269);
            this.horasPracticasTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horasPracticasTextBox.Name = "horasPracticasTextBox";
            this.horasPracticasTextBox.Size = new System.Drawing.Size(76, 20);
            this.horasPracticasTextBox.TabIndex = 21;
            // 
            // horasTeoricasTextBox
            // 
            this.horasTeoricasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "horasTeoricas", true));
            this.horasTeoricasTextBox.Location = new System.Drawing.Point(530, 292);
            this.horasTeoricasTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horasTeoricasTextBox.Name = "horasTeoricasTextBox";
            this.horasTeoricasTextBox.Size = new System.Drawing.Size(76, 20);
            this.horasTeoricasTextBox.TabIndex = 23;
            // 
            // periodoLectivoTextBox
            // 
            this.periodoLectivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "periodoLectivo", true));
            this.periodoLectivoTextBox.Location = new System.Drawing.Point(530, 314);
            this.periodoLectivoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.periodoLectivoTextBox.Name = "periodoLectivoTextBox";
            this.periodoLectivoTextBox.Size = new System.Drawing.Size(76, 20);
            this.periodoLectivoTextBox.TabIndex = 25;
            // 
            // nombreFacultadTextBox
            // 
            this.nombreFacultadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultadesBindingSource, "nombreFacultad", true));
            this.nombreFacultadTextBox.Location = new System.Drawing.Point(530, 337);
            this.nombreFacultadTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreFacultadTextBox.Name = "nombreFacultadTextBox";
            this.nombreFacultadTextBox.Size = new System.Drawing.Size(76, 20);
            this.nombreFacultadTextBox.TabIndex = 27;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(56, 24);
            this.toolStripButton2.Text = "BORRAR";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form_Facultades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 608);
            this.Controls.Add(codigoFacultadLabel);
            this.Controls.Add(this.codigoFacultadTextBox);
            this.Controls.Add(nombreAsignaturaLabel);
            this.Controls.Add(this.nombreAsignaturaTextBox);
            this.Controls.Add(duracionLabel);
            this.Controls.Add(this.duracionTextBox);
            this.Controls.Add(codigoCursoLabel);
            this.Controls.Add(this.codigoCursoTextBox);
            this.Controls.Add(directorLabel);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoTextBox);
            this.Controls.Add(programaAsignaturaLabel);
            this.Controls.Add(this.programaAsignaturaTextBox);
            this.Controls.Add(dniProfesorLabel);
            this.Controls.Add(this.dniProfesorTextBox);
            this.Controls.Add(numeroCreditosLabel);
            this.Controls.Add(this.numeroCreditosTextBox);
            this.Controls.Add(horasPracticasLabel);
            this.Controls.Add(this.horasPracticasTextBox);
            this.Controls.Add(horasTeoricasLabel);
            this.Controls.Add(this.horasTeoricasTextBox);
            this.Controls.Add(periodoLectivoLabel);
            this.Controls.Add(this.periodoLectivoTextBox);
            this.Controls.Add(nombreFacultadLabel);
            this.Controls.Add(this.nombreFacultadTextBox);
            this.Controls.Add(this.facultadesDataGridView);
            this.Controls.Add(this.facultadesBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Facultades";
            this.Text = "Facultades";
            this.Load += new System.EventHandler(this.Form_Facultades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultadesBindingNavigator)).EndInit();
            this.facultadesBindingNavigator.ResumeLayout(false);
            this.facultadesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultadesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaccionesxsd relaccionesxsd;
        private System.Windows.Forms.BindingSource facultadesBindingSource;
        private RelaccionesxsdTableAdapters.FacultadesTableAdapter facultadesTableAdapter;
        private RelaccionesxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facultadesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton facultadesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView facultadesDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox codigoFacultadTextBox;
        private System.Windows.Forms.TextBox nombreAsignaturaTextBox;
        private System.Windows.Forms.TextBox duracionTextBox;
        private System.Windows.Forms.TextBox codigoCursoTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox programaAsignaturaTextBox;
        private System.Windows.Forms.TextBox dniProfesorTextBox;
        private System.Windows.Forms.TextBox numeroCreditosTextBox;
        private System.Windows.Forms.TextBox horasPracticasTextBox;
        private System.Windows.Forms.TextBox horasTeoricasTextBox;
        private System.Windows.Forms.TextBox periodoLectivoTextBox;
        private System.Windows.Forms.TextBox nombreFacultadTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox tbBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}