namespace Domain.Common;

/// <summary>
///     Represents an aggregate root entity with a unique identifier.
/// </summary>
/// <typeparam name="TId">The type of the unique identifier.</typeparam>
public abstract class AggregateRoot<TId>(TId id) : Entity<TId>(id)
    where TId : notnull
{
    // Additional members and methods can be added here
}