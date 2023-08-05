using QuizMaster.Dominio.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuizMaster.Infra.DataAcces.Repository
{

    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
        {
            public void Add(TEntity entity)
            {
                try
                {

                    using (var context = new QuizMasterEntities1())
                    {
                        context.Set<TEntity>().Add(entity);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede guardar el registro: " + ex.Message);
                }
            }


            public void Delete(int id)
            {
                try
                {

                    using (var context = new QuizMasterEntities1())
                    {
                        var entity = context.Set<TEntity>().Find(id);
                        context.Set<TEntity>().Remove(entity);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede Eliminar el registro: " + ex.Message);
                }
            }

            public void Delete(TEntity entity)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public IEnumerable<TEntity> GetAll()
            {
                try
                {

                    using (var context = new QuizMasterEntities1())
                    {
                        return context.Set<TEntity>().ToList();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede Listar los registros: " + ex.Message);
                }
            }

            public TEntity GetById(int id)
            {
                try
                {

                    using (var context = new QuizMasterEntities1())
                    {
                        return context.Set<TEntity>().Find(id);

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede Eliminar el registro: " + ex.Message);
                }
            }

            public void Modify(TEntity entity)
            {
                try
                {

                    using (var context = new QuizMasterEntities1())
                    {
                        context.Entry(entity).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede actualizar el registro: " + ex.Message);
                }
            }
    }
}



