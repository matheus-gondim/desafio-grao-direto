using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Entities.Contratc;
using System;
using System.Collections.Generic;

namespace GrainRestaurants.Core.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T Save(T entity, bool shouldSave = true);
        List<T> Find();
        T FindById(long id);
        T FindOrThrow(long id);
        T Update(T entity, bool shouldSave = true);
        void Delete(long id, bool shouldSave = true);
        void SoftDelete<U>(U entity, bool shouldSave = true) where U : BaseEntity, IDeletedAt;
        int SaveChanges();
        T? FindBy(Func<T, bool> lambda);
    }
}
