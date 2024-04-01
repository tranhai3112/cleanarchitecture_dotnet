using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Identity;

public class Group : BaseEntity<DefaultIdType>
{
    [MaxLength(256)]
    public string Name { get; private set; }

    public IReadOnlyList<User> Users => _users;

    private readonly List<User> _users = new();

    private Group(string name)
    {
        Name = name;
    }
    public static Group Create(string name)
    {
        return new Group(name);
    }
}
