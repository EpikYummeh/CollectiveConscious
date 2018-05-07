using System;
using System.Collections.Generic;
using System.Linq;

namespace Bungie.Models
{
    public class user
    {
        public string About { get; set; }
        public string DisplayName { get; set; }
        public DateTime FirstAccess { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Locale { get; set; }
        public bool LocaleInheritDefault { get; set; }
        public long MembershipId { get; set; }
        public long ProfilePicture { get; set; }
        public string ProfilePicturePath { get; set; }
        public int ProfileTheme { get; set; }
        public string ProfileThemeName { get; set; }
        public string PsnDisplayName { get; set; }
        public bool ShowActivity { get; set; }
        public bool ShowGroupMessaging { get; set; }
        public DateTime StatusDate { get; set; }
        public string StatusText { get; set; }
        public string SuccessMessageFlags { get; set; }
        public string UniqueName { get; set; }
        public int UserTitle { get; set; }
        public string UserTitleDisplay { get; set; }
        public string XboxDisplayName { get; set; }        
    }
}
