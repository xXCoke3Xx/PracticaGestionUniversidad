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
    public partial class Form_Notas : Form
    {
        public Form_Notas()
        {
            InitializeComponent();
        }

        private void notasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);

        }

        private void Form_Notas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.relaccionesxsd.Notas);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.NotasTableAdapter notas = new RelaccionesxsdTableAdapters.NotasTableAdapter();
            if (string.IsNullOrEmpty(tbBuscar.Text) || string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("No se ha podido buscar, no se puede dejar el campo vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                DataTable notas2 = new DataTable();
                notas2 = notas.BuscardniAlumno(tbBuscar.Text);
                notasDataGridView.DataSource = notas2;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.NotasTableAdapter notas = new RelaccionesxsdTableAdapters.NotasTableAdapter();
            String b = tbBuscar.Text;
            notas.Borrar(b);
            this.notasTableAdapter.Fill(this.relaccionesxsd.Notas);
        }
    }
}
