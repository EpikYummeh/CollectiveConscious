# CollectiveConscious
A tournament application for the Collective Conscious Destiny 2 clan.

## Notes:
The BungieNetPlatform solution is not the API connection that I am using for this project. It was an attempt to link into OAuth2 connection that Bungie uses, but I never fully got it setup, and this project doesn't need this type of authorization.

## Bungie API Usage:
```
DestinyService service = new DestinyService(apiKey); //api Key stored in HomeController.cs
Bungie.Responses.SearchPlayersResponse member = await service.SearchPlayers(MembershipType.Blizzard, "dasWoj%231113"); //ensure that you use %23 instead of #
memberId = member[0].MembershipId.ToString();
```
## Inserting into the DB Example:
```
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
                    context.TeamModels.Add(t);
                    context.GuardianModels.Add(g);
                    context.SaveChanges();
                }
```
