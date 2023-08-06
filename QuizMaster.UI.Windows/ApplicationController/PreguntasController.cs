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
    public class PreguntasController
    {
        private PreguntasServices servicesPreguntas;

        public bool  InsertarPregunta(PreguntasViewModel NuevaPregunta)
        {
            Preguntas nuevoRegistro = new Preguntas();
            try
            {
                nuevoRegistro.Pregunta = NuevaPregunta.Pregunta;
                nuevoRegistro.puntaje = NuevaPregunta.puntaje;
                nuevoRegistro.IdCuestionario = NuevaPregunta.IdCuestionario;

                servicesPreguntas.InsertarPregunta(nuevoRegistro);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Pregunta: " + ex.Message);

            }
        }
    }
}
