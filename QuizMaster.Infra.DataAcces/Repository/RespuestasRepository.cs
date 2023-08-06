using QuizMaster.Dominio.Model.Abstractions;
using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Infra.DataAcces.Repository
{
    public class RespuestasRepository: BaseRepository<Respuestas>, IRespuestasRepository
    {

        public IEnumerable<Respuestas> ListarRespuestas(int id)
        {
            try
            {
                using (var context = new QuizMasterEntities1())
                {
                    var resultado=(from res in context.Respuestas
                                   where res.IDPregunta== id
                                   select res ).ToList();
                    return resultado;

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Respuestas" + ex.Message);

            }

        }

    }
}
