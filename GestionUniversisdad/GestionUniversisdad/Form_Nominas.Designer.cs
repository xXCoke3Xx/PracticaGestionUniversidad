namespace GestionUniversisdad
{
    partial class Form_Nominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nominas));
            System.Windows.Forms.Label dniProfesorLabel;
            System.Windows.Forms.Label sueldoLabel;
            this.relaccionesxsd = new GestionUniversisdad.Relaccionesxsd();
            this.nominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominaTableAdapter = new GestionUniversisdad.RelaccionesxsdTableAdapters.NominaTableAdapter();
            this.tableAdapterManager = new GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager();
            this.nominaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nominaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nominaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniProfesorTextBox = new System.Windows.Forms.TextBox();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            dniProfesorLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingNavigator)).BeginInit();
            this.nominaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relaccionesxsd
            // 
            this.relaccionesxsd.DataSetName = "Relaccionesxsd";
            this.relaccionesxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominaBindingSource
            // 
            this.nominaBindingSource.DataMember = "Nomina";
            this.nominaBindingSource.DataSource = this.relaccionesxsd;
            // 
            // nominaTableAdapter
            // 
            this.nominaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.FacultadesTableAdapter = null;
            this.tableAdapterManager.MatriculasTableAdapter = null;
            this.tableAdapterManager.NominaTableAdapter = this.nominaTableAdapter;
            this.tableAdapterManager.NotasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestionUniversisdad.RelaccionesxsdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nominaBindingNavigator
            // 
            this.nominaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nominaBindingNavigator.BindingSource = this.nominaBindingSource;
            this.nominaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nominaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nominaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nominaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nominaBindingNavigatorSaveItem});
            this.nominaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nominaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nominaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nominaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nominaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nominaBindingNavigator.Name = "nominaBindingNavigator";
            this.nominaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nominaBindingNavigator.Size = new System.Drawing.Size(1514, 27);
            this.nominaBindingNavigator.TabIndex = 0;
            this.nominaBindingNavigator.Text = "bindingNavigator1";
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
            // nominaBindingNavigatorSaveItem
            // 
            this.nominaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nominaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nominaBindingNavigatorSaveItem.Image")));
            this.nominaBindingNavigatorSaveItem.Name = "nominaBindingNavigatorSaveItem";
            this.nominaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.nominaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.nominaBindingNavigatorSaveItem.Click += new System.EventHandler(this.nominaBindingNavigatorSaveItem_Click);
            // 
            // nominaDataGridView
            // 
            this.nominaDataGridView.AutoGenerateColumns = false;
            this.nominaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nominaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.nominaDataGridView.DataSource = this.nominaBindingSource;
            this.nominaDataGridView.Location = new System.Drawing.Point(12, 467);
            this.nominaDataGridView.Name = "nominaDataGridView";
            this.nominaDataGridView.RowTemplate.Height = 24;
            this.nominaDataGridView.Size = new System.Drawing.Size(1482, 220);
            this.nominaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dniProfesor";
            this.dataGridViewTextBoxColumn1.HeaderText = "dniProfesor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sueldo";
            this.dataGridViewTextBoxColumn2.HeaderText = "sueldo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dniProfesorLabel
            // 
            dniProfesorLabel.AutoSize = true;
            dniProfesorLabel.Location = new System.Drawing.Point(604, 181);
            dniProfesorLabel.Name = "dniProfesorLabel";
            dniProfesorLabel.Size = new System.Drawing.Size(89, 17);
            dniProfesorLabel.TabIndex = 2;
            dniProfesorLabel.Text = "dni Profesor:";
            // 
            // dniProfesorTextBox
            // 
            this.dniProfesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominaBindingSource, "dniProfesor", true));
            this.dniProfesorTextBox.Location = new System.Drawing.Point(699, 178);
            this.dniProfesorTextBox.Name = "dniProfesorTextBox";
            this.dniProfesorTextBox.Size = new System.Drawing.Size(100, 22);
            this.dniProfesorTextBox.TabIndex = 3;
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(604, 209);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(54, 17);
            sueldoLabel.TabIndex = 4;
            sueldoLabel.Text = "sueldo:";
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominaBindingSource, "sueldo", true));
            this.sueldoTextBox.Location = new System.Drawing.Point(699, 206);
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.Size = new System.Drawing.Size(100, 22);
            this.sueldoTextBox.TabIndex = 5;
            // 
            // Form_Nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 707);
            this.Controls.Add(dniProfesorLabel);
            this.Controls.Add(this.dniProfesorTextBox);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoTextBox);
            this.Controls.Add(this.nominaDataGridView);
            this.Controls.Add(this.nominaBindingNavigator);
            this.Name = "Form_Nominas";
            this.Text = "Nominas";
            this.Load += new System.EventHandler(this.Form_Nominas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relaccionesxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominaBindingNavigator)).EndInit();
            this.nominaBindingNavigator.ResumeLayout(false);
            this.nominaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Relaccionesxsd relaccionesxsd;
        private System.Windows.Forms.BindingSource nominaBindingSource;
        private RelaccionesxsdTableAdapters.NominaTableAdapter nominaTableAdapter;
        private RelaccionesxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nominaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nominaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nominaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox dniProfesorTextBox;
        private System.Windows.Forms.TextBox sueldoTextBox;
    }
}