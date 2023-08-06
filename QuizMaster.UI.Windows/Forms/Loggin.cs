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
    public partial class Loggin : MetroFramework.Forms.MetroForm
    {
        public UsuariosViewModel viewModelUsuarios;
        public UsuariosController controllerUsuarios;
        MDIQuizMaster childFormPrincipal = new MDIQuizMaster();
        public Loggin()
        {
            InitializeComponent();
            viewModelUsuarios=new UsuariosViewModel();
            controllerUsuarios= new UsuariosController();
        }

        private void Loggin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void metroButton1_Click(object sender, EventArgs e)
        {
           if(controllerUsuarios.BuscarUsusarios(mtxtUsuarios.Text, mtxtUsuariocontraseña.Text))
            {

                //MessageBox.Show("Ususario activo");
               
               
                //childFormCategoria.MdiParent = this;
                childFormPrincipal.Show();
                //this.Close();



            }

        }
    }
}
