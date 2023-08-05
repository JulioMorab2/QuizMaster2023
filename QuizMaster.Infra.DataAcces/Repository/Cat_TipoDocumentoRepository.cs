using QuizMaster.Dominio.Model.Abstractions;
using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Infra.DataAcces.Repository
{
    public class Cat_TipoDocumentoRepository : BaseRepository<Cat_TipoDocumento>, ICat_TipoDocumentoRepository
    {
        public IEnumerable<Cat_TipoDocumento> ListarCat_TipoDocumentoActivas()
        {
            try
            {
                using (var context = new QuizMasterEntities1())
                {
                    var resultado = (from cat in context.Cat_TipoDocumento
                                     where cat.Estado == true
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
