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
    public class QuimestreController
    {
        private QuimestreServices servicesQuimestre;

        public QuimestreController()
        {

            servicesQuimestre = new QuimestreServices();
        }

        public bool InsertarQuimestre(QuimestreViewModel nuevaQuimestre)
        {
            Quimestre vnuevaQuimestre = new Quimestre();
            try
            {
                vnuevaQuimestre.IDQuimestre = nuevaQuimestre.IDQuimestre;
                vnuevaQuimestre.DescQuimestre= nuevaQuimestre.DescQuimestre;
                servicesQuimestre.InsertarQuimestre(vnuevaQuimestre);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Quimestrees: " + ex.Message);

            }
        }
        public IEnumerable<QuimestreViewModel> ListarQuimestre()
        {
            var listaQuimestres = servicesQuimestre.ListarQuimestres();
            List<QuimestreViewModel> resultadoEnvio = new List<QuimestreViewModel>();
            try
            {
                foreach ( Quimestre item in listaQuimestres)
                {
                    resultadoEnvio.Add(new QuimestreViewModel
                    {
                        IDQuimestre = item.IDQuimestre,
                        DescQuimestre = item.DescQuimestre
                    });
                }
                return resultadoEnvio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Quimestres: " + ex.Message);
            }

        }

    }
}
