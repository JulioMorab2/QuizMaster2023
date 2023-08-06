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
    public class CuestionariosController
    {
        private CuestionariosServices servicesCuestionarios;


        public CuestionariosController()
        {
            servicesCuestionarios = new CuestionariosServices();

        }
        public bool InsertarCuestionarios(CuestionariosViewModel cuestionariosViewModel)
        {
            Cuestionarios nuevoRegistro = new Cuestionarios();
            try
            {
                nuevoRegistro.IdInstrucciones = cuestionariosViewModel.IdInstrucciones;
                nuevoRegistro.IndicadoresEvaluacion = cuestionariosViewModel.IndicadoresEvaluacion;
                nuevoRegistro.Nivel = cuestionariosViewModel.Nivel;
                nuevoRegistro.Curso = cuestionariosViewModel.Curso;
                nuevoRegistro.Area = cuestionariosViewModel.Area;
                nuevoRegistro.PorcentajeAprendizaje = cuestionariosViewModel.PorcentajeAprendizaje;
                nuevoRegistro.IDQuimestre = cuestionariosViewModel.IDQuimestre;
                nuevoRegistro.IDUsuario = cuestionariosViewModel.IDUsuario;
                nuevoRegistro.IDMateria = cuestionariosViewModel.IDMateria;
                servicesCuestionarios.InsertarCuestionarios(nuevoRegistro);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Cuestionarios: " + ex.Message);

            }
        }

        public bool ActualizarCuestionarios(CuestionariosViewModel NuevoCuestionarios)
        {
            Cuestionarios nuevoRegistro = new Cuestionarios();
            try
            {
                nuevoRegistro.IdInstrucciones = NuevoCuestionarios.IdInstrucciones;
                nuevoRegistro.IndicadoresEvaluacion= NuevoCuestionarios.IndicadoresEvaluacion;
                nuevoRegistro.Nivel = NuevoCuestionarios.Nivel;
                nuevoRegistro.Curso = NuevoCuestionarios.Curso;
                nuevoRegistro.Area = NuevoCuestionarios.Area;
                nuevoRegistro.PorcentajeAprendizaje = NuevoCuestionarios.PorcentajeAprendizaje;
                nuevoRegistro.IDQuimestre = NuevoCuestionarios.IDQuimestre;
                nuevoRegistro.IDUsuario = NuevoCuestionarios.IDUsuario;
                nuevoRegistro.IDMateria = NuevoCuestionarios.IDMateria;
                servicesCuestionarios.ActualizarCuestionarios(nuevoRegistro);


                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Cuestionarios: " + ex.Message);

            }

        }

        public IEnumerable<CuestionariosViewModel> ListarCuestionarios()
        {
            var listaCuestionarios = servicesCuestionarios.ListarCuestionarios();
            List<CuestionariosViewModel> resultadoEnvio = new List<CuestionariosViewModel>();
            try
            {
                foreach (Cuestionarios item in listaCuestionarios)
                {
                    resultadoEnvio.Add(new CuestionariosViewModel
                    {
                        IdCuestionario = item.IdCuestionario,
                        IdInstrucciones = item.IdInstrucciones,
                        IndicadoresEvaluacion= item.IndicadoresEvaluacion,
                        Nivel = item.Nivel,
                        Curso = item.Curso,
                        Area = item.Area,
                        PorcentajeAprendizaje = item.PorcentajeAprendizaje,
                        IDQuimestre = item.IDQuimestre,
                        IDUsuario = item.IDUsuario,
                        IDMateria = item.IDMateria,
                        
                        
                    });
                }
                return resultadoEnvio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Cuestionarios: " + ex.Message);
            }

        }
    }
}
