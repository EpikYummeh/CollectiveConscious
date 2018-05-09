namespace Bungie.Models
{
    using System;
    using Bungie.Models.Enums;
    public class GroupMember
    {
        public GroupMemberType MemberType { get; set; }
        public bool IsOnline { get; set; }
        public long GroupId { get; set; }
        public UserInfo DestinyUserInfo { get; set; }
        public UserInfo BungieNetUserInfo { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
