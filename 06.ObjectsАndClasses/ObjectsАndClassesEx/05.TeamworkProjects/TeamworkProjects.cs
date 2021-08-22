using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] creatorAndTeamName = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = creatorAndTeamName[0];
                string teamName = creatorAndTeamName[1];

                Team existingTeam = GetTeam(teams, teamName);

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (CreatorExists(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team
                {
                    Name = teamName,
                    Creator = creator
                };

                teams.Add(newTeam);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] commandArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = commandArgs[0];
                string teamToJoin = commandArgs[1];

                Team existingTeam = GetTeam(teams, teamToJoin);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");

                    command = Console.ReadLine();
                    continue;
                }
                if (IsMember(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");

                    command = Console.ReadLine();
                    continue;
                }

                existingTeam.Members.Add(user);

                command = Console.ReadLine();
            }

            List<Team> sotredTeams = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            foreach (Team team in sotredTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                List<string> storedMember = team.Members
                    .OrderBy(t => t)
                    .ToList();

                foreach (string member in storedMember)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.Name);
            }
        }

        static Team GetTeam(List<Team> teams, string teamToJoin)
        {
            foreach (Team team in teams)
            {
                if (team.Name == teamToJoin)
                {
                    return team;
                }
            }

            return null;
        }

        static bool IsMember(string user, List<Team> teams)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == user) // || team.Members.Contains(user) - можем да махнем втория foreach
                {
                    return true;
                }

                foreach (string member in team.Members)
                {
                    if (member == user)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool CreatorExists(List<Team> teams, string creator)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == creator)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Team
    {
        public Team()
        {
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
