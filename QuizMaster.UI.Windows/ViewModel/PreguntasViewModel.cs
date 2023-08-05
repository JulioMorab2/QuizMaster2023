using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ViewModel
{
    public class PreguntasViewModel
    {
        public int IDPregunta { get; set; }
        public string Pregunta { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> puntaje { get; set; }
        public int IdCuestionario { get; set; }
    }
}
