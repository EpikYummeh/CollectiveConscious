using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clanTournament.Models
{
    public class SignupModel
    {
        public int Id { get; set; }
        public string BattlenetId { get; set; }
        public TeamModel Team { get; set; }
    }
}