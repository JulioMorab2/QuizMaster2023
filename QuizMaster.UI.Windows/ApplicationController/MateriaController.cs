using QuizMaster.Apli.Aplication.EntityServices;
using QuizMaster.Dominio.Model.Entities;
using QuizMaster.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.UI.Windows.ApplicationController
{
    public class MateriaController
    {
        private MateriasServices servicesMaterias;

        public MateriaController()
        {

            servicesMaterias = new MateriasServices();
        }

        public bool InsertarMaterias(MateriaViewModel nuevaMaterias)
        {
            Materias vnuevaMateria = new Materias();
            try
            {
                vnuevaMateria.IDMateria = nuevaMaterias.IDMateria;
                vnuevaMateria.NombreMateria = nuevaMaterias.NombreMateria;
                servicesMaterias.InsertarMaterias(vnuevaMateria);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Materia: " + ex.Message);

            }
        }

        public bool ActualizarMaterias(MateriaViewModel nuevaMaterias)
        {
            Materias vnuevaMateria = new Materias();
            try
            {
                vnuevaMateria.IDMateria = nuevaMaterias.IDMateria;
                vnuevaMateria.NombreMateria = vnuevaMateria.NombreMateria;
                servicesMaterias.ActualizarMaterias(vnuevaMateria);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Materias: " + ex.Message);

            }
        }

        public IEnumerable<MateriaViewModel> ListarMaterias()
        {
            var listaMaterias = servicesMaterias.ListarMaterias();
            List<MateriaViewModel> resultadoEnvio = new List<MateriaViewModel>();
            try
            {
                foreach (Materias item in listaMaterias)
                {
                    resultadoEnvio.Add(new MateriaViewModel
                    {
                        IDMateria = item.IDMateria,
                        NombreMateria = item.NombreMateria
                    });
                }
                return resultadoEnvio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Materias: " + ex.Message);
            }

        }
    }
}
