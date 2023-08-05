using QuizMaster.Apli.Aplication.EntityServices;
using QuizMaster.Dominio.Model.Entities;
using QuizMaster.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ApplicationController
{
    public  class AlumnosGruposController
    {
        AlumnosGruposServices alumnosGruposServices;

        public AlumnosGruposController()
        {
            alumnosGruposServices= new AlumnosGruposServices();

        }

        

        public IEnumerable<AlumnosGruposViewModel> ListarAlumnosGrupos()
        {
            var listaAlumnosGrupos = alumnosGruposServices.ListarAlumnosGrupos();
            List<AlumnosGruposViewModel> resultadoEnvio = new List<AlumnosGruposViewModel>();
            try
            {
                foreach (AlumnosGrupos item in listaAlumnosGrupos)
                {
                    resultadoEnvio.Add(new AlumnosGruposViewModel
                    {
                        IDAlumnoGrupo = item.IDAlumnoGrupo,
                        Descripcion = item.Descripcion,
                        descripcionCombo=-item.IDAlumnoGrupo+".-"+item.Descripcion


                    });
                }
                return resultadoEnvio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar AlumnosGrupos: " + ex.Message);
            }

        }
    }
}
