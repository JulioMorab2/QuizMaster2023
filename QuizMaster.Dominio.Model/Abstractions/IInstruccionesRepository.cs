﻿using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Dominio.Model.Abstractions
{
    public interface IInstruccionesRepository : IBaseRepository<Instrucciones>
    {
        IEnumerable<Instrucciones> ListarInstrucciones();
    }
    
}
