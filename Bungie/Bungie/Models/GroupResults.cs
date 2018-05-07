using System;
using System.Collections.Generic;
using System.Linq;

namespace Bungie.Models
{
    public class GroupResults
    {
        public DateTime ApprovalDate { get; set; }
        public long GroupId { get; set; }
        public bool HasPendingApplication { get; set; }
        public bool HasRated { get; set; }
        public bool IsMember { get; set; }
        public bool IsOriginalFounder { get; set; }
        public int MemberType { get; set; }
        public long MembershipId { get; set; }
        public int membershipType { get; set; }
        public int Rating { get; set; }
        public user user { get; set; }

    }
}
