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
    public class RespuestasServices
    {
        readonly IRespuestasRepository respuestasRepository;

        public RespuestasServices()
        {
            respuestasRepository= new RespuestasRepository();   

        }
        public IEnumerable<Respuestas> ListarRespuestas()
        {
            return respuestasRepository.GetAll();
        }

        public void InsertarRespuestas(Respuestas respuestas)
        {
            respuestasRepository.Add(respuestas);
        }

        public void ActualizarRespuestas(Respuestas respuestas)
        {
            respuestasRepository.Modify(respuestas);
        }

        public void EliminarRespuestas(int id)
        {
            respuestasRepository.Delete(id);

        }
        public IEnumerable<Respuestas> ListarRespuestasActivos(int id)
        {
            return respuestasRepository.ListarRespuestas(id);
        }
    }
}
