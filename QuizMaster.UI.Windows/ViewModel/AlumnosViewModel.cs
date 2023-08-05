using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ViewModel
{
    public class AlumnosViewModel
    {
        public int IDAlumno { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string NumIdentificacion { get; set; }
        public int IDCat_TipoDocumento { get; set; }
        public int IDAlumnoGrupo { get; set; }

        public virtual AlumnosGrupos AlumnosGrupos { get; set; }
        public virtual Cat_TipoDocumento Cat_TipoDocumento { get; set; }
        //public virtual ICollection<AsignacionCuestionario> AsignacionCuestionario { get; set; }
    }
}
