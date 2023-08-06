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

namespace QuizMaster.UI.Windows.Forms
{
  

    public partial class FormQuimestres : Form
    {
        private QuimestreViewModel quimestreViewModel;
        private QuimestreController quimestreController;
        public FormQuimestres()
        {
            InitializeComponent();
            quimestreViewModel = new QuimestreViewModel();
            quimestreController = new QuimestreController();
        }

        private void InsertarQuimestres()
        {
            if (quimestreController.InsertarQuimestre(quimestreViewModel))
            {
                MessageBox.Show("Quimestre Insertada correctamente");
            }
            else
            {
                MessageBox.Show("Error al Insertar Quimestre");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            //if (quimestreController.InsertarQuimestre(quimestreViewModel))
            //{
            //    MessageBox.Show("Quimestre Insertado correctamente");
            //}
            //else
            //{
            //    MessageBox.Show("Error al Insertada Quimestre");
            //}

        }

        private void btnQuimestre_Click(object sender, EventArgs e)
        {
            quimestreViewModel.DescQuimestre= txbQuimestre.Text;

            InsertarQuimestres();

            LimpiarForm();
            ListarQuimestres();
        }
        private void LimpiarForm()
        {
            txbQuimestre.Text = "";
        }
        private void ListarQuimestres()
        {
            dgvQuimestre.DataSource = quimestreController.ListarQuimestre();

        }

        private void txbQuimestre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    //private void textBox1_TextChanged(object sender, EventArgs e)
    //{
    //    quimestreViewModel.DescQuimestre = rtextInstruccion.Text;

    //    InsertarInstrucciones();

    //    LimpiarForm();
    //    ListarInstrucciones();
    //    //activarforma();

    //}

    //private void btnQuimestre_Click(object sender, EventArgs e)
    //{
    //    QuimestreViewModel.Texto = rtextInstruccion.Text;

    //    InsertarInstrucciones();

    //    LimpiarForm();
    //    ListarInstrucciones();
    //    //activarforma();
    //}
