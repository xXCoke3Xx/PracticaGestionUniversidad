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
    public partial class Form_Cursos : Form
    {
        public Form_Cursos()
        {
            InitializeComponent();
        }

        private void cursosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);

        }

        private void Form_Cursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Cursos' Puede moverla o quitarla según sea necesario.
            this.cursosTableAdapter.Fill(this.relaccionesxsd.Cursos);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.CursosTableAdapter cursos = new RelaccionesxsdTableAdapters.CursosTableAdapter();
            if (string.IsNullOrEmpty(idCursoTextBox.Text) || string.IsNullOrWhiteSpace(idCursoTextBox.Text))
            {
                MessageBox.Show("No se permite un ID curso vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                cursos.agregarCurso(idCursoTextBox.Text, escuelaTextBox.Text, nombreCursoTextBox.Text, fechaComienzoTextBox.Text, fechaTerminacionTextBox.Text, Convert.ToInt32(numHorasTextBox.Text), calendarioTextBox.Text);
                idCursoTextBox.Clear();
                escuelaTextBox.Clear();
                nombreCursoTextBox.Clear();
                fechaComienzoTextBox.Clear();
                fechaTerminacionTextBox.Clear();
                numHorasTextBox.Clear();
                calendarioTextBox.Clear();
            }
        }
    }
}
