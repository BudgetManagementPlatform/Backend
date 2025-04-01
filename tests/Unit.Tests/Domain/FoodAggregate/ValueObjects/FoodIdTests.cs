using Domain.FoodAggregate.ValueObjects;

namespace Unit.Tests.Domain.FoodAggregate.ValueObjects;

public class FoodIdTests
{
    private readonly FoodId _foodId = FoodId.CreateUnique();

    [Fact]
    public void CreateUnique_ShouldReturnNewFoodId_WithUniqueGuid()
    {
        FoodId foodId1 = FoodId.CreateUnique();

        Assert.NotEqual(_foodId.Value, foodId1.Value);
    }

    [Fact]
    public void GetEqualityComponents_ShouldReturnCorrectComponents()
    {
        Guid guid = _foodId.Value;
        IEnumerable<object> components = _foodId.GetEqualityComponents();
        Assert.Contains(guid, components);
    }

    [Fact]
    public void FoodId_ShouldBeEqual_WhenSameGuid()
    {
        FoodId foodId1 = _foodId;
        Assert.Equal(_foodId, foodId1);
    }

    [Fact]
    public void FoodId_ShouldNotBeEqual_WhenDifferentGuid()
    {
        FoodId foodId1 = FoodId.CreateUnique();
        Assert.NotEqual(foodId1, _foodId);
    }
}