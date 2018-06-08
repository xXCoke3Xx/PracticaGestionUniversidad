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
    public partial class Form_Matricula : Form
    {
        public Form_Matricula()
        {
            InitializeComponent();
        }

        private void matriculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matriculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);

        }

        private void Form_Matricula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Matriculas' Puede moverla o quitarla según sea necesario.
            this.matriculasTableAdapter.Fill(this.relaccionesxsd.Matriculas);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.MatriculasTableAdapter matricula = new RelaccionesxsdTableAdapters.MatriculasTableAdapter();
            if (string.IsNullOrEmpty(tbBuscar.Text) || string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("No se ha podido buscar, no se puede dejar el campo vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                DataTable matricula2 = new DataTable();
                matricula2 = matricula.BuscarIDMatricula(tbBuscar.Text);
                matriculasDataGridView.DataSource = matricula2;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.MatriculasTableAdapter nomina = new RelaccionesxsdTableAdapters.MatriculasTableAdapter();
            String b = tbBuscar.Text;
            nomina.Borrar(b);
            this.matriculasTableAdapter.Fill(this.relaccionesxsd.Matriculas);
        }
    }
}
