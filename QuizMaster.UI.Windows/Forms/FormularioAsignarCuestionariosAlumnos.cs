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
    public partial class FormularioAsignarCuestionariosAlumnos : Form
    {
        public FormularioAsignarCuestionariosAlumnos()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonParaAsignarYEnviar_Click(object sender, EventArgs e)
        {
            FormularioCrearCuestionarios formularioCrearCuestionarios = new FormularioCrearCuestionarios();
            formularioCrearCuestionarios.Show();
            this.Close();
        }
    }
}
