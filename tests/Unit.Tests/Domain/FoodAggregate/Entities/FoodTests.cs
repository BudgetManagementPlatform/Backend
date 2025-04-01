using Domain.FoodAggregate.Entities;
using Domain.FoodAggregate.ValueObjects;

namespace Unit.Tests.Domain.FoodAggregate.Entities;

public class FoodTests
{
    private const string Apple = "Apple";

    [Fact]
    public void Created_ShouldReturnNewFood_WithGivenValues()
    {
        FoodId foodId = new(Guid.NewGuid());
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);

        Food food = Food.Created(foodId, Apple, nutritionalValue);

        Assert.Equal(foodId, food.Id);
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
        FoodId foodId = new(Guid.NewGuid());

        Assert.Throws<ArgumentNullException>(() => Food.Created(foodId, Apple, null!));
    }

    [Fact]
    public void Created_ShouldThrowArgumentException_WhenFoodNameIsEmpty()
    {
        FoodId foodId = new(Guid.NewGuid());
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);

        Assert.Throws<ArgumentException>(() => Food.Created(foodId, "", nutritionalValue));
    }

    [Fact]
    public void Created_ShouldThrowArgumentException_WhenFoodNameIsWhitespace()
    {
        FoodId foodId = new(Guid.NewGuid());
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);

        Assert.Throws<ArgumentException>(() => Food.Created(foodId, "   ", nutritionalValue));
    }
}