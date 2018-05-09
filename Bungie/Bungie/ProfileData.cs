using Bungie.Models;
using System;

namespace Bungie
{
    public class ProfileData
    {
        public UserInfo UserInfo { get; set; }
        public DateTime DateLastPlayed { get; set; }
        public VersionsOwned VersionsOwned { get; set; }
        public Character[] CharacterIds { get; set; }
    }
}
