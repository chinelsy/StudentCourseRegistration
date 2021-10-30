using Microsoft.EntityFrameworkCore;
using StudentCourseEFcore.Interface.Repository;
using StudentCourseEFcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StudentCourseEFcore.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private DbSet<TEntity> _entity;
        public Repository(DbContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _entity.Add(entity);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
        }

        public void AddRange(IList<TEntity> entities)
        {
            _entity.AddRange(entities);
        }

        public async Task AddRangeAsync(IList<TEntity> entities)
        {
            await _entity.AddRangeAsync(entities);
        }

        public void Delete(TEntity entity)
        {
            _entity.Remove(entity); 
        }

        public void DeleteRange(IList<TEntity> entities)
        {
            _entity.RemoveRange(entities);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _entity.Where(predicate).AsQueryable();
        }

        public TEntity Get(int id, string name)
        {
            return _entity.Find(id, name); 
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entity.AsQueryable();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _entity.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            //_entity.Update(entity);
        }
    }
}
