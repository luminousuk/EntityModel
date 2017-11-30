using System;
using System.ComponentModel.DataAnnotations;

namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Abstract base class for entities that can be created and modified
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public abstract class ModifiableEntity<T> : CreatableEntity<T>, IModifiableEntity<T>
    {
        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; private set; }
        public string ModifiedBy { get; private set; }
    }
}