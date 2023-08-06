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
    public class QuimestreServices
    {
        readonly IQuimestreRepository quimestreRepository;
        public QuimestreServices()
        {
            quimestreRepository = new QuimestreRepository();
        }

        public IEnumerable<Quimestre> ListarQuimestres()
        {
            return quimestreRepository.GetAll();
        }
        public void InsertarQuimestre(Quimestre Quimestre)
        {
            quimestreRepository.Add(Quimestre);
        }

        public void ActualizarQuimestre(Quimestre Quimestre)
        {
            quimestreRepository.Modify(Quimestre);
        }

        public void EliminarQuimestre(int id)
        {
            quimestreRepository.Delete(id);

        }
        public IEnumerable<Quimestre> ListarQuimestresActivas()
        {
            return quimestreRepository.ListarQuimestres();
        }
    }
}
