namespace clanTournament.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class JoinTeamModel
    {
        [Required]
        [Display(Name="Team")]
        public string SelectedTeam { get; set; }
        public IEnumerable<SelectListItem> Team { get; set; }
    }
}