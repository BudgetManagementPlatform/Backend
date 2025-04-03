namespace Domain.Common;

/// <summary>
///     Represents an aggregate root entity with a unique identifier.
/// </summary>
/// <typeparam name="TId">The type of the unique identifier.</typeparam>
public abstract class AggregateRoot<TId> : Entity<TId>
    where TId : notnull
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AggregateRoot{TId}" /> class.
    ///     This constructor is protected to allow instantiation by derived classes.
    /// </summary>
    protected AggregateRoot()
    {
    }

    /// <summary>
    ///     Represents an aggregate root entity with a unique identifier.
    /// </summary>
    /// <typeparam name="TId">The type of the unique identifier.</typeparam>
    protected AggregateRoot(TId id) : base(id)
    {
    }
    // Additional members and methods can be added here
}