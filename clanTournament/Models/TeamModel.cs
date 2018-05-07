using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clanTournament.Models
{
    /// <summary>
    /// Team model to place teams in the bracket
    /// </summary>
    public class TeamModel
    {
        public int ID { get; set; }
        public string TeamName { get; set; }        
        public int Seed { get; set; }
        public string ClanName { get; set; }
    }
}