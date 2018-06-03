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
    }
}
