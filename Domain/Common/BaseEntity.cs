
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common;
public abstract class BaseEntity : BaseEntity<DefaultIdType>
{
    protected BaseEntity() => Id = new DefaultIdType();
}
public abstract class BaseEntity<TId> : IEntity<TId>
{
    public TId Id { get; protected set; } = default!;

}
