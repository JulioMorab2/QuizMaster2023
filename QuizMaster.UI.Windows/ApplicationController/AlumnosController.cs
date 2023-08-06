using QuizMaster.Dominio.Model.Entities;
using QuizMaster.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ApplicationController
{
    public class AlumnosController
    {
        
        public bool InsertarAlumnos(AlumnosViewModel nuevaAlumnos)
        {
            Alumnos vnuevaAlumnos = new Alumnos();
            try
            {
                vnuevaAlumnos.Nombres= nuevaAlumnos.Nombres;
                vnuevaAlumnos.Apellidos = nuevaAlumnos.Apellidos;
                vnuevaAlumnos.FechaNacimiento = nuevaAlumnos.FechaNacimiento;
                vnuevaAlumnos.NumIdentificacion = nuevaAlumnos.NumIdentificacion;
                vnuevaAlumnos.IDCat_TipoDocumento = nuevaAlumnos.IDCat_TipoDocumento;
                vnuevaAlumnos.IDAlumnoGrupo = nuevaAlumnos.IDAlumnoGrupo;
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Alumnoses: " + ex.Message);

            }
        }
    }
}
