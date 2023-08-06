using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaster.Dominio.Model.Abstractions;

namespace QuizMaster.Infra.DataAcces.Repository
{
    public class PreguntasRepository : BaseRepository<Preguntas>, IPreguntasRepository
    {
        public IEnumerable<Preguntas> ListarPregunta(int id)
        {
            try
            {
                using (var context = new QuizMasterEntities1())
                {
                    var resultado = (from cat in context.Preguntas
                                     where cat.IdCuestionario == id 
                                     select cat).ToList();
                    return resultado;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Cat_TipoDocumento Activos" + ex.Message);
            }
        }
    }
}
