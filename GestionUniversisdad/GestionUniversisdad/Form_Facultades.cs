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
    public partial class Form_Facultades : Form
    {
        public Form_Facultades()
        {
            InitializeComponent();
        }

        private void facultadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);

        }

        private void Form_Facultades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Facultades' Puede moverla o quitarla según sea necesario.
            this.facultadesTableAdapter.Fill(this.relaccionesxsd.Facultades);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.FacultadesTableAdapter facultad = new RelaccionesxsdTableAdapters.FacultadesTableAdapter();
            if (string.IsNullOrEmpty(tbBuscar.Text) || string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("No se ha podido buscar, no se puede dejar el campo vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                DataTable facultad2 = new DataTable();
                facultad2 = facultad.BuscarCodigoFacultad(tbBuscar.Text);
                facultadesDataGridView.DataSource = facultad2;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.FacultadesTableAdapter nomina = new RelaccionesxsdTableAdapters.FacultadesTableAdapter();
            String b = tbBuscar.Text;
            nomina.Borrar(b);
            this.facultadesTableAdapter.Fill(this.relaccionesxsd.Facultades);
        }
    }
}
