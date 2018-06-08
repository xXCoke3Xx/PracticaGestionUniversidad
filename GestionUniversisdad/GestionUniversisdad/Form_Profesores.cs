using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUniversisdad
{
    public partial class Form_Profesores : Form
    {
        public Form_Profesores()
        {
            InitializeComponent();
        }

        private void profesoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);

        }

        private void Form_Profesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.relaccionesxsd.Profesores);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.ProfesoresTableAdapter profesores = new RelaccionesxsdTableAdapters.ProfesoresTableAdapter();
            if (string.IsNullOrEmpty(tbBuscar.Text) || string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("No se ha podido buscar, no se puede dejar el campo vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                DataTable profesores2 = new DataTable();
                profesores2 = profesores.BuscarDNI(tbBuscar.Text);
                profesoresDataGridView.DataSource = profesores2;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.ProfesoresTableAdapter profesores = new RelaccionesxsdTableAdapters.ProfesoresTableAdapter();
            String b = tbBuscar.Text;
            profesores.Borrar(b);
            this.profesoresTableAdapter.Fill(this.relaccionesxsd.Profesores);
        }
    }
}
