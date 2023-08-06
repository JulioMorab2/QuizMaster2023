using QuizMaster.Dominio.Model.Abstractions;
using QuizMaster.Dominio.Model.Entities;
using QuizMaster.Infra.DataAcces.Repository;
using QuizMaster.Infra.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Infra.DataAcces.Repository
{
    public class QuimestreRepository : BaseRepository<Quimestre>, IQuimestreRepository
    {
        public IEnumerable<Quimestre> ListarQuimestres()
        {
            try
            {
                using (var context = new QuizMasterEntities1())
                {
                    var resultado = (from ins in context.Quimestre
                                         // where ins.IdQuimestre == idCuestionario
                                     select ins).ToList();
                    return resultado;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Quimestre " + ex.Message);
            }

        }
    }
}
