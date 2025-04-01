using Domain.FoodAggregate.Entities;
using Domain.FoodAggregate.ValueObjects;

namespace Unit.Tests.Domain.FoodAggregate.Entities;

public class FoodTests
{
    private const string Apple = "Apple";
    private readonly FoodId _foodId = FoodId.CreateUnique();

    [Fact]
    public void Created_ShouldReturnNewFood_WithGivenValues()
    {
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);

        Food food = Food.Created(_foodId, Apple, nutritionalValue);

        Assert.Equal(_foodId, food.Id);
        Assert.Equal(Apple, food.FoodName);
        Assert.Equal(nutritionalValue, food.NutritionalValue);
    }

    [Fact]
    public void Created_ShouldThrowArgumentNullException_WhenFoodIdIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => Food.Created(null!, Apple, NutritionalValue.Created(1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1)));
    }

    [Fact]
    public void Created_ShouldThrowArgumentNullException_WhenNutritionalValueIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => Food.Created(_foodId, Apple, null!));
    }

    [Fact]
    public void Created_ShouldThrowArgumentException_WhenFoodNameIsEmpty()
    {
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);

        Assert.Throws<ArgumentException>(() => Food.Created(_foodId, "", nutritionalValue));
    }

    [Fact]
    public void Created_ShouldThrowArgumentException_WhenFoodNameIsWhitespace()
    {
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);

        Assert.Throws<ArgumentException>(() => Food.Created(_foodId, "   ", nutritionalValue));
    }
}