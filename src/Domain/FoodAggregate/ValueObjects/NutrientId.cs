using Domain.Common;

namespace Domain.FoodAggregate.ValueObjects;

/// <summary>
///     Represents a unique identifier for a Nutrient entity.
/// </summary>
public class NutrientId : ValueObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NutrientId" /> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    private NutrientId(Guid id)
    {
        Value = id;
    }

    /// <summary>
    ///     Gets the value of the NutrientId.
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    ///     Creates a new instance of <see cref="NutrientId" /> with a unique identifier.
    /// </summary>
    /// <returns>A new <see cref="NutrientId" /> instance with a unique GUID.</returns>
    public static NutrientId CreateUnique()
    {
        return new NutrientId(Guid.NewGuid());
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