using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ViewModel
{
    public class RespuestasViewModel
    {
        public int IDRespuesta { get; set; }
        public Nullable<int> IDPregunta { get; set; }
        public string Respuesta { get; set; }
        public Nullable<bool> EsCorrecta { get; set; }

    }
}
