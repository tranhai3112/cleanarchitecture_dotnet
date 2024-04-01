using Application.Common.Models;

namespace Application.Identity;

public class SearchUserRequest : PaginationFilter
{
    public string? UserName { get; set; }
    public string? OfGroup { get; set; }
    public string? OfGroupName { get; set; }
    public new int? PageSize { get; set; } = 10;
}
