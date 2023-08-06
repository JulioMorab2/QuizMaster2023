using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ViewModel
{
    public class CuestionariosViewModel
    {
        public int IdCuestionario { get; set; }
        public int IdInstrucciones { get; set; }
        public string IndicadoresEvaluacion { get; set; }
        public string Nivel { get; set; }
        public string Curso { get; set; }
        public string Area { get; set; }
        public Nullable<decimal> PorcentajeAprendizaje { get; set; }
        public int IDQuimestre { get; set; }
        public int IDUsuario { get; set; }
        public int IDMateria { get; set; }
    }
}
