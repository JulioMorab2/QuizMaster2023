using QuizMaster.Apli.Aplication.EntityServices;
using QuizMaster.Dominio.Model.Entities;
using QuizMaster.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using QuizMaster.UI.Windows.ViewModel;

namespace QuizMaster.UI.Windows.ApplicationController
{
    
    public class Cat_TipoDocumentoController
    {
        private Cat_TipoDocumentoServices servicesCat_TipoDocumento;


        public Cat_TipoDocumentoController()
        {
            servicesCat_TipoDocumento= new Cat_TipoDocumentoServices(); 

        }
        public bool InsertarCat_TipoDocumento(Cat_TipoDocumentoViewModel NuevoCat_TipoDocumento)
        {
            Cat_TipoDocumento nuevoRegistro = new Cat_TipoDocumento();
            try
            {
                nuevoRegistro.Descripcion = NuevoCat_TipoDocumento.Descripcion;
                nuevoRegistro.Estado =NuevoCat_TipoDocumento.Estado;

                servicesCat_TipoDocumento.Insertarcat_TipoDocumento(nuevoRegistro);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Cat_TipoDocumento: " + ex.Message);

            }
        }

        public bool ActualizarCat_TipoDocumento(Cat_TipoDocumentoViewModel NuevoCat_TipoDocumento)
        {
            Cat_TipoDocumento nuevoRegistro = new Cat_TipoDocumento();
            try
            {
                nuevoRegistro.Descripcion = NuevoCat_TipoDocumento.Descripcion;
                nuevoRegistro.Estado = NuevoCat_TipoDocumento.Estado;
                servicesCat_TipoDocumento.Actualizarcat_TipoDocumento(nuevoRegistro);
                

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Cat_TipoDocumento: " + ex.Message);

            }
           
        }

        public IEnumerable<Cat_TipoDocumentoViewModel> ListarCat_TipoDocumento()
        {
            var listaCat_TipoDocumento = servicesCat_TipoDocumento.Listarcat_TipoDocumento();
            List<Cat_TipoDocumentoViewModel> resultadoEnvio = new List<Cat_TipoDocumentoViewModel>();
            try
            {
                foreach (Cat_TipoDocumento item in listaCat_TipoDocumento)
                {
                    resultadoEnvio.Add(new Cat_TipoDocumentoViewModel
                    {
                        IDCat_TipoDocumento = item.IDCat_TipoDocumento,
                        Descripcion = item.Descripcion,
                        Estado = item.Estado
                    });
                }
                return resultadoEnvio;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Cat_TipoDocumento: " + ex.Message);
            }

        }
       



    }
}
