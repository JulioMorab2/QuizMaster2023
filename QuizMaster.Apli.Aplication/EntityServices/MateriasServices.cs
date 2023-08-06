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
    public class MateriasServices
    {
        readonly IMateriasRepository materiasRepository;
        public MateriasServices()
        {
            materiasRepository = new MateriaRepository();
        }

        public IEnumerable<Materias> ListarMaterias()
        {
            return materiasRepository.GetAll();
        }
        public void InsertarMaterias(Materias Materias)
        {
            materiasRepository.Add(Materias);
        }

        public void ActualizarMaterias(Materias Materias)
        {
            materiasRepository.Modify(Materias);
        }

        public void EliminarMaterias(int id)
        {
            materiasRepository.Delete(id);

        }
        public IEnumerable<Materias> ListarMateriassActivas()
        {
            return materiasRepository.ListarMaterias();
        }
    }
}
