using Application.Common.Interfaces.DI;
using Application.Identity;

namespace Application.Common.Interfaces.Identity;

public interface IUserService : ITransientService
{
    // TODO: thay bằng Dtos với AutoMapper.
    public Task<List<User>> SearchUser(SearchUserRequest request, CancellationToken cancellationToken = default);
    public Task<User> GetUser(Guid id);
    public Task<bool> CreateUser(User user, CancellationToken cancellationToken = default);
    public Task<bool> UpdateUser(User user, CancellationToken cancellationToken = default);
    public Task<>
}
