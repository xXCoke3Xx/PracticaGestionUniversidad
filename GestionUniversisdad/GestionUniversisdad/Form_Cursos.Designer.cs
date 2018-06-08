namespace GestionUniversisdad
{
    partial class Form_Cursos
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
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label escuelaLabel;
            System.Windows.Forms.Label nombreCursoLabel;
            System.Windows.Forms.Label fechaComienzoLabel;
            System.Windows.Forms.Label fechaTerminacionLabel;
            System.Windows.Forms.Label numHorasLabel;
            System.Windows.Forms.Label calendarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cursos));
            this.cursosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaccionesxsd = new GestionUniversisdad.Relaccionesxsd();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cursosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.cursosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.escuelaTextBox = new System.Windows.Forms.TextBox();
            this.nombreCursoTextBox = new System.Windows.Forms.TextBox();
            this.fechaComienzoTextBox = new System.Windows.Forms.TextBox();
            this.fechaTerminacionTextBox = new System.Windows.Forms.TextBox();
            this.numHorasTextBox = new System.Windows.Forms.TextBox();
            this.calendarioTextBox = new System.Windows.Forms.TextBox();
            this.cursosTableAdapter = new GestionUniversisdad.RelaccionesxsdTableAdapters.CursosTableAdapter();
            this.tableAdapterManager = new GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            idCursoLabel = new System.Windows.Forms.Label();
            escuelaLabel = new System.Windows.Forms.Label();
            nombreCursoLabel = new System.Windows.Forms.Label();
            fechaComienzoLabel = new System.Windows.Forms.Label();
            fechaTerminacionLabel = new System.Windows.Forms.Label();
            numHorasLabel = new System.Windows.Forms.Label();
            calendarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).BeginInit();
            this.cursosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(487, 90);
            idCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(48, 13);
            idCursoLabel.TabIndex = 2;
            idCursoLabel.Text = "id Curso:";
            // 
            // escuelaLabel
            // 
            escuelaLabel.AutoSize = true;
            escuelaLabel.Location = new System.Drawing.Point(487, 113);
            escuelaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            escuelaLabel.Name = "escuelaLabel";
            escuelaLabel.Size = new System.Drawing.Size(47, 13);
            escuelaLabel.TabIndex = 4;
            escuelaLabel.Text = "escuela:";
            // 
            // nombreCursoLabel
            // 
            nombreCursoLabel.AutoSize = true;
            nombreCursoLabel.Location = new System.Drawing.Point(487, 136);
            nombreCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreCursoLabel.Name = "nombreCursoLabel";
            nombreCursoLabel.Size = new System.Drawing.Size(75, 13);
            nombreCursoLabel.TabIndex = 6;
            nombreCursoLabel.Text = "nombre Curso:";
            // 
            // fechaComienzoLabel
            // 
            fechaComienzoLabel.AutoSize = true;
            fechaComienzoLabel.Location = new System.Drawing.Point(487, 158);
            fechaComienzoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fechaComienzoLabel.Name = "fechaComienzoLabel";
            fechaComienzoLabel.Size = new System.Drawing.Size(86, 13);
            fechaComienzoLabel.TabIndex = 8;
            fechaComienzoLabel.Text = "fecha Comienzo:";
            // 
            // fechaTerminacionLabel
            // 
            fechaTerminacionLabel.AutoSize = true;
            fechaTerminacionLabel.Location = new System.Drawing.Point(487, 181);
            fechaTerminacionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fechaTerminacionLabel.Name = "fechaTerminacionLabel";
            fechaTerminacionLabel.Size = new System.Drawing.Size(98, 13);
            fechaTerminacionLabel.TabIndex = 10;
            fechaTerminacionLabel.Text = "fecha Terminacion:";
            // 
            // numHorasLabel
            // 
            numHorasLabel.AutoSize = true;
            numHorasLabel.Location = new System.Drawing.Point(487, 204);
            numHorasLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numHorasLabel.Name = "numHorasLabel";
            numHorasLabel.Size = new System.Drawing.Size(61, 13);
            numHorasLabel.TabIndex = 12;
            numHorasLabel.Text = "num Horas:";
            // 
            // calendarioLabel
            // 
            calendarioLabel.AutoSize = true;
            calendarioLabel.Location = new System.Drawing.Point(487, 227);
            calendarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            calendarioLabel.Name = "calendarioLabel";
            calendarioLabel.Size = new System.Drawing.Size(59, 13);
            calendarioLabel.TabIndex = 14;
            calendarioLabel.Text = "calendario:";
            // 
            // cursosBindingNavigator
            // 
            this.cursosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursosBindingNavigator.BindingSource = this.cursosBindingSource;
            this.cursosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursosBindingNavigator.DeleteItem = null;
            this.cursosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cursosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cursosBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.tbBuscar,
            this.toolStripButton2});
            this.cursosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursosBindingNavigator.Name = "cursosBindingNavigator";
            this.cursosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursosBindingNavigator.Size = new System.Drawing.Size(1014, 27);
            this.cursosBindingNavigator.TabIndex = 0;
            this.cursosBindingNavigator.Text = "bindingNavigator1";
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
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.relaccionesxsd;
            // 
            // relaccionesxsd
            // 
            this.relaccionesxsd.DataSetName = "Relaccionesxsd";
            this.relaccionesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cursosBindingNavigatorSaveItem
            // 
            this.cursosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cursosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursosBindingNavigatorSaveItem.Image")));
            this.cursosBindingNavigatorSaveItem.Name = "cursosBindingNavigatorSaveItem";
            this.cursosBindingNavigatorSaveItem.Size = new System.Drawing.Size(65, 24);
            this.cursosBindingNavigatorSaveItem.Text = "GUARDAR";
            this.cursosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursosBindingNavigatorSaveItem_Click);
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
            // cursosDataGridView
            // 
            this.cursosDataGridView.AutoGenerateColumns = false;
            this.cursosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cursosDataGridView.DataSource = this.cursosBindingSource;
            this.cursosDataGridView.Location = new System.Drawing.Point(9, 362);
            this.cursosDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cursosDataGridView.Name = "cursosDataGridView";
            this.cursosDataGridView.RowTemplate.Height = 24;
            this.cursosDataGridView.Size = new System.Drawing.Size(990, 267);
            this.cursosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCurso";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCurso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "escuela";
            this.dataGridViewTextBoxColumn2.HeaderText = "escuela";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombreCurso";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombreCurso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fechaComienzo";
            this.dataGridViewTextBoxColumn4.HeaderText = "fechaComienzo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fechaTerminacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "fechaTerminacion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "numHoras";
            this.dataGridViewTextBoxColumn6.HeaderText = "numHoras";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "calendario";
            this.dataGridViewTextBoxColumn7.HeaderText = "calendario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "idCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(588, 88);
            this.idCursoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(76, 20);
            this.idCursoTextBox.TabIndex = 3;
            // 
            // escuelaTextBox
            // 
            this.escuelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "escuela", true));
            this.escuelaTextBox.Location = new System.Drawing.Point(588, 110);
            this.escuelaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.escuelaTextBox.Name = "escuelaTextBox";
            this.escuelaTextBox.Size = new System.Drawing.Size(76, 20);
            this.escuelaTextBox.TabIndex = 5;
            // 
            // nombreCursoTextBox
            // 
            this.nombreCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "nombreCurso", true));
            this.nombreCursoTextBox.Location = new System.Drawing.Point(588, 133);
            this.nombreCursoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreCursoTextBox.Name = "nombreCursoTextBox";
            this.nombreCursoTextBox.Size = new System.Drawing.Size(76, 20);
            this.nombreCursoTextBox.TabIndex = 7;
            // 
            // fechaComienzoTextBox
            // 
            this.fechaComienzoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "fechaComienzo", true));
            this.fechaComienzoTextBox.Location = new System.Drawing.Point(588, 156);
            this.fechaComienzoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaComienzoTextBox.Name = "fechaComienzoTextBox";
            this.fechaComienzoTextBox.Size = new System.Drawing.Size(76, 20);
            this.fechaComienzoTextBox.TabIndex = 9;
            // 
            // fechaTerminacionTextBox
            // 
            this.fechaTerminacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "fechaTerminacion", true));
            this.fechaTerminacionTextBox.Location = new System.Drawing.Point(588, 179);
            this.fechaTerminacionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaTerminacionTextBox.Name = "fechaTerminacionTextBox";
            this.fechaTerminacionTextBox.Size = new System.Drawing.Size(76, 20);
            this.fechaTerminacionTextBox.TabIndex = 11;
            // 
            // numHorasTextBox
            // 
            this.numHorasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "numHoras", true));
            this.numHorasTextBox.Location = new System.Drawing.Point(588, 202);
            this.numHorasTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numHorasTextBox.Name = "numHorasTextBox";
            this.numHorasTextBox.Size = new System.Drawing.Size(76, 20);
            this.numHorasTextBox.TabIndex = 13;
            // 
            // calendarioTextBox
            // 
            this.calendarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "calendario", true));
            this.calendarioTextBox.Location = new System.Drawing.Point(588, 224);
            this.calendarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calendarioTextBox.Name = "calendarioTextBox";
            this.calendarioTextBox.Size = new System.Drawing.Size(76, 20);
            this.calendarioTextBox.TabIndex = 15;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = this.cursosTableAdapter;
            this.tableAdapterManager.FacultadesTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.NominaTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // Form_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 609);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(escuelaLabel);
            this.Controls.Add(this.escuelaTextBox);
            this.Controls.Add(nombreCursoLabel);
            this.Controls.Add(this.nombreCursoTextBox);
            this.Controls.Add(fechaComienzoLabel);
            this.Controls.Add(this.fechaComienzoTextBox);
            this.Controls.Add(fechaTerminacionLabel);
            this.Controls.Add(this.fechaTerminacionTextBox);
            this.Controls.Add(numHorasLabel);
            this.Controls.Add(this.numHorasTextBox);
            this.Controls.Add(calendarioLabel);
            this.Controls.Add(this.calendarioTextBox);
            this.Controls.Add(this.cursosDataGridView);
            this.Controls.Add(this.cursosBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Form_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).EndInit();
            this.cursosBindingNavigator.ResumeLayout(false);
            this.cursosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaccionesxsd relaccionesxsd;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private RelaccionesxsdTableAdapters.CursosTableAdapter cursosTableAdapter;
        private RelaccionesxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cursosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cursosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cursosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.TextBox escuelaTextBox;
        private System.Windows.Forms.TextBox nombreCursoTextBox;
        private System.Windows.Forms.TextBox fechaComienzoTextBox;
        private System.Windows.Forms.TextBox fechaTerminacionTextBox;
        private System.Windows.Forms.TextBox numHorasTextBox;
        private System.Windows.Forms.TextBox calendarioTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox tbBuscar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}