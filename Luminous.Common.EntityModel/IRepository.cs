using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Base repository interface for entities
    /// </summary>
    /// <typeparam name="TEntity">The type of lookup entity object</typeparam>
    /// <typeparam name="TIdentity">The type of object identifier</typeparam>
    public interface IRepository<TEntity, in TIdentity> where TEntity : IEntity<TIdentity>
    {
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        List<TEntity> PageAll(int skip, int take);
        Task<List<TEntity>> PageAllAsync(int skip, int take);
        Task<List<TEntity>> PageAllAsync(int skip, int take, CancellationToken cancellationToken);

        TEntity FindById(TIdentity id);
        Task<TEntity> FindByIdAsync(TIdentity id);
        Task<TEntity> FindByIdAsync(TIdentity id, CancellationToken cancellationToken);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}