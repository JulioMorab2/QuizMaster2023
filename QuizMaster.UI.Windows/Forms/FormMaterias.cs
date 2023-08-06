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
    public partial class FormMaterias : Form
    {
        private MateriaViewModel materiaViewModel;
        private MateriaController materiaController;
        public FormMaterias()
        {
            InitializeComponent();
            materiaViewModel = new MateriaViewModel();
            materiaController = new MateriaController();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (materiaController.InsertarMaterias(materiaViewModel))
            {
                MessageBox.Show("Materia Insertada correctamente");
            }
            else
            {
                MessageBox.Show("Error al Insertar ");
            }

        }
        private void InsertarMaterias()
        {
            if (materiaController.InsertarMaterias(materiaViewModel))
            {
                MessageBox.Show("Materia Insertada correctamente");
            }
            else
            {
                MessageBox.Show("Error al Insertar Materia");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            materiaViewModel.NombreMateria = txbMateria.Text;

            InsertarMaterias();

            LimpiarForm();
            ListarMaterias();
        }
        private void LimpiarForm()
        {
            txbMateria.Text = "";
        }
        private void ListarMaterias()
        {
            dgvMateria.DataSource = materiaController.ListarMaterias();

        }
    }
}
//        //private void dgvMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void txbMateria_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void FormMaterias_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
