namespace GestionUniversisdad
{
    partial class Form_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Notas));
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label dniAlumnoLabel;
            System.Windows.Forms.Label convocatoriaLabel;
            System.Windows.Forms.Label notaLabel;
            this.relaccionesxsd = new GestionUniversisdad.Relaccionesxsd();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new GestionUniversisdad.RelaccionesxsdTableAdapters.NotasTableAdapter();
            this.tableAdapterManager = new GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager();
            this.notasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.notasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.notasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.dniAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.convocatoriaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            idCursoLabel = new System.Windows.Forms.Label();
            dniAlumnoLabel = new System.Windows.Forms.Label();
            convocatoriaLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).BeginInit();
            this.notasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaccionesxsd
            // 
            this.relaccionesxsd.DataSetName = "Relaccionesxsd";
            this.relaccionesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.relaccionesxsd;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.FacultadesTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.NominaTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notasBindingNavigator
            // 
            this.notasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasBindingNavigator.BindingSource = this.notasBindingSource;
            this.notasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.notasBindingNavigatorSaveItem});
            this.notasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasBindingNavigator.Name = "notasBindingNavigator";
            this.notasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasBindingNavigator.Size = new System.Drawing.Size(1211, 27);
            this.notasBindingNavigator.TabIndex = 0;
            this.notasBindingNavigator.Text = "bindingNavigator1";
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
            // notasBindingNavigatorSaveItem
            // 
            this.notasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasBindingNavigatorSaveItem.Image")));
            this.notasBindingNavigatorSaveItem.Name = "notasBindingNavigatorSaveItem";
            this.notasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.notasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.notasBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasBindingNavigatorSaveItem_Click);
            // 
            // notasDataGridView
            // 
            this.notasDataGridView.AutoGenerateColumns = false;
            this.notasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.notasDataGridView.DataSource = this.notasBindingSource;
            this.notasDataGridView.Location = new System.Drawing.Point(12, 430);
            this.notasDataGridView.Name = "notasDataGridView";
            this.notasDataGridView.RowTemplate.Height = 24;
            this.notasDataGridView.Size = new System.Drawing.Size(1179, 262);
            this.notasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCurso";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCurso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dniAlumno";
            this.dataGridViewTextBoxColumn2.HeaderText = "dniAlumno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "convocatoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "convocatoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nota";
            this.dataGridViewTextBoxColumn4.HeaderText = "nota";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(432, 115);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(64, 17);
            idCursoLabel.TabIndex = 2;
            idCursoLabel.Text = "id Curso:";
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "idCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(531, 112);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(200, 22);
            this.idCursoTextBox.TabIndex = 3;
            // 
            // dniAlumnoLabel
            // 
            dniAlumnoLabel.AutoSize = true;
            dniAlumnoLabel.Location = new System.Drawing.Point(432, 143);
            dniAlumnoLabel.Name = "dniAlumnoLabel";
            dniAlumnoLabel.Size = new System.Drawing.Size(82, 17);
            dniAlumnoLabel.TabIndex = 4;
            dniAlumnoLabel.Text = "dni Alumno:";
            // 
            // dniAlumnoTextBox
            // 
            this.dniAlumnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "dniAlumno", true));
            this.dniAlumnoTextBox.Location = new System.Drawing.Point(531, 140);
            this.dniAlumnoTextBox.Name = "dniAlumnoTextBox";
            this.dniAlumnoTextBox.Size = new System.Drawing.Size(200, 22);
            this.dniAlumnoTextBox.TabIndex = 5;
            // 
            // convocatoriaLabel
            // 
            convocatoriaLabel.AutoSize = true;
            convocatoriaLabel.Location = new System.Drawing.Point(432, 172);
            convocatoriaLabel.Name = "convocatoriaLabel";
            convocatoriaLabel.Size = new System.Drawing.Size(93, 17);
            convocatoriaLabel.TabIndex = 6;
            convocatoriaLabel.Text = "convocatoria:";
            // 
            // convocatoriaDateTimePicker
            // 
            this.convocatoriaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "convocatoria", true));
            this.convocatoriaDateTimePicker.Location = new System.Drawing.Point(531, 168);
            this.convocatoriaDateTimePicker.Name = "convocatoriaDateTimePicker";
            this.convocatoriaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.convocatoriaDateTimePicker.TabIndex = 7;
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(432, 199);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(40, 17);
            notaLabel.TabIndex = 8;
            notaLabel.Text = "nota:";
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "nota", true));
            this.notaTextBox.Location = new System.Drawing.Point(531, 196);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(200, 22);
            this.notaTextBox.TabIndex = 9;
            // 
            // Form_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 712);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(dniAlumnoLabel);
            this.Controls.Add(this.dniAlumnoTextBox);
            this.Controls.Add(convocatoriaLabel);
            this.Controls.Add(this.convocatoriaDateTimePicker);
            this.Controls.Add(notaLabel);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(this.notasDataGridView);
            this.Controls.Add(this.notasBindingNavigator);
            this.Name = "Form_Notas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form_Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingNavigator)).EndInit();
            this.notasBindingNavigator.ResumeLayout(false);
            this.notasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaccionesxsd relaccionesxsd;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private RelaccionesxsdTableAdapters.NotasTableAdapter notasTableAdapter;
        private RelaccionesxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton notasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView notasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.TextBox dniAlumnoTextBox;
        private System.Windows.Forms.DateTimePicker convocatoriaDateTimePicker;
        private System.Windows.Forms.TextBox notaTextBox;
    }
}