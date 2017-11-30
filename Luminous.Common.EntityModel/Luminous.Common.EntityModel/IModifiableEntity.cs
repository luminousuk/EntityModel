using System;

namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Base interface for modifiable entity objects
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public interface IModifiableEntity<out T> : ICreatableEntity<T>
    {
        DateTime? ModifiedDate { get; }
        string ModifiedBy { get; }
    }
}