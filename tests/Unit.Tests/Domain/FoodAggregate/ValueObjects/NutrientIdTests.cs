using Domain.FoodAggregate.ValueObjects;

namespace Unit.Tests.Domain.FoodAggregate.ValueObjects;

public class NutrientIdTests
{
    private readonly NutrientId _nutrientId = NutrientId.CreateUnique();

    [Fact]
    public void CreateUnique_ShouldReturnNewFoodId_WithUniqueGuid()
    {
        FoodId nutrientId1 = FoodId.CreateUnique();

        Assert.NotEqual(_nutrientId.Value, nutrientId1.Value);
    }

    [Fact]
    public void GetEqualityComponents_ShouldReturnCorrectComponents()
    {
        Guid guid = _nutrientId.Value;
        IEnumerable<object> components = _nutrientId.GetEqualityComponents();
        Assert.Contains(guid, components);
    }

    [Fact]
    public void FoodId_ShouldBeEqual_WhenSameGuid()
    {
        NutrientId nutrientId2 = _nutrientId;
        Assert.Equal(_nutrientId, nutrientId2);
    }

    [Fact]
    public void FoodId_ShouldNotBeEqual_WhenDifferentGuid()
    {
        FoodId nutrientId = FoodId.CreateUnique();

        Assert.NotEqual(nutrientId.Value, _nutrientId.Value);
    }
}