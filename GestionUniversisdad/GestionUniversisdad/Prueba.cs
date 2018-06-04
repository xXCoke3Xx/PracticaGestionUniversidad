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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);

        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'relaccionesxsd.Alumnos' table. You can move, or remove it, as needed.
            this.alumnosTableAdapter.Fill(this.relaccionesxsd.Alumnos);

        }
    }
}
