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
    public class InstruccionesController
    {
        private InstruccionesServices servicesInstrucciones;

        public InstruccionesController()
        {

            servicesInstrucciones = new InstruccionesServices();
        }

        public bool InsertarInstruccion(InstruccionesViewModel nuevaInstruccion)
        {
            Instrucciones vnuevaInstruccion = new Instrucciones();
            try
            {
                vnuevaInstruccion.IdInstrucciones = nuevaInstruccion.IdIdInstrucciones;
                vnuevaInstruccion.Texto = nuevaInstruccion.Texto;
                servicesInstrucciones.InsertarInstrucciones(vnuevaInstruccion);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Instrucciones: " + ex.Message);

            }
        }

        public bool ActualizarInstrucciones(InstruccionesViewModel nuevaInstruccion)
        {
            Instrucciones vnuevaInstruccion = new Instrucciones();
            try
            {
                vnuevaInstruccion.IdInstrucciones = nuevaInstruccion.IdIdInstrucciones;
                vnuevaInstruccion.Texto = vnuevaInstruccion.Texto;
                servicesInstrucciones.ActualizarInstrucciones(vnuevaInstruccion);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Instrucciones: " + ex.Message);

            }
        }

        public IEnumerable<InstruccionesViewModel> ListarInstrucciones()
        {
            var listaInstrucciones = servicesInstrucciones.ListarInstruccioness();
            List<InstruccionesViewModel> resultadoEnvio = new List<InstruccionesViewModel>();
            try
            {
                foreach (Instrucciones item in listaInstrucciones)
                {
                    resultadoEnvio.Add(new InstruccionesViewModel
                    {
                        IdIdInstrucciones = item.IdInstrucciones,
                        Texto = item.Texto
                    });
                }
                return resultadoEnvio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Instrucciones: " + ex.Message);
            }

        }
        

    }
}
