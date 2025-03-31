namespace Domain.Common;

public class AuditableRoot<T>(Guid createdById) where T : notnull
{
    public Guid CreatedById { get; private set; } = createdById;
    public DateTime CreatedDate { get; } = DateTime.UtcNow;
    public List<T> LastModifiedBy { get; } = [];
    public DateTime? LastModifiedDate { get; private set; }

    public void Update(T lastModifiedById)
    {
        LastModifiedBy.Add(lastModifiedById);
        LastModifiedDate = DateTime.UtcNow;
    }
}