﻿using System;
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
    public partial class Form_Alumnos : Form
    {
        public Form_Alumnos()
        {
            InitializeComponent();
        }

        private void Form_Alumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.relaccionesxsd.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'relaccionesxsd.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.relaccionesxsd.Alumnos);

        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.relaccionesxsd);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.AlumnosTableAdapter alumnos = new RelaccionesxsdTableAdapters.AlumnosTableAdapter();
            alumnos.InsertarAlumno(dNITextBox.Text, apellidosTextBox.Text, nombreTextBox.Text, fechaNacimientoTextBox.Text, domicilioTextBox.Text, codigoPostalTextBox.Text, telefonoTextBox.Text, e_mailTextBox.Text, fechaTituloTextBox.Text, nombreTituloTextBox.Text, centroAcademicoTextBox.Text);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.AlumnosTableAdapter alumnos = new RelaccionesxsdTableAdapters.AlumnosTableAdapter();
            if (string.IsNullOrEmpty(dNITextBox.Text)||string.IsNullOrWhiteSpace(dNITextBox.Text))
            {
                MessageBox.Show("No se permite guardar con un DNI vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                alumnos.InsertarAlumno(dNITextBox.Text, apellidosTextBox.Text, nombreTextBox.Text, fechaNacimientoTextBox.Text, domicilioTextBox.Text, codigoPostalTextBox.Text, telefonoTextBox.Text, e_mailTextBox.Text, fechaTituloTextBox.Text, nombreTituloTextBox.Text, centroAcademicoTextBox.Text);
                MessageBox.Show("Alumno insertado con exito.", "CORRECTO", MessageBoxButtons.OK);
                dNITextBox.Clear();
                apellidosTextBox.Clear();
                nombreTituloTextBox.Clear();
                fechaTituloTextBox.Clear();
                domicilioTextBox.Clear();
                codigoPostalTextBox.Clear();
                telefonoTextBox.Clear();
                e_mailTextBox.Clear();
                fechaTituloTextBox.Clear();
                nombreTituloTextBox.Clear();
                centroAcademicoTextBox.Clear();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            RelaccionesxsdTableAdapters.AlumnosTableAdapter alumnos = new RelaccionesxsdTableAdapters.AlumnosTableAdapter();
            if (string.IsNullOrEmpty(dNITextBox.Text) || string.IsNullOrWhiteSpace(dNITextBox.Text))
            {
                MessageBox.Show("No se permite borrar con un DNI vacio.", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                alumnos.BorrarAlumno(dNITextBox.Text);
                MessageBox.Show("Alumno borrado correctamente.", "CORRECTO", MessageBoxButtons.OK);
                dNITextBox.Clear();
                apellidosTextBox.Clear();
                nombreTituloTextBox.Clear();
                fechaTituloTextBox.Clear();
                domicilioTextBox.Clear();
                codigoPostalTextBox.Clear();
                telefonoTextBox.Clear();
                e_mailTextBox.Clear();
                fechaTituloTextBox.Clear();
                nombreTituloTextBox.Clear();
                centroAcademicoTextBox.Clear();
            }
        }
    }
}
