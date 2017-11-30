namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Base interface for lookup entity objects
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public interface ILookupEntity<out T> : IModifiableEntity<T>
    {
        string Value { get; set; }
        string Description { get; set; }
        int SortOrder { get; set; }
    }
}