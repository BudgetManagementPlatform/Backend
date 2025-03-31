using Domain.Common;
using Domain.FoodAggregate.ValueObjects;

namespace Domain.FoodAggregate.Entities;

/// <summary>
///     Represents a food entity with various nutritional properties.
/// </summary>
public sealed class Food(
    FoodId foodId,
    string? foodName,
    NutritionalValue nutritionalValue)
    : Entity<FoodId>(foodId)
{
    /// <summary>
    ///     Gets the name of the food.
    /// </summary>
    public string? FoodName { get; init; } = foodName;

    public NutritionalValue NutritionalValue { get; } = nutritionalValue;

    /// <summary>
    ///     Creates a new instance of the <see cref="Food" /> class with the specified properties.
    /// </summary>
    /// <param name="foodId">The unique identifier of the food.</param>
    /// <param name="foodName">The name of the food.</param>
    /// <param name="nutritionalValue">Nutritional value of the food</param>
    /// <returns>A new instance of the <see cref="Food" /> class.</returns>
    public static Food Created(
        FoodId foodId,
        string? foodName,
        NutritionalValue nutritionalValue
        )
    {
        return new Food(
            foodId,
            foodName,
            nutritionalValue);
    }
}