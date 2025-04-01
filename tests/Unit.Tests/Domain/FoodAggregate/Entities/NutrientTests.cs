using Domain.FoodAggregate.Entities;
using Domain.FoodAggregate.ValueObjects;

namespace Unit.Tests.Domain.FoodAggregate.Entities;

public class NutrientTests
{
    [Fact]
    public void Created_ShouldReturnNewNutrient_WithGivenValues()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);
        Nutrient nutrient = Nutrient.Created(id, userId, nutritionalValue);

        Assert.Equal(id, nutrient.Id);
        Assert.Equal(userId, nutrient.EntityTimeStamp.CreatedById);
        Assert.Equal(nutritionalValue, nutrient.NutritionalValue);
    }

    [Fact]
    public void Created_ShouldThrowArgumentException_WhenIdIsEmpty()
    {
        Guid userId = Guid.NewGuid();
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);
        Assert.Throws<ArgumentException>(() => Nutrient.Created(Guid.Empty, userId, nutritionalValue));
    }

    [Fact]
    public void Created_ShouldThrowArgumentException_WhenUserIdIsEmpty()
    {
        Guid id = Guid.NewGuid();
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);
        Assert.Throws<ArgumentException>(() => Nutrient.Created(id, Guid.Empty, nutritionalValue));
    }

    [Fact]
    public void Created_ShouldThrowArgumentNullException_WhenNutritionalValueIsNull()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();

        Assert.Throws<ArgumentNullException>(() => Nutrient.Created(id, userId, null!));
    }

    [Fact]
    public void Update_ShouldUpdateNutritionalValue()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);
        Nutrient nutrient = Nutrient.Created(id, userId, nutritionalValue);

        Assert.Null(nutrient.EntityTimeStamp.LastModifiedDate);

        nutrient.EntityTimeStamp.Update();

        Assert.NotNull(nutrient.EntityTimeStamp.LastModifiedDate);
    }
}