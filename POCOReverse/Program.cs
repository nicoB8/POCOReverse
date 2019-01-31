using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var allPlayers = new List<Player>();

            var team = new Team()
            {
                Name = "Team Queso",
                Logo = "url"
            };

            var player1 = new Player()
            {
                UserName = "NicoB8",
                TeamId = 1
            };
            
            using(var context = new POCOContext())
            {
                context.Teams.Add(team);
                context.SaveChanges();
                context.Players.Add(player1);
                context.SaveChanges();

                allPlayers = context.Players.ToList();
                Console.WriteLine("List of players of the League");
                Console.WriteLine();
                foreach (var player in allPlayers)
                {
                    Console.WriteLine(player.Id + " - " + player.Team.Name + " - " + player.UserName);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
