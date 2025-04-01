using Domain.Common;
using Domain.FoodAggregate.ValueObjects;

namespace Domain.FoodAggregate.Entities;

/// <summary>
///     Represents a nutrient entity with a unique identifier, user ID, and nutritional value.
/// </summary>
public sealed class Nutrient : Entity<Guid>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Nutrient" /> class.
    /// </summary>
    /// <param name="id">The unique identifier of the nutrient.</param>
    /// <param name="userId">The unique identifier of the user who created the nutrient.</param>
    /// <param name="nutritionalValue">The nutritional value of the nutrient.</param>
    /// <exception cref="ArgumentException">Thrown when the id or userId is empty.</exception>
    /// <exception cref="ArgumentNullException">Thrown when the nutritionalValue is null.</exception>
    private Nutrient(Guid id, Guid userId, NutritionalValue nutritionalValue) : base(id)
    {
        if (id == Guid.Empty || userId == Guid.Empty) throw new ArgumentException("Id or UserId cannot be empty.");

        EntityTimeStamp = new EntityTimeStamp<Guid>(userId);
        NutritionalValue = nutritionalValue ?? throw new ArgumentNullException(nameof(nutritionalValue));
    }

    /// <summary>
    ///     Gets or sets the entity timestamp which includes creation and modification tracking.
    /// </summary>
    public EntityTimeStamp<Guid> EntityTimeStamp { get; set; }

    /// <summary>
    ///     Gets or sets the nutritional value of the nutrient.
    /// </summary>
    public NutritionalValue NutritionalValue { get; set; }

    /// <summary>
    ///     Creates a new instance of the <see cref="Nutrient" /> class.
    /// </summary>
    /// <param name="id">The unique identifier of the nutrient.</param>
    /// <param name="userId">The unique identifier of the user who created the nutrient.</param>
    /// <param name="nutritionalValue">The nutritional value of the nutrient.</param>
    /// <returns>A new instance of the <see cref="Nutrient" /> class.</returns>
    public static Nutrient Created(Guid id, Guid userId, NutritionalValue nutritionalValue)
    {
        return new Nutrient(id, userId, nutritionalValue);
    }
}