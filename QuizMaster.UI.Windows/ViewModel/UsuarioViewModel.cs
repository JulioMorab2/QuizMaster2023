using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ViewModel
{
    public class UsuarioViewModel
    {
        public int IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public Nullable<bool> esProfesor { get; set; }
    }
}
