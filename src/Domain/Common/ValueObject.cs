namespace Domain.Common;

/// <summary>
///     Represents a value object that implements equality based on its components.
/// </summary>
public abstract class ValueObject : IEquatable<ValueObject>
{
    /// <summary>
    ///     Determines whether the specified value object is equal to the current value object.
    /// </summary>
    /// <param name="other">The value object to compare with the current value object.</param>
    /// <returns><c>true</c> if the specified value object is equal to the current value object; otherwise, <c>false</c>.</returns>
    public bool Equals(ValueObject? other)
    {
        return Equals(other);
    }

    /// <summary>
    ///     Gets the components that make up the equality of the value object.
    /// </summary>
    /// <returns>An IEnumerable of objects that represent the equality components.</returns>
    public abstract IEnumerable<object> GetEqualityComponents();

    /// <summary>
    ///     Determines whether two value objects are equal.
    /// </summary>
    /// <param name="left">The first value object to compare.</param>
    /// <param name="right">The second value object to compare.</param>
    /// <returns><c>true</c> if the value objects are equal; otherwise, <c>false</c>.</returns>
    public static bool operator ==(ValueObject? left, ValueObject? right)
    {
        return Equals(left, right);
    }

    /// <summary>
    ///     Determines whether two value objects are not equal.
    /// </summary>
    /// <param name="left">The first value object to compare.</param>
    /// <param name="right">The second value object to compare.</param>
    /// <returns><c>true</c> if the value objects are not equal; otherwise, <c>false</c>.</returns>
    public static bool operator !=(ValueObject? left, ValueObject? right)
    {
        return !Equals(left, right);
    }

    /// <summary>
    ///     Determines whether the specified object is equal to the current value object.
    /// </summary>
    /// <param name="obj">The object to compare with the current value object.</param>
    /// <returns><c>true</c> if the specified object is equal to the current value object; otherwise, <c>false</c>.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;

        ValueObject? valueObject = obj as ValueObject;

        return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
    }

    /// <summary>
    ///     Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current value object.</returns>
    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate((x, y) => x ^ y);
    }
}