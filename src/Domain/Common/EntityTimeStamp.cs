namespace Domain.Common;

/// <summary>
///     Represents an auditable root entity with creation and modification tracking.
/// </summary>
/// <typeparam name="T">The type of the unique identifier.</typeparam>
public class EntityTimeStamp<T>(Guid createdById) where T : notnull
{
    /// <summary>
    ///     Gets the identifier of the user who created the entity.
    /// </summary>
    public Guid CreatedById { get; private set; } = createdById;

    /// <summary>
    ///     Gets the date and time when the entity was created.
    /// </summary>
    public DateTime CreatedDate { get; } = DateTime.UtcNow;

    /// <summary>
    ///     Gets or sets the date and time when the entity was last modified.
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    ///     Updates the <see cref="LastModifiedDate" /> to the current date and time.
    /// </summary>
    public void Update()
    {
        LastModifiedDate = DateTime.UtcNow;
    }
}