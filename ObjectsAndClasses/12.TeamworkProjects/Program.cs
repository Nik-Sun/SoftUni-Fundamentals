using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            bool errorFound = false;
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                Team currentTeam = new(input[1],input[0],1);
                currentTeam.AddMember(input[0]);
                foreach (Team team in teams)
                {
                    if (team.TeamName==currentTeam.TeamName)
                    {
                        Console.WriteLine($"Team {team.TeamName} was already created!");
                        errorFound = true;
                        break;
                    }
                    if (team.TeamCreator==currentTeam.TeamCreator)
                    {
                        Console.WriteLine($"{team.TeamCreator} cannot create another team!");
                        errorFound = true;
                        break;
                    }
                }
                if (!errorFound)
                {
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {currentTeam.TeamName} has been created by {currentTeam.TeamCreator}!");
                }
            }
            string input2 = Console.ReadLine();
            while (input2!= "end of assignment")
            {
                string[] queue = input2.Split("->");
                string member = queue[0];
                string teamToJoin = queue[1];
                bool teamExists = false;
                foreach (Team team in teams)
                {
                    if (team.TeamCreator==member)
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                        teamExists = true;
                        break;
                    }
                    if (team.TeamName==teamToJoin)
                    {
                        teamExists = true;
                        team.AddMember(member);
                        break;
                    }
                }
                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }



                input2 = Console.ReadLine();
            }
            foreach (Team item in teams)
            {
                item.Members.Sort();
            }
            teams = teams.OrderBy(x => x.TeamName).ToList();
            foreach (Team item in teams)
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine(string.Join("\n",item.Members));
              
            }


        }
    }
    class Team
    {
        public string TeamName { get; set; }
        public string TeamCreator { get; set; }
        public int MembersCount { get; set; }
        public List<string> Members { get; set; }
        public Team(string name, string creator, int members )
        {
            TeamName = name;
            TeamCreator = creator;
            MembersCount = members;
            Members = new List<string>();
        }
        public void AddMember(string s)
        {
            if (Members.Count==0)
            {
                Members.Add($"- {s}");
            }
            else
            {
                Members.Add($"-- {s}");
            }
        }
        
    }
}
