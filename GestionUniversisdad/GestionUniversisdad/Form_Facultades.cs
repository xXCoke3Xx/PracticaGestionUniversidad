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
    }
}
