namespace Bungie.Models
{
    using System;
    using Bungie.Models.Enums;
    public class Group
    {
        public long GroupId { get; set; }
        public string Name { get; set; }
        public GroupType GroupType { get; set; }
        public long MembershipIdCreated { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public string About { get; set; }
        public string[] Tags { get; set; }
        public int MemberCount { get; set; }
        public bool IsPublic { get; set; }
        public bool IsPublicTopicAdminOnly { get; set; }
        public string Motto { get; set; }
        public bool AllowChat { get; set; }
        public bool IsDefaultPostPublic { get; set; }
        public ChatSecurity ChatSecurity { get; set; }
        public string Locale { get; set; }
        public int AvatarImageIndex { get; set; }
        public GroupHomepage HomePage { get; set; }
        public MembershipOption MembershipOption { get; set; }
        public GroupPostPublicity DefaultPublicity { get; set; }
        public string Theme { get; set; }
        public string BannerPath { get; set; }
        public string AvatarPath { get; set; }
        public long ConversationId { get; set; }
        public bool EnableInvitationMessagingForAdmins { get; set; }
        public DateTime BanExpireDate { get; set; }
        //group features
        //clan info
    }
}
