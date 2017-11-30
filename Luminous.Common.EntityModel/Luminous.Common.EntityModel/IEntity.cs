namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Base interface for all entity objects
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public interface IEntity<out T>
    {
        T Id { get; }
        byte[] Version { get; }
    }
}