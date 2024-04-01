namespace Application.Common.Interfaces.Identity;

public interface ICurrentUser
{
    Guid GetUserId();
    string GetUserName();
}
