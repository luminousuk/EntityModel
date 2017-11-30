using System;
using System.ComponentModel.DataAnnotations;

namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Abstract base class for entities that can be created but not modified
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public abstract class CreatableEntity<T> : Entity<T>, ICreatableEntity<T>
    {
        private DateTime? _createdDate;

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get => _createdDate ?? DateTime.UtcNow;
            private set => _createdDate = value;
        }

        public string CreatedBy { get; }
    }
}