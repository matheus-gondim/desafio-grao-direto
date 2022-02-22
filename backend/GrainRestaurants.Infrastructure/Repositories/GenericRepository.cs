using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Entities.Contratc;
using GrainRestaurants.Core.Exceptions;
using GrainRestaurants.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrainRestaurants.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly DbSet<T> _dataset;
        protected readonly GrainRestaurantDBContext _context;

        public GenericRepository(GrainRestaurantDBContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public void Delete(long id, bool shouldSave = true)
        {
            var result = FindOrThrow(id);
            _dataset.Remove(result);
            if (shouldSave) SaveChanges();
        }

        public List<T> Find()
        {
            return _dataset.ToList();
        }

        public T FindById(long id)
        {
            return _dataset.SingleOrDefault(e => e.Id.Equals(id));
        }

        public T FindOrThrow(long id)
        {
            var result = FindById(id) ?? throw new NotFoundException();
            return result;
        }

        public T Save(T entity, bool shouldSave = true)
        {
            _dataset.Add(entity);
            if (shouldSave) SaveChanges();
            return entity;
        }

        public T? FindBy(Func<T, bool> lambda) => _dataset.SingleOrDefault(lambda);

        public int SaveChanges() => _context.SaveChanges();

        public void SoftDelete<U>(U entity, bool shouldSave = true)
        where U : BaseEntity, IDeletedAt
        {
            entity.DeletedAt = DateTime.Now.ToLocalTime();
            if (shouldSave) SaveChanges();
        }

        public T Update(T entity, bool shouldSave = true)
        {
            var result = _dataset.Update(entity);
            if (shouldSave) SaveChanges();
            return result.Entity;
        }
    }
}
