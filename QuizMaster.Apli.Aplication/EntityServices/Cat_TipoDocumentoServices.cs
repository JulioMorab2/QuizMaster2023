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
    public class Cat_TipoDocumentoServices
    {
        readonly ICat_TipoDocumentoRepository cat_TipoDocumentoRepository;
        public Cat_TipoDocumentoServices()
        {
            cat_TipoDocumentoRepository = new Cat_TipoDocumentoRepository();  


        }

        public IEnumerable<Cat_TipoDocumento> Listarcat_TipoDocumento()
        {
            return cat_TipoDocumentoRepository.GetAll();
        }

        public void Insertarcat_TipoDocumento(Cat_TipoDocumento cat_TipoDocumento)
        {
            cat_TipoDocumentoRepository.Add(cat_TipoDocumento); 
        }

        public void Actualizarcat_TipoDocumento(Cat_TipoDocumento cat_TipoDocumento)
        {
            cat_TipoDocumentoRepository.Modify(cat_TipoDocumento);
        }

        public void Eliminarcat_TipoDocumento(int id)
        {
            cat_TipoDocumentoRepository.Delete(id);

        }
        public IEnumerable<Cat_TipoDocumento> Listarcat_TipoDocumentoActivos()
        {
            return cat_TipoDocumentoRepository.ListarCat_TipoDocumentoActivas();
        }

    }
}
