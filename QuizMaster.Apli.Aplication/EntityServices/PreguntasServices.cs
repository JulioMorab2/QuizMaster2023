using QuizMaster.Dominio.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaster.Infra.DataAcces.Repository;
using QuizMaster.Dominio.Model.Entities;

namespace QuizMaster.Apli.Aplication.EntityServices
{
    public class PreguntasServices
    {
        readonly IPreguntasRepository preguntasRepository;
        public PreguntasServices()
        {
            preguntasRepository=  new PreguntasRepository();   

        }

        public IEnumerable<Preguntas> ListarPreguntas()
        {
            return preguntasRepository.GetAll();    
        }

        public void InsertarPregunta(Preguntas pregunta)
        {
            preguntasRepository.Add(pregunta);

        }

        public void ActualilzarPregunta(Preguntas pregunta)
        {
            preguntasRepository.Modify(pregunta);   

        }


    }
}
