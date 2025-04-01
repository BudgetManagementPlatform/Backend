using Domain.FoodAggregate.Entities;
using Domain.FoodAggregate.ValueObjects;
using NSubstitute;

namespace Unit.Tests.Domain.FoodAggregate.Entities;

public class NutrientTests
{
    private readonly NutrientId _nutrientId = NutrientId.CreateUnique();

    private readonly NutritionalValue _nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
        1, 1, 1, 1, 1,
        1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
        1, 1, 1, 1);

    private readonly TimeProvider _timeProvider = Substitute.For<TimeProvider>();

    [Fact]
    public void Created_ShouldReturnNewNutrient_WithGivenValues()
    {
        Guid userId = Guid.NewGuid();
        Nutrient nutrient = Nutrient.Created(_nutrientId, userId, _nutritionalValue, _timeProvider);

        Assert.Equal(_nutrientId, nutrient.Id);
        Assert.Equal(userId, nutrient.EntityTimeStamp.CreatedById);
        Assert.Equal(_nutritionalValue, nutrient.NutritionalValue);
    }


    [Fact]
    public void Created_ShouldThrowArgumentException_WhenUserIdIsEmpty()
    {
        Guid id = Guid.NewGuid();

        Assert.Throws<ArgumentException>(() =>
            Nutrient.Created(_nutrientId, Guid.Empty, _nutritionalValue, _timeProvider));
    }

    [Fact]
    public void Created_ShouldThrowArgumentNullException_WhenNutritionalValueIsNull()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();

        Assert.Throws<ArgumentNullException>(() => Nutrient.Created(_nutrientId, userId, null!, _timeProvider));
    }

    [Fact]
    public void Update_ShouldUpdateNutritionalValue()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();

        _timeProvider.GetUtcNow().Returns(new DateTimeOffset(2024, 10, 1, 12, 0, 0, TimeSpan.Zero));

        Nutrient nutrient = Nutrient.Created(_nutrientId, userId, _nutritionalValue, _timeProvider);

        Assert.False(nutrient.EntityTimeStamp.LastModifiedDate.HasValue);
        Assert.Equal(nutrient.EntityTimeStamp.CreatedDate, new DateTime(2024, 10, 1, 12, 0, 0));

        _timeProvider.GetUtcNow().Returns(new DateTimeOffset(2024, 11, 1, 12, 0, 0, TimeSpan.Zero));

        nutrient.EntityTimeStamp.Update();

        Assert.True(nutrient.EntityTimeStamp.LastModifiedDate.HasValue);
        Assert.Equal(nutrient.EntityTimeStamp.LastModifiedDate, new DateTime(2024, 11, 1, 12, 0, 0));
    }
}