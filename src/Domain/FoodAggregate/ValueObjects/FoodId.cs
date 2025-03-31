using Domain.Common;

namespace Domain.FoodAggregate.ValueObjects;

/// <summary>
///     Represents a unique identifier for a Food entity.
/// </summary>
public sealed class FoodId : ValueObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FoodId" /> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    /// <exception cref="ArgumentException">Thrown when the provided id is an empty GUID.</exception>
    public FoodId(Guid id)
    {
        if (id == Guid.Empty) throw new ArgumentException("FoodId cannot be empty", nameof(id));

        Value = id;
    }

    /// <summary>
    ///     Gets the value of the FoodId.
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    ///     Creates a new instance of <see cref="FoodId" /> with a unique identifier.
    /// </summary>
    /// <returns>A new <see cref="FoodId" /> instance with a unique GUID.</returns>
    public static FoodId CreateUnique()
    {
        return new FoodId(Guid.NewGuid());
    }

    /// <summary>
    ///     Gets the components that make up the equality of the value object.
    /// </summary>
    /// <returns>An IEnumerable of objects that represent the equality components.</returns>
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}