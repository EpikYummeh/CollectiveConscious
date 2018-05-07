using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clanTournament.Models
{
    /// <summary>
    /// Not yet initialized, but will be used to place a team on the bracket
    /// </summary>
    public class Round
    {
        public int TeamAScore { get; set; }
        public int TeamBScore { get; set; }
    }
    /// <summary>
    /// Used to setup individual matchups
    /// </summary>
    public class TeamMatchup
    {
        public TeamModel TeamA { get; set; }
        public TeamModel TeamB { get; set; }
        public Round Round { get; set; }
    }
}