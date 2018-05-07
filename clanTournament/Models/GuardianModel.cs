using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clanTournament.Models
{
    /// <summary>
    /// The eventual model each guardian will be setup with
    /// </summary>
    public class GuardianModel
    {
        public TeamModel Team { get; set; }
        public string MembershipId { get; set; }
        public string DisplayName { get; set; }
        public int MembershipType { get; set; }
    }
}