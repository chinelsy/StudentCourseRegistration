using StudentCourseEFcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudentCourseEFcore.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(int id, string name);
        Task<TEntity> GetAsync(int id);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);
        void AddRange(IList<TEntity> entities);
        Task AddRangeAsync(IList<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteRange(IList<TEntity> entities);
    }
}
