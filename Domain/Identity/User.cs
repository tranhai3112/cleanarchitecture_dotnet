using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Identity;

public class User : AuditableEntity<DefaultIdType>
{
    [MaxLength(256)]
    public string Name { get; private set; }
    public Guid GroupId { get; private set; }
    [ForeignKey(nameof(GroupId))]
    public Group Group { get; private set; }

    private User(string name, DefaultIdType groupId)
    {
        Name = name;
        GroupId = groupId;
    }

    public static User Create(string name, Guid groupId)
    {
        return new User(name, groupId);
    }
}
