namespace Domain.Common;

/// <summary>
///     Represents an entity with a unique identifier.
/// </summary>
/// <typeparam name="TId">The type of the unique identifier.</typeparam>
public abstract class Entity<TId> : IEquatable<Entity<TId>>
    where TId : notnull
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Entity{TId}" /> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    protected Entity(TId id)
    {
        Id = id;
    }

    /// <summary>
    ///     Gets or sets the unique identifier of the entity.
    /// </summary>
    public TId Id { get; protected set; }

    /// <summary>
    ///     Determines whether the specified entity is equal to the current entity.
    /// </summary>
    /// <param name="other">The entity to compare with the current entity.</param>
    /// <returns><c>true</c> if the specified entity is equal to the current entity; otherwise, <c>false</c>.</returns>
    public bool Equals(Entity<TId>? other)
    {
        return Equals(other as object);
    }

    /// <summary>
    ///     Determines whether the specified object is equal to the current entity.
    /// </summary>
    /// <param name="obj">The object to compare with the current entity.</param>
    /// <returns><c>true</c> if the specified object is equal to the current entity; otherwise, <c>false</c>.</returns>
    public override bool Equals(object? obj)
    {
        return obj is Entity<TId> entity && Id.Equals(entity.Id);
    }

    /// <summary>
    ///     Determines whether two entities are equal.
    /// </summary>
    /// <param name="left">The first entity to compare.</param>
    /// <param name="right">The second entity to compare.</param>
    /// <returns><c>true</c> if the entities are equal; otherwise, <c>false</c>.</returns>
    public static bool operator ==(Entity<TId>? left, Entity<TId>? right)
    {
        return Equals(left, right);
    }

    /// <summary>
    ///     Determines whether two entities are not equal.
    /// </summary>
    /// <param name="left">The first entity to compare.</param>
    /// <param name="right">The second entity to compare.</param>
    /// <returns><c>true</c> if the entities are not equal; otherwise, <c>false</c>.</returns>
    public static bool operator !=(Entity<TId>? left, Entity<TId>? right)
    {
        return !Equals(left, right);
    }

    /// <summary>
    ///     Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current entity.</returns>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}