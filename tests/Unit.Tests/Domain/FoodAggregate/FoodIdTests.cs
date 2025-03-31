using Domain.FoodAggregate.ValueObjects;

public class FoodIdTests
{
    [Fact]
    public void FoodId_ShouldThrowArgumentException_WhenEmptyGuid()
    {
        Assert.Throws<ArgumentException>(() => new FoodId(Guid.Empty));
    }

    [Fact]
    public void FoodId_ShouldCreateInstance_WhenValidGuid()
    {
        Guid guid = Guid.NewGuid();
        FoodId foodId = new(guid);
        Assert.Equal(guid, foodId.Value);
    }

    [Fact]
    public void CreateUnique_ShouldReturnNewFoodId_WithUniqueGuid()
    {
        FoodId foodId = FoodId.CreateUnique();
        Assert.NotEqual(Guid.Empty, foodId.Value);
    }

    [Fact]
    public void GetEqualityComponents_ShouldReturnCorrectComponents()
    {
        Guid guid = Guid.NewGuid();
        FoodId foodId = new(guid);
        IEnumerable<object> components = foodId.GetEqualityComponents();
        Assert.Contains(guid, components);
    }

    [Fact]
    public void FoodId_ShouldBeEqual_WhenSameGuid()
    {
        Guid guid = Guid.NewGuid();
        FoodId foodId1 = new(guid);
        FoodId foodId2 = new(guid);
        Assert.Equal(foodId1, foodId2);
    }

    [Fact]
    public void FoodId_ShouldNotBeEqual_WhenDifferentGuid()
    {
        FoodId foodId1 = new(Guid.NewGuid());
        FoodId foodId2 = new(Guid.NewGuid());
        Assert.NotEqual(foodId1, foodId2);
    }
}