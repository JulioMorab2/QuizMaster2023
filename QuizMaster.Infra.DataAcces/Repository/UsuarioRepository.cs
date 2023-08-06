using QuizMaster.Dominio.Model.Abstractions;
using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Infra.DataAcces.Repository
{
    public class UsuarioRepository : BaseRepository<Usuarios>, IUsuarioRepository
    {
        public IEnumerable<Usuarios> ListarUsuario(int id)
        {
            try
            {
                using (var context = new QuizMasterEntities1())
                {
                    var resultado = (from ins in context.Usuarios select ins).ToList();
                    return resultado;
                }
            }
            catch (Exception ex) 
            {
                throw new NotImplementedException();
            }

        }
    }
}
