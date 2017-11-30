namespace Luminous.Common.EntityModel
{
    /// <summary>
    ///     Abstract base class for lookup entities
    /// </summary>
    /// <typeparam name="T">The type of object identifier</typeparam>
    public abstract class LookupEntity<T> : ModifiableEntity<T>, ILookupEntity<T>
    {
        public string Value { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
    }
}