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
    public class CuestionariosServices
    {
        readonly ICuestionariosRepository cuestionariosRepository;

        public CuestionariosServices()
        {
            cuestionariosRepository = new CuestionariosRepository();

        }
        public IEnumerable<Cuestionarios> ListarCuestionarios()
        {
            return cuestionariosRepository.GetAll();
        }

        public void InsertarCuestionarios(Cuestionarios cuestionarios)
        {
            cuestionariosRepository.Add(cuestionarios);
        }

        public void ActualizarCuestionarios(Cuestionarios cuestionarios)
        {
            cuestionariosRepository.Modify(cuestionarios);
        }

        public void EliminarCuestionarios(int id)
        {
            cuestionariosRepository.Delete(id);

        }
        public IEnumerable<Cuestionarios> ListarCuestionariosActivos(int id)
        {
            return cuestionariosRepository.ListarCuestionario(id);
        }


    }
}
