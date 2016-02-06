using NBATeamTwitterTrends.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBATeamTwitterTrends.ViewModel
{
    public class TeamListViewModel
    {
        public List<NBATeamModel> InitiateListValues()
        {
            List<NBATeamModel> teamList = new List<NBATeamModel>();

            teamList.Add(new NBATeamModel() { teamCity = "Chicago",       teamName = "Bulls",          teamImagePath = "/Images/Bulls.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Cleveland",     teamName = "Cavaliers",      teamImagePath = "/Images/Cavaliers.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Atlanta",       teamName = "Hawks",          teamImagePath = "/Images/Hawks.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Washington",    teamName = "Wizards",        teamImagePath = "/Images/Wizards.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Boston",        teamName = "Celtics",        teamImagePath = "/Images/Celtics.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Milwalkee",     teamName = "Bucks",          teamImagePath = "/Images/Bucks.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Orlando",       teamName = "Magic",          teamImagePath = "/Images/Magic.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Toronto",       teamName = "Raptors",        teamImagePath = "/Images/Raptors.png"});
            teamList.Add(new NBATeamModel() { teamCity = "New York",      teamName = "Knicks",         teamImagePath = "/Images/Knicks.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Detroit",       teamName = "Pistons",        teamImagePath = "/Images/Pistons.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Miami",         teamName = "Heat",           teamImagePath = "/Images/Heat.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Indiana",       teamName = "Pacers",         teamImagePath = "/Images/Pacers.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Charlotte",     teamName = "Hornets",        teamImagePath = "/Images/Hornets.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Philadelphia",  teamName = "Seventy Sixers", teamImagePath = "/Images/Sixers.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Brooklyn",      teamName = "Nets",           teamImagePath = "/Images/Nets.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Golden State",  teamName = "Warriors",       teamImagePath = "/Images/Warriors.png"});
            teamList.Add(new NBATeamModel() { teamCity = "New Orleans",   teamName = "Pelicans",       teamImagePath = "/Images/Pelicans.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Los Angeles",   teamName = "Clippers",       teamImagePath = "/Images/Clippers.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Houston",       teamName = "Rockets",        teamImagePath = "/Images/Rockets.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Portland",      teamName = "TrailBlazers",   teamImagePath = "/Images/Blazers.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Memphis",       teamName = "Grizzles",       teamImagePath = "/Images/Grizzles.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Denver",        teamName = "Nuggets",        teamImagePath = "/Images/Nuggets.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Los Angeles",   teamName = "Lakers",         teamImagePath = "/Images/Lakers.png"});
            teamList.Add(new NBATeamModel() { teamCity = "San Antonio",   teamName = "Spurs",          teamImagePath = "/Images/Spurs.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Phoenix",       teamName = "Suns",           teamImagePath = "/Images/Suns.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Minesota",      teamName = "TimberWolves",   teamImagePath = "/Images/Wolves.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Utah",          teamName = "Jazz",           teamImagePath = "/Images/Jazz.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Sacramento",    teamName = "Kings",          teamImagePath = "/Images/Kings.png"});
            teamList.Add(new NBATeamModel() { teamCity = "Dallas",        teamName = "Mavericks",      teamImagePath = "/Images/Mavericks.png" });
            teamList.Add(new NBATeamModel() { teamCity = "Oklahoma City", teamName = "Thunder",        teamImagePath = "/Images/Thunder.png" });

            List<NBATeamModel> teamListOrdered = teamList.OrderBy(team => team.teamCity).ThenBy(team => team.teamName).ToList();
            return teamListOrdered;
        }
    }
}
