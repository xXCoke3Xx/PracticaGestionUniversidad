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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cursos));
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label escuelaLabel;
            System.Windows.Forms.Label nombreCursoLabel;
            System.Windows.Forms.Label fechaComienzoLabel;
            System.Windows.Forms.Label fechaTerminacionLabel;
            System.Windows.Forms.Label numHorasLabel;
            System.Windows.Forms.Label calendarioLabel;
            this.relaccionesxsd = new GestionUniversisdad.Relaccionesxsd();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new GestionUniversisdad.RelaccionesxsdTableAdapters.CursosTableAdapter();
            this.tableAdapterManager = new GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager();
            this.cursosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cursosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.fechaComienzoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaTerminacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numHorasTextBox = new System.Windows.Forms.TextBox();
            this.calendarioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idCursoLabel = new System.Windows.Forms.Label();
            escuelaLabel = new System.Windows.Forms.Label();
            nombreCursoLabel = new System.Windows.Forms.Label();
            fechaComienzoLabel = new System.Windows.Forms.Label();
            fechaTerminacionLabel = new System.Windows.Forms.Label();
            numHorasLabel = new System.Windows.Forms.Label();
            calendarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).BeginInit();
            this.cursosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaccionesxsd
            // 
            this.relaccionesxsd.DataSetName = "Relaccionesxsd";
            this.relaccionesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.relaccionesxsd;
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
            // cursosBindingNavigator
            // 
            this.cursosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursosBindingNavigator.BindingSource = this.cursosBindingSource;
            this.cursosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorDeleteItem,
            this.cursosBindingNavigatorSaveItem});
            this.cursosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursosBindingNavigator.Name = "cursosBindingNavigator";
            this.cursosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursosBindingNavigator.Size = new System.Drawing.Size(1352, 27);
            this.cursosBindingNavigator.TabIndex = 0;
            this.cursosBindingNavigator.Text = "bindingNavigator1";
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
            // cursosBindingNavigatorSaveItem
            // 
            this.cursosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursosBindingNavigatorSaveItem.Image")));
            this.cursosBindingNavigatorSaveItem.Name = "cursosBindingNavigatorSaveItem";
            this.cursosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cursosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.cursosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursosBindingNavigatorSaveItem_Click);
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
            this.cursosDataGridView.Location = new System.Drawing.Point(12, 446);
            this.cursosDataGridView.Name = "cursosDataGridView";
            this.cursosDataGridView.RowTemplate.Height = 24;
            this.cursosDataGridView.Size = new System.Drawing.Size(1320, 329);
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
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(502, 157);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(64, 17);
            idCursoLabel.TabIndex = 2;
            idCursoLabel.Text = "id Curso:";
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "idCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(637, 154);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(200, 22);
            this.idCursoTextBox.TabIndex = 3;
            // 
            // escuelaLabel
            // 
            escuelaLabel.AutoSize = true;
            escuelaLabel.Location = new System.Drawing.Point(502, 185);
            escuelaLabel.Name = "escuelaLabel";
            escuelaLabel.Size = new System.Drawing.Size(61, 17);
            escuelaLabel.TabIndex = 4;
            escuelaLabel.Text = "escuela:";
            // 
            // escuelaTextBox
            // 
            this.escuelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "escuela", true));
            this.escuelaTextBox.Location = new System.Drawing.Point(637, 182);
            this.escuelaTextBox.Name = "escuelaTextBox";
            this.escuelaTextBox.Size = new System.Drawing.Size(200, 22);
            this.escuelaTextBox.TabIndex = 5;
            // 
            // nombreCursoLabel
            // 
            nombreCursoLabel.AutoSize = true;
            nombreCursoLabel.Location = new System.Drawing.Point(502, 213);
            nombreCursoLabel.Name = "nombreCursoLabel";
            nombreCursoLabel.Size = new System.Drawing.Size(101, 17);
            nombreCursoLabel.TabIndex = 6;
            nombreCursoLabel.Text = "nombre Curso:";
            // 
            // nombreCursoTextBox
            // 
            this.nombreCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "nombreCurso", true));
            this.nombreCursoTextBox.Location = new System.Drawing.Point(637, 210);
            this.nombreCursoTextBox.Name = "nombreCursoTextBox";
            this.nombreCursoTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreCursoTextBox.TabIndex = 7;
            // 
            // fechaComienzoLabel
            // 
            fechaComienzoLabel.AutoSize = true;
            fechaComienzoLabel.Location = new System.Drawing.Point(502, 242);
            fechaComienzoLabel.Name = "fechaComienzoLabel";
            fechaComienzoLabel.Size = new System.Drawing.Size(113, 17);
            fechaComienzoLabel.TabIndex = 8;
            fechaComienzoLabel.Text = "fecha Comienzo:";
            // 
            // fechaComienzoDateTimePicker
            // 
            this.fechaComienzoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursosBindingSource, "fechaComienzo", true));
            this.fechaComienzoDateTimePicker.Location = new System.Drawing.Point(637, 238);
            this.fechaComienzoDateTimePicker.Name = "fechaComienzoDateTimePicker";
            this.fechaComienzoDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaComienzoDateTimePicker.TabIndex = 9;
            // 
            // fechaTerminacionLabel
            // 
            fechaTerminacionLabel.AutoSize = true;
            fechaTerminacionLabel.Location = new System.Drawing.Point(502, 270);
            fechaTerminacionLabel.Name = "fechaTerminacionLabel";
            fechaTerminacionLabel.Size = new System.Drawing.Size(129, 17);
            fechaTerminacionLabel.TabIndex = 10;
            fechaTerminacionLabel.Text = "fecha Terminacion:";
            // 
            // fechaTerminacionDateTimePicker
            // 
            this.fechaTerminacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursosBindingSource, "fechaTerminacion", true));
            this.fechaTerminacionDateTimePicker.Location = new System.Drawing.Point(637, 266);
            this.fechaTerminacionDateTimePicker.Name = "fechaTerminacionDateTimePicker";
            this.fechaTerminacionDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaTerminacionDateTimePicker.TabIndex = 11;
            // 
            // numHorasLabel
            // 
            numHorasLabel.AutoSize = true;
            numHorasLabel.Location = new System.Drawing.Point(502, 297);
            numHorasLabel.Name = "numHorasLabel";
            numHorasLabel.Size = new System.Drawing.Size(81, 17);
            numHorasLabel.TabIndex = 12;
            numHorasLabel.Text = "num Horas:";
            // 
            // numHorasTextBox
            // 
            this.numHorasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "numHoras", true));
            this.numHorasTextBox.Location = new System.Drawing.Point(637, 294);
            this.numHorasTextBox.Name = "numHorasTextBox";
            this.numHorasTextBox.Size = new System.Drawing.Size(200, 22);
            this.numHorasTextBox.TabIndex = 13;
            // 
            // calendarioLabel
            // 
            calendarioLabel.AutoSize = true;
            calendarioLabel.Location = new System.Drawing.Point(502, 326);
            calendarioLabel.Name = "calendarioLabel";
            calendarioLabel.Size = new System.Drawing.Size(78, 17);
            calendarioLabel.TabIndex = 14;
            calendarioLabel.Text = "calendario:";
            // 
            // calendarioDateTimePicker
            // 
            this.calendarioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursosBindingSource, "calendario", true));
            this.calendarioDateTimePicker.Location = new System.Drawing.Point(637, 322);
            this.calendarioDateTimePicker.Name = "calendarioDateTimePicker";
            this.calendarioDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.calendarioDateTimePicker.TabIndex = 15;
            // 
            // Form_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 795);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(escuelaLabel);
            this.Controls.Add(this.escuelaTextBox);
            this.Controls.Add(nombreCursoLabel);
            this.Controls.Add(this.nombreCursoTextBox);
            this.Controls.Add(fechaComienzoLabel);
            this.Controls.Add(this.fechaComienzoDateTimePicker);
            this.Controls.Add(fechaTerminacionLabel);
            this.Controls.Add(this.fechaTerminacionDateTimePicker);
            this.Controls.Add(numHorasLabel);
            this.Controls.Add(this.numHorasTextBox);
            this.Controls.Add(calendarioLabel);
            this.Controls.Add(this.calendarioDateTimePicker);
            this.Controls.Add(this.cursosDataGridView);
            this.Controls.Add(this.cursosBindingNavigator);
            this.Name = "Form_Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Form_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).EndInit();
            this.cursosBindingNavigator.ResumeLayout(false);
            this.cursosBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
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
        private System.Windows.Forms.DateTimePicker fechaComienzoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaTerminacionDateTimePicker;
        private System.Windows.Forms.TextBox numHorasTextBox;
        private System.Windows.Forms.DateTimePicker calendarioDateTimePicker;
    }
}