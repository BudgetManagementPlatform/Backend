using Domain.FoodAggregate.Entities;
using Domain.FoodAggregate.ValueObjects;
using NSubstitute;

namespace Unit.Tests.Domain.FoodAggregate.Entities;

public class NutrientTests
{
    private readonly TimeProvider _timeProvider = Substitute.For<TimeProvider>();

    [Fact]
    public void Created_ShouldReturnNewNutrient_WithGivenValues()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);
        Nutrient nutrient = Nutrient.Created(id, userId, nutritionalValue, _timeProvider);

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
        Assert.Throws<ArgumentException>(() => Nutrient.Created(Guid.Empty, userId, nutritionalValue, _timeProvider));
    }

    [Fact]
    public void Created_ShouldThrowArgumentException_WhenUserIdIsEmpty()
    {
        Guid id = Guid.NewGuid();
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);
        Assert.Throws<ArgumentException>(() => Nutrient.Created(id, Guid.Empty, nutritionalValue, _timeProvider));
    }

    [Fact]
    public void Created_ShouldThrowArgumentNullException_WhenNutritionalValueIsNull()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();

        Assert.Throws<ArgumentNullException>(() => Nutrient.Created(id, userId, null!, _timeProvider));
    }

    [Fact]
    public void Update_ShouldUpdateNutritionalValue()
    {
        Guid id = Guid.NewGuid();
        Guid userId = Guid.NewGuid();
        NutritionalValue nutritionalValue = NutritionalValue.Created(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1);
        _timeProvider.GetUtcNow().Returns(new DateTimeOffset(2024, 10, 1, 12, 0, 0, TimeSpan.Zero));

        Nutrient nutrient = Nutrient.Created(id, userId, nutritionalValue, _timeProvider);

        Assert.False(nutrient.EntityTimeStamp.LastModifiedDate.HasValue);
        Assert.Equal(nutrient.EntityTimeStamp.CreatedDate, new DateTime(2024, 10, 1, 12, 0, 0));

        _timeProvider.GetUtcNow().Returns(new DateTimeOffset(2024, 11, 1, 12, 0, 0, TimeSpan.Zero));

        nutrient.EntityTimeStamp.Update();

        Assert.True(nutrient.EntityTimeStamp.LastModifiedDate.HasValue);
        Assert.Equal(nutrient.EntityTimeStamp.LastModifiedDate, new DateTime(2024, 11, 1, 12, 0, 0));
    }
}