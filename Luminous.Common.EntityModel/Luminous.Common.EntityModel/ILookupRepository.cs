using System.Threading;
using System.Threading.Tasks;

namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Base repository interface for lookup entities
    /// </summary>
    /// <typeparam name="TEntity">The type of lookup entity object</typeparam>
    /// <typeparam name="TIdentity">The type of object identifier</typeparam>
    public interface ILookupRepository<TEntity, in TIdentity> : IRepository<TEntity, TIdentity>
        where TEntity : ILookupEntity<TIdentity>
    {
        TEntity FindByValue(string value);
        Task<TEntity> FindByValueAsync(string value);
        Task<TEntity> FindByValueAsync(string value, CancellationToken cancellationToken);
    }
}