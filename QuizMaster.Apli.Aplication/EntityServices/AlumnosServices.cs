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
    public class AlumnosServices
    {
        readonly IAlumnosRepository alumnosRepository;
        public AlumnosServices()
        {
            alumnosRepository = new AlumnosRepository();
        }

        public IEnumerable<Alumnos> ListarAlumnoss()
        {
            return alumnosRepository.GetAll();
        }
        public void InsertarAlumnos(Alumnos Alumnos)
        {
            alumnosRepository.Add(Alumnos);
        }

        public void ActualizarAlumnos(Alumnos Alumnos)
        {
            alumnosRepository.Modify(Alumnos);
        }

        public void EliminarAlumnos(int id)
        {
            alumnosRepository.Delete(id);

        }
        public IEnumerable<Alumnos> ListarAlumnossActivas(int id)
        {
            return alumnosRepository.ListarAlumnos(id);
        }
    }
}
