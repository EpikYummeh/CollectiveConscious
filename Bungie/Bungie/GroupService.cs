namespace Bungie
{
    using System.Threading.Tasks;
    using BaseJump;
    using Responses;
    using Posts;
    [Route("https://www.bungie.net/platform/GroupV2/")]
    public class GroupService : BungieService, IGroupService
    {
        public GroupService(string apiKey) : base(apiKey)
        {
        }
        [Route("{groupId}/Members")]
        public Task<GetGroupUsersResponse> GetGroupUsers(MembershipType platformType, long groupId, int currentPage, int itemsPerPage = 50)
        {
            var model = new
            {
                platformType,
                groupId,
                currentPage,
                itemsPerPage
            };
            return Request<GetGroupUsersResponse>(model);
        }
        [Route("Name/{groupName}/{groupType}")]
        public Task<GetGroupByNameResponse> GetGroupByName(string groupName, GroupType type)
        {
            var model = new
            {
                groupName,
                type
            };
            return Request<GetGroupByNameResponse>(model);
        }
        [Route("User/{membershipType}/{membershipId}/{filter}/{groupType}/")]
        public Task<GetGroupsForMemberResponse> GetGroupsForMember(MembershipType membershipType, long membershipId, GroupsForMemberFilter filter, GroupType groupType)
        {
            var model = new
            {
                membershipType,
                membershipId,
                filter,
                groupType
            };
            return Request<GetGroupsForMemberResponse>(model);
        }
        [Route("{groupId}/InviteGroupMember/{membershipId}/")]
        public Task<SetGroupInvitation> SetGroupInvitation(long groupId, long membershipId)
        {
            var model = new
            {
                groupId,
                membershipId
            };
            return Request<SetGroupInvitation>(model);
        }
    }
}
