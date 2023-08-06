using QuizMaster.Dominio.Model.Abstractions;
using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Infra.DataAcces.Repository
{
    public class UsuariosRepository:BaseRepository<Usuarios>, IUsusarioRepository
    {

        public bool BuscarUsuario(string nameuser, string passw)
        {
            try
            {
                using (var context = new QuizMasterEntities1())
                {
                    var resultado = (from res in context.Usuarios
                                     where res.NombreUsuario == nameuser
                                     && res.Contraseña == passw 
                                     select res).ToList();
                    if(resultado.Count > 0) {
                        return true;
                    }
                    else { return false; }
                    

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Usuario" + ex.Message);

            }

        }
    }
}
