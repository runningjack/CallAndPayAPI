using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IStringTitle
    {
        string Title { get; set; }
    }
    public interface IRepository<T>
    {
        int Insert(T entity);
        int Delete(T entity);
        int Update(T entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        T GetById(object id);
    }

    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly CallAndPayDbContext _dbContext;
        private int _s;

        public BaseRepository()
        {
            _dbContext = new CallAndPayDbContext();
        }

        public int Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _s = _dbContext.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public TEntity GetById(object id)
        {
            return _dbContext.Set<TEntity>().Find(id);
            //return _dbContext.Set<TEntity>().Find(id);
        }

        //public virtual TEntity GetByName(string name)
        //{
        //    return (from e in _dbContext.Set<TEntity>()
        //            where e.Title == name
        //            select e).SingleOrDefault();
        //}

        public int Insert(TEntity entity)
        {
           
            _dbContext.Set<TEntity>().Add(entity);
            _s = _dbContext.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int Update(TEntity entity)
        {
           // _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            {
                _s = _dbContext.SaveChanges();
                if (_s > 0)
                {
                    return 1;
                }
           }
            
            return 0;
        }

        public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }
    }
}
