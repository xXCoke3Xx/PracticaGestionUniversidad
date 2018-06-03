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
    }
}
