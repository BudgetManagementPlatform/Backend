using Domain.Common;
using Domain.FoodAggregate.ValueObjects;

namespace Domain.FoodAggregate.Entities;

/// <summary>
/// Represents a nutrient entity with a unique identifier, user ID, nutritional value, and timestamp.
/// </summary>
public sealed class Nutrient : Entity<NutrientId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Nutrient"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the nutrient.</param>
    /// <param name="userId">The unique identifier for the user.</param>
    /// <param name="nutritionalValue">The nutritional value of the nutrient.</param>
    /// <param name="timeProvider">The time provider for timestamping.</param>
    /// <exception cref="ArgumentException">Thrown when the user ID is empty.</exception>
    /// <exception cref="ArgumentNullException">Thrown when the nutritional value is null.</exception>
    private Nutrient(NutrientId id, Guid userId, NutritionalValue nutritionalValue, TimeProvider timeProvider) :
        base(id)
    {
        if (userId == Guid.Empty) throw new ArgumentException("Id or UserId cannot be empty.");

        EntityTimeStamp = new EntityTimeStamp<Guid>(userId, timeProvider);
        NutritionalValue = nutritionalValue ?? throw new ArgumentNullException(nameof(nutritionalValue));
    }

    /// <summary>
    /// Gets or sets the timestamp information for the nutrient entity.
    /// </summary>
    public EntityTimeStamp<Guid> EntityTimeStamp { get; set; }

    /// <summary>
    /// Gets or sets the nutritional value of the nutrient.
    /// </summary>
    public NutritionalValue NutritionalValue { get; set; }

    /// <summary>
    /// Creates a new instance of the <see cref="Nutrient"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the nutrient.</param>
    /// <param name="userId">The unique identifier for the user.</param>
    /// <param name="nutritionalValue">The nutritional value of the nutrient.</param>
    /// <param name="timeProvider">The time provider for timestamping.</param>
    /// <returns>A new instance of the <see cref="Nutrient"/> class.</returns>
    public static Nutrient Created(NutrientId id, Guid userId, NutritionalValue nutritionalValue,
        TimeProvider timeProvider)
    {
        return new Nutrient(id, userId, nutritionalValue, timeProvider);
    }
}