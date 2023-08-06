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
    public class UsuarioServices
    {
        readonly IUsuarioRepository usuarioRepository;

        public UsuarioServices()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public IEnumerable<Usuarios> ListarUsuarios()
        {
            return usuarioRepository.GetAll();
        }

        public void InsertarUsuario(Usuarios usuarios)
        {
            usuarioRepository.Add(usuarios);
        }

        public void ActualizarUsuario(Usuarios usuarios)
        {
            usuarioRepository.Modify(usuarios);
        }

        public void EliminarUsuario(int id)
        {
            usuarioRepository.Delete(id);
        }

        public IEnumerable<Usuarios> ListarUsuariosActivos(int id)
        {
            return usuarioRepository.ListarUsuario(id);
        }
    }
}
