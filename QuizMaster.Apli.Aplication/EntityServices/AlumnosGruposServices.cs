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
    public class AlumnosGruposServices
    {
        readonly IAlumnosGruposRepository alumnosGruposRepository;
        public AlumnosGruposServices()
        {
            alumnosGruposRepository = new AlumnosGruposRepository();
        }

        public IEnumerable<AlumnosGrupos> ListarAlumnosGrupos()
        {
            return alumnosGruposRepository.GetAll();
        }
        public void InsertarAlumnosGrupos(AlumnosGrupos Alumnos)
        {
            alumnosGruposRepository.Add(Alumnos);
        }

        public void ActualizarAlumnosGrupos(AlumnosGrupos Alumnos)
        {
            alumnosGruposRepository.Modify(Alumnos);
        }

        public void EliminarAlumnosGrupos(int id)
        {
            alumnosGruposRepository.Delete(id);

        }
        public IEnumerable<AlumnosGrupos> ListarAlumnosGruposActivas()
        {
            return alumnosGruposRepository.ListarAlumnosGrupos();
        }
    }
}
