using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     The abstract base entity class all domain models should inherit from
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public abstract class Entity<T> : IEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; private set; }

        [Timestamp]
        public byte[] Version { get; private set; }
    }
}