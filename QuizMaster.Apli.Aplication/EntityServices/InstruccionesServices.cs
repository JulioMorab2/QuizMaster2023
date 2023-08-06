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
    public class InstruccionesServices
    {
        readonly IInstruccionesRepository instruccionesRepository;
        public InstruccionesServices()
        {
            instruccionesRepository = new InstruccionesRepository();
        }

        public IEnumerable<Instrucciones> ListarInstruccioness()
        {
            return instruccionesRepository.GetAll();
        }
        public void InsertarInstrucciones(Instrucciones Instrucciones)
        {
            instruccionesRepository.Add(Instrucciones);
        }

        public void ActualizarInstrucciones(Instrucciones Instrucciones)
        {
            instruccionesRepository.Modify(Instrucciones);
        }

        public void EliminarInstrucciones(int id)
        {
            instruccionesRepository.Delete(id);

        }
        public IEnumerable<Instrucciones> ListarInstruccionessActivas()
        {
            return instruccionesRepository.ListarInstrucciones();
        }
    }
}
