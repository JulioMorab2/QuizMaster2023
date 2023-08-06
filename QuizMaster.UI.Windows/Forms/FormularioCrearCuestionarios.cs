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
    public partial class FormularioCrearCuestionarios : Form
    {
        private CuestionariosController cuestionariosController;
        private CuestionariosViewModel cuestionariosViewModel;
        public FormularioCrearCuestionarios()
        {
            InitializeComponent();
            cuestionariosController = new CuestionariosController();
            CargarInstrucciones();
            CargarQuimestre();
            CargarUsuario();
            CargarMateria();
        }


        //metodo para cargar en los combo box

        private void CargarInstrucciones()
        { 
            var instrucciones = new InstruccionesController().ListarInstrucciones();
            comboBoxInstrucciones.DataSource = instrucciones;
            comboBoxInstrucciones.ValueMember = "IdInstrucciones";
            comboBoxInstrucciones.DisplayMember = "Texto";
        }

        private void CargarQuimestre()
        {
            var quimestres = new QuimestreController().ListarQuimestre();
            comboBoxQuimestre.DataSource = quimestres;
            comboBoxQuimestre.ValueMember = "IDQuimestre";
            comboBoxQuimestre.DisplayMember = "DescQuimestre";
        }



        private void CargarUsuario()
        {
            var usuarios = new UsuarioController().ListarUsuarios();
            comboBoxUsuario.DataSource = usuarios;
            comboBoxUsuario.ValueMember = "IDUsuario";
            comboBoxUsuario.DisplayMember = "NombreUsuario";

        }

        private void CargarMateria()
        {
            var materias = new MateriaController().ListarMaterias();
            comboBoxMateria.DataSource = materias;
            comboBoxMateria.ValueMember = "IDMateria";
            comboBoxMateria.DisplayMember = "NombreMateria";

        }


        private void InsertarCuestionario() 
        {
            if (cuestionariosController.InsertarCuestionarios(cuestionariosViewModel))
            {
                MessageBox.Show("Cuestionario Insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar el cuestionario");
            }
        }



        private void ListarCuestionarios()
        {
            dgvImprimirCuestionario.DataSource = cuestionariosController.ListarCuestionarios();
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

        private void buttonGuardarCuestionario_Click(object sender, EventArgs e)
        {
            cuestionariosViewModel = new CuestionariosViewModel();

            if (comboBoxInstrucciones.SelectedValue != null && int.TryParse(comboBoxInstrucciones.SelectedValue.ToString(), out int IdInstrucciones))
            {
                cuestionariosViewModel.IdInstrucciones = IdInstrucciones;
            }
            else
            {
                MessageBox.Show("Seleccione una Instruccion válida");
                return;
            }

            cuestionariosViewModel.IndicadoresEvaluacion = textBoxParaIndicadoresEvaluacion.Text;
            cuestionariosViewModel.Nivel = textBoxParaNivel.Text;
            cuestionariosViewModel.Curso = textBoxCurso.Text;
            cuestionariosViewModel.Area = textBoxArea.Text;
            cuestionariosViewModel.PorcentajeAprendizaje = decimal.Parse(textBoxPorcentajeAprendizaje.Text);


            if (comboBoxQuimestre.SelectedValue != null && int.TryParse(comboBoxQuimestre.SelectedValue.ToString(), out int IDQuimestre))
            {
                cuestionariosViewModel.IDQuimestre = IDQuimestre;
            }
            else
            {
                MessageBox.Show("Seleccione un Quimestre válido");
                return;
            }



            if (comboBoxUsuario.SelectedValue != null && int.TryParse(comboBoxUsuario.SelectedValue.ToString(), out int IDUsuario))
            {
                cuestionariosViewModel.IDUsuario = IDUsuario;
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario válido");
                return;
            }



            if (comboBoxMateria.SelectedValue != null && int.TryParse(comboBoxMateria.SelectedValue.ToString(), out int IDMateria))
            {
                cuestionariosViewModel.IDMateria = IDMateria;
            }
            else
            {
                MessageBox.Show("Seleccione una Materia válida");
                return;
            }


            InsertarCuestionario();
            ListarCuestionarios();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonListarCuestionario_Click(object sender, EventArgs e)
        {
            ListarCuestionarios();
        }
    }
}
