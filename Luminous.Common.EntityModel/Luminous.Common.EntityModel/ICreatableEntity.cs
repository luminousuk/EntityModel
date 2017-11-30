using System;

namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Base interface for creatable but not modifiable entity objects
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public interface ICreatableEntity<out T> : IEntity<T>
    {
        DateTime CreatedDate { get; }
        string CreatedBy { get; }
    }
}