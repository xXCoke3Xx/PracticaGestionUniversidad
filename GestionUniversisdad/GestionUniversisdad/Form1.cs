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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Alumnos fAlumnos = new Form_Alumnos();
            fAlumnos.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Facultades fAsignaturas = new Form_Facultades();
            fAsignaturas.Show();
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar la Gestion de Universidad","GESTION UNIVERSIDAD");
            Application.Exit();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cursos fCursos = new Form_Cursos();
            fCursos.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Matricula fMatriculas = new Form_Matricula();
            fMatriculas.Show();
        }

        private void nominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Nominas fNominas = new Form_Nominas();
            fNominas.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Notas fNotas = new Form_Notas();
            fNotas.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Profesores fProfesores = new Form_Profesores();
            fProfesores.Show();
        }
    }
}
