using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Dominio.Model.Abstractions
{
    public interface ICat_TipoDocumentoRepository : IBaseRepository<Cat_TipoDocumento>
    {
        IEnumerable<Cat_TipoDocumento> ListarCat_TipoDocumentoActivas();

    }
}
