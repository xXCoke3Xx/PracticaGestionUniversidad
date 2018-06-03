namespace GestionUniversisdad
{
    partial class Form_Matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Matricula));
            System.Windows.Forms.Label idMatriculaLabel;
            System.Windows.Forms.Label fechaSolicitudLabel;
            System.Windows.Forms.Label dniAlumnosLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            this.relaccionesxsd = new GestionUniversisdad.Relaccionesxsd();
            this.matriculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculasTableAdapter = new GestionUniversisdad.RelaccionesxsdTableAdapters.MatriculasTableAdapter();
            this.tableAdapterManager = new GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager();
            this.matriculasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.matriculasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.matriculasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMatriculaTextBox = new System.Windows.Forms.TextBox();
            this.fechaSolicitudDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dniAlumnosTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            idMatriculaLabel = new System.Windows.Forms.Label();
            fechaSolicitudLabel = new System.Windows.Forms.Label();
            dniAlumnosLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasBindingNavigator)).BeginInit();
            this.matriculasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaccionesxsd
            // 
            this.relaccionesxsd.DataSetName = "Relaccionesxsd";
            this.relaccionesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matriculasBindingSource
            // 
            this.matriculasBindingSource.DataMember = "Matriculas";
            this.matriculasBindingSource.DataSource = this.relaccionesxsd;
            // 
            // matriculasTableAdapter
            // 
            this.matriculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.FacultadesTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = this.matriculasTableAdapter;
            this.tableAdapterManager.NominaTableAdapter = null;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // matriculasBindingNavigator
            // 
            this.matriculasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.matriculasBindingNavigator.BindingSource = this.matriculasBindingSource;
            this.matriculasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.matriculasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.matriculasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.matriculasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.matriculasBindingNavigatorSaveItem});
            this.matriculasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.matriculasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.matriculasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.matriculasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.matriculasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.matriculasBindingNavigator.Name = "matriculasBindingNavigator";
            this.matriculasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.matriculasBindingNavigator.Size = new System.Drawing.Size(1371, 27);
            this.matriculasBindingNavigator.TabIndex = 0;
            this.matriculasBindingNavigator.Text = "bindingNavigator1";
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
            // matriculasBindingNavigatorSaveItem
            // 
            this.matriculasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matriculasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("matriculasBindingNavigatorSaveItem.Image")));
            this.matriculasBindingNavigatorSaveItem.Name = "matriculasBindingNavigatorSaveItem";
            this.matriculasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.matriculasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.matriculasBindingNavigatorSaveItem.Click += new System.EventHandler(this.matriculasBindingNavigatorSaveItem_Click);
            // 
            // matriculasDataGridView
            // 
            this.matriculasDataGridView.AutoGenerateColumns = false;
            this.matriculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriculasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.matriculasDataGridView.DataSource = this.matriculasBindingSource;
            this.matriculasDataGridView.Location = new System.Drawing.Point(12, 445);
            this.matriculasDataGridView.Name = "matriculasDataGridView";
            this.matriculasDataGridView.RowTemplate.Height = 24;
            this.matriculasDataGridView.Size = new System.Drawing.Size(1339, 259);
            this.matriculasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idMatricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "idMatricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaSolicitud";
            this.dataGridViewTextBoxColumn2.HeaderText = "fechaSolicitud";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dniAlumnos";
            this.dataGridViewTextBoxColumn3.HeaderText = "dniAlumnos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn4.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn6.HeaderText = "direccion";
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
            this.dataGridViewTextBoxColumn8.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn8.HeaderText = "email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idMatriculaLabel
            // 
            idMatriculaLabel.AutoSize = true;
            idMatriculaLabel.Location = new System.Drawing.Point(498, 120);
            idMatriculaLabel.Name = "idMatriculaLabel";
            idMatriculaLabel.Size = new System.Drawing.Size(84, 17);
            idMatriculaLabel.TabIndex = 2;
            idMatriculaLabel.Text = "id Matricula:";
            // 
            // idMatriculaTextBox
            // 
            this.idMatriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "idMatricula", true));
            this.idMatriculaTextBox.Location = new System.Drawing.Point(608, 117);
            this.idMatriculaTextBox.Name = "idMatriculaTextBox";
            this.idMatriculaTextBox.Size = new System.Drawing.Size(200, 22);
            this.idMatriculaTextBox.TabIndex = 3;
            // 
            // fechaSolicitudLabel
            // 
            fechaSolicitudLabel.AutoSize = true;
            fechaSolicitudLabel.Location = new System.Drawing.Point(498, 149);
            fechaSolicitudLabel.Name = "fechaSolicitudLabel";
            fechaSolicitudLabel.Size = new System.Drawing.Size(104, 17);
            fechaSolicitudLabel.TabIndex = 4;
            fechaSolicitudLabel.Text = "fecha Solicitud:";
            // 
            // fechaSolicitudDateTimePicker
            // 
            this.fechaSolicitudDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matriculasBindingSource, "fechaSolicitud", true));
            this.fechaSolicitudDateTimePicker.Location = new System.Drawing.Point(608, 145);
            this.fechaSolicitudDateTimePicker.Name = "fechaSolicitudDateTimePicker";
            this.fechaSolicitudDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaSolicitudDateTimePicker.TabIndex = 5;
            // 
            // dniAlumnosLabel
            // 
            dniAlumnosLabel.AutoSize = true;
            dniAlumnosLabel.Location = new System.Drawing.Point(498, 176);
            dniAlumnosLabel.Name = "dniAlumnosLabel";
            dniAlumnosLabel.Size = new System.Drawing.Size(89, 17);
            dniAlumnosLabel.TabIndex = 6;
            dniAlumnosLabel.Text = "dni Alumnos:";
            // 
            // dniAlumnosTextBox
            // 
            this.dniAlumnosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "dniAlumnos", true));
            this.dniAlumnosTextBox.Location = new System.Drawing.Point(608, 173);
            this.dniAlumnosTextBox.Name = "dniAlumnosTextBox";
            this.dniAlumnosTextBox.Size = new System.Drawing.Size(200, 22);
            this.dniAlumnosTextBox.TabIndex = 7;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(498, 204);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(68, 17);
            apellidosLabel.TabIndex = 8;
            apellidosLabel.Text = "apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(608, 201);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 22);
            this.apellidosTextBox.TabIndex = 9;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(498, 232);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(608, 229);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 22);
            this.nombreTextBox.TabIndex = 11;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(498, 260);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(69, 17);
            direccionLabel.TabIndex = 12;
            direccionLabel.Text = "direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(608, 257);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 22);
            this.direccionTextBox.TabIndex = 13;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(498, 288);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(63, 17);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(608, 285);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 22);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(498, 316);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculasBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(608, 313);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 17;
            // 
            // Form_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 724);
            this.Controls.Add(idMatriculaLabel);
            this.Controls.Add(this.idMatriculaTextBox);
            this.Controls.Add(fechaSolicitudLabel);
            this.Controls.Add(this.fechaSolicitudDateTimePicker);
            this.Controls.Add(dniAlumnosLabel);
            this.Controls.Add(this.dniAlumnosTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.matriculasDataGridView);
            this.Controls.Add(this.matriculasBindingNavigator);
            this.Name = "Form_Matricula";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Form_Matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasBindingNavigator)).EndInit();
            this.matriculasBindingNavigator.ResumeLayout(false);
            this.matriculasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriculasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaccionesxsd relaccionesxsd;
        private System.Windows.Forms.BindingSource matriculasBindingSource;
        private RelaccionesxsdTableAdapters.MatriculasTableAdapter matriculasTableAdapter;
        private RelaccionesxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator matriculasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton matriculasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView matriculasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idMatriculaTextBox;
        private System.Windows.Forms.DateTimePicker fechaSolicitudDateTimePicker;
        private System.Windows.Forms.TextBox dniAlumnosTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}