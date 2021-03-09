using System;
using System.Collections.Generic;

namespace Gestion.Personne.Api.DContext.Repositories
{
    /// <summary>
    /// Interface to describe the crud used by the repository
    /// </summary>
    /// <typeparam name="TEntity">Type of entity</typeparam>
    /// <typeparam name="TId">Type id</typeparam>
    public interface IRepository<TEntity, TId>
    {
        TEntity Get(Guid id);
        TId Create(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TId id);
        IEnumerable<TEntity> Get(string search);
    }
}
