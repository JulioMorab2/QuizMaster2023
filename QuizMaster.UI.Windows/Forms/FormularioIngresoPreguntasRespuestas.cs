using QuizMaster.Dominio.Model.Entities;
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

        private void InsertarPregunta()
        {
            if ( preguntasController.InsertarPregunta(preguntasViewModel) )
            {
                MessageBox.Show("Pregunta ingreasada correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Pregunta");
            }
        }

        private void InsertarRespuestas()
        {
            if (respuestasController.InsertarRespuestas(respuestasViewModel))
            {
                MessageBox.Show("Respuestas ingresada correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar Respuestas");
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
            
            preguntasViewModel = new PreguntasViewModel();

            preguntasViewModel.Pregunta = textBoxparaEscribirPregunta.Text;

            if (dateTimePickerFechaIngresoPandR.Value != null)
            {
                preguntasViewModel.fecha = dateTimePickerFechaIngresoPandR.Value;
            }
            else
            {
                // Si la fecha seleccionada es nula, decide qué acción tomar o asigna otro valor predeterminado si es necesario
                preguntasViewModel.fecha = null; // Opcionalmente puedes asignar otro valor predeterminado en lugar de null
            }

            preguntasViewModel.puntaje = decimal.Parse(textBoxPuntajeIngresoPandR.Text);


            if (comboBoxListaDeCuestionarios.SelectedValue != null && int.TryParse(comboBoxListaDeCuestionarios.SelectedValue.ToString(), out int IdCuestionario))
            {
                preguntasViewModel.IdCuestionario = IdCuestionario;
            }
            else
            {
                MessageBox.Show("Seleccione un Cuestionario válido");
                return;
            }

            InsertarPregunta();

            preguntasViewModel = new PreguntasViewModel();
            respuestasViewModel = new RespuestasViewModel();

            respuestasViewModel.IDPregunta = preguntasViewModel.IDPregunta;
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta1.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta1.Checked;
            InsertarRespuestas();

            respuestasViewModel.IDPregunta = preguntasViewModel.IDPregunta;
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta2.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta2.Checked;
            InsertarRespuestas();

            respuestasViewModel.IDPregunta = preguntasViewModel.IDPregunta;
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta3.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta3.Checked;
            InsertarRespuestas();

            respuestasViewModel.IDPregunta = preguntasViewModel.IDPregunta;
            respuestasViewModel.Respuesta = textBoxParaEscribirRespuesta4.Text;
            respuestasViewModel.EsCorrecta = radioButtonRespuesta4.Checked;
            InsertarRespuestas();



            ListarPreguntaRespuestas();



        }





    }
}
