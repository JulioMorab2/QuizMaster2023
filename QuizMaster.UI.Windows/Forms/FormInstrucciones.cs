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
    public partial class FormInstrucciones : Form
    {

        private InstruccionesViewModel instruccionesviewModel;
        private InstruccionesController instruccionesController;
        public FormInstrucciones()
        {
            
            InitializeComponent();
            instruccionesviewModel = new InstruccionesViewModel();
            instruccionesController = new InstruccionesController();
        }

        private void InsertarInstrucciones()
        {
            if (instruccionesController.InsertarInstruccion(instruccionesviewModel))
            {
                MessageBox.Show("Instrución Insertada correctamente");
            }
            else
            {
                MessageBox.Show("Error al Insertada Instrución");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            instruccionesviewModel.Texto = rtextInstruccion.Text;

            InsertarInstrucciones();
            
            LimpiarForm();
            ListarInstrucciones();
            //activarforma();
        }
        private void LimpiarForm()
        {
            rtextInstruccion.Text = "";
        }
        private void ListarInstrucciones()
        {
            dgIntrucciones.DataSource = instruccionesController.ListarInstrucciones();

        }
    }
}
