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
    }
}
