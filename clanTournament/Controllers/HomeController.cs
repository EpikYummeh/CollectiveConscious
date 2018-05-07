using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using clanTournament.Models;
using System.Net;
using Bungie;
using Bungie.Models;
using System.Threading.Tasks;
using System.Web.Services;

namespace clanTournament.Controllers
{
    public class HomeController : Controller
    {
        const string apiKey = "03e7fac7f7dc4ffa8ab2c83092a71a87";
        public async Task<ActionResult> Index()
        {

            //testing teams
            IList<TeamModel> tournamentList = new List<TeamModel>();            
            tournamentList.Add(new TeamModel() { ID = 1, Seed = 1, ClanName = "Clan 1", TeamName = TruncateTeamName("The Broken Div Elements") });
            tournamentList.Add(new TeamModel() { ID = 2, Seed = 2, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 2") });
            tournamentList.Add(new TeamModel() { ID = 3, Seed = 3, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 3") });
            tournamentList.Add(new TeamModel() { ID = 4, Seed = 4, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 4") });
            tournamentList.Add(new TeamModel() { ID = 5, Seed = 5, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 5") });
            tournamentList.Add(new TeamModel() { ID = 6, Seed = 6, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 6") });
            tournamentList.Add(new TeamModel() { ID = 7, Seed = 7, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 7") });
            tournamentList.Add(new TeamModel() { ID = 8, Seed = 8, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 8") });
            tournamentList.Add(new TeamModel() { ID = 9, Seed = 9, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 9") });
            tournamentList.Add(new TeamModel() { ID = 10, Seed = 10, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 10") });
            tournamentList.Add(new TeamModel() { ID = 11, Seed = 11, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 11") });
            tournamentList.Add(new TeamModel() { ID = 12, Seed = 12, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 12") });
            tournamentList.Add(new TeamModel() { ID = 13, Seed = 13, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 13") });
            tournamentList.Add(new TeamModel() { ID = 14, Seed = 14, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 14") });
            tournamentList.Add(new TeamModel() { ID = 15, Seed = 15, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 15") });
            tournamentList.Add(new TeamModel() { ID = 16, Seed = 16, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 16") });

            tournamentList.Add(new TeamModel() { ID = 17, Seed = 1, ClanName = "Clan 2", TeamName = TruncateTeamName("The Unbroken Div Elements") });
            tournamentList.Add(new TeamModel() { ID = 18, Seed = 2, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 18") });
            tournamentList.Add(new TeamModel() { ID = 19, Seed = 3, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 19") });
            tournamentList.Add(new TeamModel() { ID = 20, Seed = 4, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 20") });
            tournamentList.Add(new TeamModel() { ID = 21, Seed = 5, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 21") });
            tournamentList.Add(new TeamModel() { ID = 22, Seed = 6, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 22") });
            tournamentList.Add(new TeamModel() { ID = 23, Seed = 7, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 23") });
            tournamentList.Add(new TeamModel() { ID = 24, Seed = 8, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 24") });
            tournamentList.Add(new TeamModel() { ID = 25, Seed = 9, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 25") });
            tournamentList.Add(new TeamModel() { ID = 26, Seed = 10, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 26") });
            tournamentList.Add(new TeamModel() { ID = 27, Seed = 11, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 27") });
            tournamentList.Add(new TeamModel() { ID = 28, Seed = 12, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 28") });
            tournamentList.Add(new TeamModel() { ID = 29, Seed = 13, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 29") });
            tournamentList.Add(new TeamModel() { ID = 30, Seed = 14, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 30") });
            tournamentList.Add(new TeamModel() { ID = 31, Seed = 15, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 31") });
            tournamentList.Add(new TeamModel() { ID = 32, Seed = 16, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 32") });

            //setup matchup lists to add teams to conferences. I thought this could work by clan
            var matchupsA = new List<TeamMatchup>();
            var matchupsB = new List<TeamMatchup>();
            var matchCount = 1;
            var currentMatch = new TeamMatchup();

            foreach (var team in tournamentList)
            {
                if(team.ClanName == "Clan 1")
                {
                    if (matchCount % 2 == 0)
                    {
                        currentMatch.TeamB = team;
                        matchupsA.Add(currentMatch);

                        currentMatch = new TeamMatchup();
                    }
                    else
                    {
                        currentMatch.TeamA = team;
                    }
                }
                else
                {
                    if (matchCount % 2 == 0)
                    {
                        currentMatch.TeamB = team;
                        matchupsB.Add(currentMatch);

                        currentMatch = new TeamMatchup();
                    }
                    else
                    {
                        currentMatch.TeamA = team;
                    }
                }

                matchCount++;
            }
            //setup test ViewData
            await BungieTest();
            ViewData["MatchupsA"] = matchupsA;
            ViewData["MatchupsB"] = matchupsB;
            return View();
        }
        /// <summary>
        /// Test to see if Bungie API is working
        /// When querying a Battle Net gamer tag, you need to use %23 instead of #
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> BungieTest()
        {
            DestinyService service = new DestinyService(apiKey);
            string memberId = string.Empty;
            try
            {
                Bungie.Responses.SearchPlayersResponse member = await service.SearchPlayers(MembershipType.Blizzard, "dasWoj%231113");
                memberId = member[0].MembershipId.ToString();
            }
            catch(Exception ex)
            {
                memberId = ex.Message;
            }
            ViewBag.GetMemberId = memberId;
            return View();
        }
        /// <summary>
        /// Used to Truncate long team names as they wouldn't fit in the div boxes if longer than 15 characters
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        private string TruncateTeamName(string teamName)
        {
            string teamReturned = teamName;
            if(teamName.Length > 12)
            {
                teamReturned = teamName.Remove(12).Insert(12, "...");
            }
            return teamReturned;
        }
    }
}