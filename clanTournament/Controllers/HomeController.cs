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
        DestinyService service = new DestinyService(apiKey);
        GroupService groupService = new GroupService(apiKey);
        Models.CoCodbEntities1 _db;
        public HomeController()
        {
            _db = new CoCodbEntities1();
        }
#region MessageViews
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }

#endregion

#region IndexView
        public ActionResult Index()
        {
            _db.Database.Initialize(false);
            //testing teams
            IList<TeamModel> tournamentList = new List<TeamModel>();            
            tournamentList.Add(new TeamModel() { Id = 1, Seed = 1, ClanName = "Clan 1", TeamName = TruncateTeamName("The Broken Div Elements") });
            tournamentList.Add(new TeamModel() { Id = 2, Seed = 2, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 2") });
            tournamentList.Add(new TeamModel() { Id = 3, Seed = 3, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 3") });
            tournamentList.Add(new TeamModel() { Id = 4, Seed = 4, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 4") });
            tournamentList.Add(new TeamModel() { Id = 5, Seed = 5, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 5") });
            tournamentList.Add(new TeamModel() { Id = 6, Seed = 6, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 6") });
            tournamentList.Add(new TeamModel() { Id = 7, Seed = 7, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 7") });
            tournamentList.Add(new TeamModel() { Id = 8, Seed = 8, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 8") });
            tournamentList.Add(new TeamModel() { Id = 9, Seed = 9, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 9") });
            tournamentList.Add(new TeamModel() { Id = 10, Seed = 10, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 10") });
            tournamentList.Add(new TeamModel() { Id = 11, Seed = 11, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 11") });
            tournamentList.Add(new TeamModel() { Id = 12, Seed = 12, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 12") });
            tournamentList.Add(new TeamModel() { Id = 13, Seed = 13, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 13") });
            tournamentList.Add(new TeamModel() { Id = 14, Seed = 14, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 14") });
            tournamentList.Add(new TeamModel() { Id = 15, Seed = 15, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 15") });
            tournamentList.Add(new TeamModel() { Id = 16, Seed = 16, ClanName = "Clan 1", TeamName = TruncateTeamName("Team 16") });

            tournamentList.Add(new TeamModel() { Id = 17, Seed = 1, ClanName = "Clan 2", TeamName = TruncateTeamName("The Unbroken Div Elements") });
            tournamentList.Add(new TeamModel() { Id = 18, Seed = 2, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 18") });
            tournamentList.Add(new TeamModel() { Id = 19, Seed = 3, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 19") });
            tournamentList.Add(new TeamModel() { Id = 20, Seed = 4, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 20") });
            tournamentList.Add(new TeamModel() { Id = 21, Seed = 5, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 21") });
            tournamentList.Add(new TeamModel() { Id = 22, Seed = 6, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 22") });
            tournamentList.Add(new TeamModel() { Id = 23, Seed = 7, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 23") });
            tournamentList.Add(new TeamModel() { Id = 24, Seed = 8, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 24") });
            tournamentList.Add(new TeamModel() { Id = 25, Seed = 9, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 25") });
            tournamentList.Add(new TeamModel() { Id = 26, Seed = 10, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 26") });
            tournamentList.Add(new TeamModel() { Id = 27, Seed = 11, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 27") });
            tournamentList.Add(new TeamModel() { Id = 28, Seed = 12, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 28") });
            tournamentList.Add(new TeamModel() { Id = 29, Seed = 13, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 29") });
            tournamentList.Add(new TeamModel() { Id = 30, Seed = 14, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 30") });
            tournamentList.Add(new TeamModel() { Id = 31, Seed = 15, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 31") });
            tournamentList.Add(new TeamModel() { Id = 32, Seed = 16, ClanName = "Clan 2", TeamName = TruncateTeamName("Team 32") });

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
            //await BungieTest();
            ViewData["MatchupsA"] = matchupsA;
            ViewData["MatchupsB"] = matchupsB;
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
#endregion


#region SignupView

        /// <summary>
        /// Instatiate the Signup View
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        /// <summary>
        /// Insert data on post into sql db.
        /// It currently grabs the membership id and clan name from the battle net name.
        /// Will need to redesign form later to include joining a team and a callback message when a user has been created
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

#endregion
#region CreateTeamView/JoinTeamView
        /// <summary>
        /// Instatiate the Create Team View
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateTeam(GuardianModel model)
        {            
            try
            {
                string BNETId = model.DisplayName.Replace("#", "%23");
                long memberId = 0;
                if (ModelState.IsValid)
                {
                    Bungie.Responses.SearchPlayersResponse member = await service.SearchPlayers(MembershipType.Blizzard, BNETId);
                    memberId = member[0].MembershipId;
                    Bungie.Responses.GetGroupsForMemberResponse group = await groupService.GetGroupsForMember(MembershipType.Blizzard, memberId, GroupsForMemberFilter.All, GroupType.Clan);
                    using (var context = new CoCodbEntities1())
                    {
                        var t = new TeamModel
                        {
                            TeamName = model.TeamModel.TeamName,
                            ClanName = group.Results[0].Group.Name
                        };
                        var g = new GuardianModel
                        {
                            MembershipId = memberId.ToString(),
                            DisplayName = BNETId,
                            MembershipType = 4,
                            TeamID = t.Id
                        };

                        if(_db.TeamModels.Any(team => team.TeamName == t.TeamName))
                        {
                            TempData["UserMessage"] = new MessageVM() { ClassName = "alert-error", Title = "Error!", Message = "The team name you entered has already been used. Please select another team name." };
                        }
                        else
                        {
                            context.TeamModels.Add(t);
                            if (_db.GuardianModels.Any(guardian => guardian.MembershipId == g.MembershipId))
                            {
                                TempData["UserMessage"] = new MessageVM() { ClassName = "alert-error", Title = "Error!", Message = "This Guardian has already been registered. Please sign up with a different Battle Net ID." };
                            }
                            else
                            {
                                context.GuardianModels.Add(g);
                                context.SaveChanges();
                                TempData["UserMessage"] = new MessageVM() { ClassName = "alert-success", Title = "Success!", Message = "Your Team has been saved." };
                            }
                        }                                                                    
                        return RedirectToAction("Success");
                    }
                }

            }
            catch (Exception ex)
            {
                TempData["UserMessage"] = new MessageVM() { ClassName = "alert-error", Title = "Error!", Message = ex.Message };
                return RedirectToAction("Error");
            }


            return View(model);
        }

        [HttpGet]
        public ActionResult JoinTeam()
        {
            var TeamList = _db.TeamModels.ToList();
            SelectList list = new SelectList(TeamList, "Id", "TeamName");
            ViewBag.TeamList = list;

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> JoinTeam(GuardianModel model)
        {            

            try
            {
                string BNETId = model.DisplayName.Replace("#", "%23");
                long memberId = 0;
                if (ModelState.IsValid)
                {
                    Bungie.Responses.SearchPlayersResponse member = await service.SearchPlayers(MembershipType.Blizzard, BNETId);
                    memberId = member[0].MembershipId;
                }
                using (var context = new CoCodbEntities1())
                {
                    var g = new GuardianModel
                    {
                        MembershipId = memberId.ToString(),
                        DisplayName = BNETId,
                        MembershipType = 4,
                        TeamID = model.TeamModel.Id
                    };
                    if (_db.GuardianModels.Any(guardian => guardian.MembershipId == g.MembershipId))
                    {
                        TempData["UserMessage"] = new MessageVM() { ClassName = "alert-error", Title = "Error!", Message = "This Guardian has already been registered. Please sign up with a different Battle Net ID." };
                        return RedirectToAction("Error");
                    }
                    else
                    {
                        context.GuardianModels.Add(g);
                        context.SaveChanges();
                        TempData["UserMessage"] = TempData["UserMessage"] = new MessageVM() { ClassName = "alert-success", Title = "Success!", Message = "Joined the Team Successfully." };
                        return RedirectToAction("Success");
                    }                    
                }
            }
            catch(Exception ex)
            {
                TempData["UserMessage"] = TempData["UserMessage"] = new MessageVM() { ClassName = "alert-error", Title = "Error!", Message = ex.Message };
                return RedirectToAction("Success");
            }            
        }

#endregion
    }
}