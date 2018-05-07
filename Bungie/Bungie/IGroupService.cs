namespace Bungie
{
    using Responses;
    using System.Threading.Tasks;

    public interface IGroupService
    {
        Task<GetGroupUsersResponse> GetGroupUsers(MembershipType membershipType, long GroupId, int currentPage = 1, int itemsPerPage = 50);
    }
}
