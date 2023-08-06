using QuizMaster.Dominio.Model.Abstractions;
using QuizMaster.Dominio.Model.Entities;
using QuizMaster.Infra.DataAcces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Apli.Aplication.EntityServices
{
    public class UsuariosServices
    {
        readonly IUsusarioRepository userRepository;

        public UsuariosServices()
        {
            userRepository = new UsuariosRepository();

        }

        public bool BuscarUsuario(String nameuser, String passw)
        {
            return userRepository.BuscarUsuario( nameuser,  passw);
        }
    }
}
