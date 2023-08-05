using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Dominio.Model.Abstractions
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Modify(TEntity entity);
        void Delete(int id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
    }
}
