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
    public partial class IngresoAlumnos : MetroFramework.Forms.MetroForm
    {
        AlumnosController alumnosController;
        AlumnosGruposController alumnosGruposController;
        AlumnosViewModel alumnosViewModel = new AlumnosViewModel();
        Cat_TipoDocumentoController cat_TipoDocumentoController = new Cat_TipoDocumentoController();
        
        public IngresoAlumnos()
        {
            InitializeComponent();
            alumnosController= new AlumnosController();
            alumnosGruposController= new AlumnosGruposController();
            cargaComboIDAlumnoGrupo();
            cargaComboIDCat_TipoDocumento();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            alumnosViewModel.Nombres                = txtNombres.Text;
            alumnosViewModel.Apellidos				= txtApellidos.Text;
            alumnosViewModel.FechaNacimiento        = dateFechaNacimiento.Value;
            alumnosViewModel.NumIdentificacion		= txtNumIdentificacion.Text;
            alumnosViewModel.IDCat_TipoDocumento	= int.Parse(cbIDCat_TipoDocumento.SelectedValue.ToString());
            alumnosViewModel.IDAlumnoGrupo			= int.Parse(cbIDAlumnoGrupo.SelectedValue.ToString());


            InsertarAlumnos();


            LimpiarForm();
       

          
        }


        private void InsertarAlumnos()
        {
            if (alumnosController.InsertarAlumnos(alumnosViewModel))
            {
                MessageBox.Show("Alumno Insertada correctamente");
            }
            else
            {
                MessageBox.Show("Error al Insertada Alumnos");
            }
        }

        public void LimpiarForm()
        {
            txtNombres.Text="";
            txtApellidos.Text = "";
            //dateFechaNacimiento.Value = "";
            txtNumIdentificacion.Text = "";
        }

        private void IngresoAlumnos_Load(object sender, EventArgs e)
        {
            cargaComboIDAlumnoGrupo();
            cargaComboIDCat_TipoDocumento();
        }
        public void cargaComboIDCat_TipoDocumento()
        {
            cbIDCat_TipoDocumento.DataSource = cat_TipoDocumentoController.ListarCat_TipoDocumento();
            cbIDCat_TipoDocumento.DisplayMember = "descripcionCombo";
            cbIDCat_TipoDocumento.ValueMember = "IDCat_TipoDocumento";
        }

        public void cargaComboIDAlumnoGrupo()
        {
           cbIDAlumnoGrupo.DataSource = alumnosGruposController.ListarAlumnosGrupos();
            cbIDAlumnoGrupo.DisplayMember = "descripcionCombo";
            cbIDAlumnoGrupo.ValueMember = "IDAlumnoGrupo";
        }
    }
}
