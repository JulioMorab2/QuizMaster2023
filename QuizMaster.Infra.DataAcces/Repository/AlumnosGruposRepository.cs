﻿using QuizMaster.Dominio.Model.Abstractions;
using QuizMaster.Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Infra.DataAcces.Repository
{
    public class AlumnosGruposRepository:BaseRepository<AlumnosGrupos>, IAlumnosGruposRepository
    {
        public IEnumerable<AlumnosGrupos> ListarAlumnosGrupos()
        {
            try
            {
                using (var context = new QuizMasterEntities1())
                {
                    var resultado = (from ins in context.AlumnosGrupos
                                     
                                     select ins).ToList();
                    return resultado;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Alumnos " + ex.Message);
            }

        }
    }
}