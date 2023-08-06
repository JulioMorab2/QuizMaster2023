using QuizMaster.UI.Windows.ApplicationController;
using QuizMaster.UI.Windows.ViewModel;
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
    public partial class FormularioIngresoPreguntasRespuestas : Form
    {
        private PreguntasController preguntasController;
        private PreguntasViewModel preguntasViewModel;
        private RespuestasController respuestasController;
        private RespuestasViewModel respuestasViewModel;
        public FormularioIngresoPreguntasRespuestas()
        {
            InitializeComponent();
            preguntasController = new PreguntasController();
            respuestasController = new RespuestasController();
            CargarCuestionarios();
        }

        private void CargarCuestionarios() 
        {
            var cuestionarios = new CuestionariosController().ListarCuestionarios();
            comboBoxListaDeCuestionarios.DataSource = cuestionarios;
            comboBoxListaDeCuestionarios.ValueMember = "IdCuestionario";
            comboBoxListaDeCuestionarios.DisplayMember = "IdInstrucciones";
        }

        private void InsertarPreguntaRespuestas()
        {
            if (respuestasController.InsertarRespuestas(respuestasViewModel))
            {
                MessageBox.Show("Pregunta y Respuestas ingreadaso correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar el pregunta y respuestas");
            }
        }

        private void ListarPreguntaRespuestas()
        {

            dgvImprimirPreguntaRespuestas.DataSource = respuestasController.ListarRespuestas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se hace clic en labelTextoSeleccionCorrecta
        }

        private void FormularioIngresoPreguntasRespuestas_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se carga FormularioIngresoPreguntasRespuestas
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardarPreguntasRespuesta_Click(object sender, EventArgs e)
        {
            respuestasViewModel = new RespuestasViewModel();
            preguntasViewModel = new PreguntasViewModel();

            if (comboBoxListaDeCuestionarios.SelectedValue != null && int.TryParse(comboBoxListaDeCuestionarios.SelectedValue.ToString(), out int IdCuestionario))
            {
                preguntasViewModel.IdCuestionario = IdCuestionario;
            }
            else
            {
                MessageBox.Show("Seleccione un Cuestionario válido");
                return;
            }

            preguntasViewModel.Pregunta = textBoxparaEscribirPregunta.Text;

            // Respuesta 1
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta1.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta1.Checked;

            // Respuesta 2
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta2.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta2.Checked;

            // Respuesta 3
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta3.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta3.Checked;

            // Respuesta 4
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta4.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta4.Checked;

            InsertarPreguntaRespuestas();
            ListarPreguntaRespuestas();



        }





    }
}
