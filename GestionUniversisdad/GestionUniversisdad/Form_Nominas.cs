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
    public partial class Form_Nominas : Form
    {
        public Form_Nominas()
        {
            InitializeComponent();
        }

        private void nominaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nominaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);

        }

        private void Form_Nominas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Nomina' Puede moverla o quitarla según sea necesario.
            this.nominaTableAdapter.Fill(this.relaccionesxsd.Nomina);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.NominaTableAdapter nomina = new RelaccionesxsdTableAdapters.NominaTableAdapter();
            if (string.IsNullOrEmpty(tbBuscar.Text) || string.IsNullOrWhiteSpace(tbBuscar.Text))
            {
                MessageBox.Show("No se ha podido buscar, no se puede dejar el campo vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                DataTable nomina2 = new DataTable();
                nomina2 = nomina.BuscardniProfesor(tbBuscar.Text);
                nominaDataGridView.DataSource = nomina2;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.NominaTableAdapter nomina = new RelaccionesxsdTableAdapters.NominaTableAdapter();
            String b = tbBuscar.Text;
            nomina.Borrar(b);
            this.nominaTableAdapter.Fill(this.relaccionesxsd.Nomina);
        }
    }
}
