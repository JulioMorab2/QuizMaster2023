using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosQuizMaster
{
    public partial class FormularioCrearCuestionarios : Form
    {
        public FormularioCrearCuestionarios()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormularioCrearCuestionarios_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrearPreguntas_Click(object sender, EventArgs e)
        {
            FormularioIngresoPreguntasRespuestas formularioIngresoPreguntasRespuestas = new FormularioIngresoPreguntasRespuestas();
            formularioIngresoPreguntasRespuestas.Show();
            this.Close();
        }

        private void buttonAsignarEstudiante_Click(object sender, EventArgs e)
        {
            FormularioAsignarCuestionariosAlumnos formularioAsignarCuestionariosAlumnos = new FormularioAsignarCuestionariosAlumnos();
            formularioAsignarCuestionariosAlumnos.Show();
            this.Close();
        }
    }
}
