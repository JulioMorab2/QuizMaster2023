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
    public partial class FormCat_TipoDocumento : Form
    {
        private Cat_TipoDocumentoController cat_TipoDocumentoController; //controlador
        private Cat_TipoDocumentoViewModel cat_TipoDocumentoViewModel; //objeto a enviar
        public FormCat_TipoDocumento()
        {
            InitializeComponent();
            cat_TipoDocumentoController = new Cat_TipoDocumentoController(); //acceso al nivel del aplicationController
            ListarCat_TipoDocumento();
        }

        private void InsertarCat_TipoDocumento()
        {
            if (cat_TipoDocumentoController.InsertarCat_TipoDocumento(cat_TipoDocumentoViewModel))
            {
                MessageBox.Show("cat_TipoDocumento Insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al Insertada cat_TipoDocumento");
            }
        }

        private void ListarCat_TipoDocumento()
        {
            dgvCat_TipoDocumento.DataSource = cat_TipoDocumentoController.ListarCat_TipoDocumento();
        }
        private void LimpiarForm()
        {

            txtBIDCat_TipoDocumento.Text = "";
            txtDescripcion.Text = "";
            cbxEstado.Text = "";
            cbxEstado.Enabled = false;  

            
        }
        private void Activarforma()
        {
            dgvCat_TipoDocumento.Enabled = true;
            gbxCat_TipoDocumento.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxCat_TipoDocumento.Enabled = true;
            dgvCat_TipoDocumento.Enabled=false; 

        }

        private void FrmCat_TipoDocumento_Load(object sender, EventArgs e)
        {
            ListarCat_TipoDocumento();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cat_TipoDocumentoViewModel = new Cat_TipoDocumentoViewModel();
            cat_TipoDocumentoViewModel.Descripcion = txtDescripcion.Text;
            //cat_TipoDocumentoViewModel.Estado = txtDescripcion.Text;
            if (cbxEstado.Checked)
            {
                cat_TipoDocumentoViewModel.Estado = true;
            }
            else
            {
                cat_TipoDocumentoViewModel.Estado = false;
            }
            if (txtBIDCat_TipoDocumento.Text != "")
            {
                cat_TipoDocumentoViewModel.IDCat_TipoDocumento= int.Parse(txtBIDCat_TipoDocumento.Text);
                cat_TipoDocumentoController.ActualizarCat_TipoDocumento(cat_TipoDocumentoViewModel);
            }
            else
            {
                //InsertarCategoria();
                InsertarCat_TipoDocumento();
            }
            LimpiarForm();
            ListarCat_TipoDocumento();
            
            Activarforma();
        }

        private void gbxCat_TipoDocumento_Enter(object sender, EventArgs e)
        {

        }
    }
}
