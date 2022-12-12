﻿using System.Linq.Expressions;

namespace WebApplication1.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UniversityContext _context;

        public Repository()
        {
            this._context = UniversityContext.Instance(); ;
        }
         
        public bool Add(TEntity Entity)
        {
            try
            {
                this._context.Set<TEntity>().Add(Entity);
                this._context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddRange(IEnumerable<TEntity> entity)
        {
            try
            {
                this._context.Set<TEntity>().AddRange(entity);
                this._context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this._context.Set<TEntity>().Where(predicate).ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return this._context.Set<TEntity>().Find(id);
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                this._context.Set<TEntity>().Remove(entity);
                this._context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveRange(IEnumerable<TEntity> entity)
        {
            try
            {
                this._context.Set<TEntity>().RemoveRange(entity);
                this._context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}
