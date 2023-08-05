using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Dominio.Model.Abstractions
{
    public interface IPreguntasRepository: IBaseRepository<Preguntas>
    {
        IEnumerable<Preguntas> ListarPregunta(int id);   
    }
}
