// See https://aka.ms/new-console-template for more information
using csharp_ef_players.Models;
using csharp_ef_players;
using System.Xml.Serialization;
using System.ComponentModel.Design;

bool go = true;
Console.WriteLine("------- MENU -------");
Console.WriteLine("0. Quit");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Search and print a player by Id");
Console.WriteLine("3. Search and print a player by its Name and Surname");
Console.WriteLine("4. Modify player matches and score of player by its Id");
Console.WriteLine("5. Insert a new team");
Console.WriteLine("6. Search and print a team by Id");

Console.WriteLine("-------------------");
while (go)
{
    Console.Write("Choose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response)
    {
        case 0:
            Console.WriteLine("Thank you and goodbye");
            go = false;
            break;
        case 1:
            Console.Write("Insert the name of the player: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Insert the surname : ");
            string playerSurname = Console.ReadLine();
            using (PlayerContext db = new PlayerContext())
            {
                Random random = new Random();
                int randomScore = random.Next(1, 10);
                int randomNumberOfMatches = random.Next(1, 101);
                int randomNumberOfVicories = random.Next(1, randomNumberOfMatches);
                Player newPlayer = new Player { Name = playerName, LastName = playerSurname, PlayerMatches = randomNumberOfMatches, PlayerScore = randomScore, PlayerVictories = randomNumberOfVicories };
                db.Add(newPlayer);
                db.SaveChanges();
            }
            break;
        case 2:
            Console.Write("Insert the Id to search: ");
            int playerIdToSearch = int.Parse(Console.ReadLine());

            using(PlayerContext db = new PlayerContext())
            {
                Player playerFound = db.Players.Where(player => player.PlayerId == playerIdToSearch).First();
                Console.WriteLine(playerFound);
            }
            break;

        case 3:
            Console.Write("Insert the name of the player you want to search:");
            string playerNameToSearch = Console.ReadLine();
            Console.WriteLine("Insert the surname of the player you want to search : ");
            string playerSurnameToSearch = Console.ReadLine();
            using(PlayerContext db = new PlayerContext())
            {
                Player playerFound = db.Players.Where(player=> player.Name == playerNameToSearch && player.LastName == playerSurnameToSearch).First();
                Console.WriteLine(playerFound.ToString());

            }
            break;

        case 4:
            Console.Write("Insert the Id to search: ");
            int playerIdToModify = int.Parse(Console.ReadLine());

            using( PlayerContext db = new PlayerContext())
            {
                if (db.Players.Where(player => player.PlayerId == playerIdToModify).Any())
                {
                    Player playerToModify = db.Players.Where(player => player.PlayerId == playerIdToModify).First();

                    Console.Write("Insert the new player matches done: ");
                    int newPlayerMatches = int.Parse(Console.ReadLine());

                    Console.Write("Insert the new score points done: ");
                    int newPlayerScore = int.Parse(Console.ReadLine());

                    playerToModify.PlayerMatches = newPlayerMatches;
                    playerToModify.PlayerScore = newPlayerScore;

                    db.SaveChanges();
                } else
                {
                    Console.WriteLine("Non è stato trovato nessun giocatore con id = " + playerIdToModify);
                }
  
            }
            break;

        case 5:
            Console.Write("Insert the name of the team: ");
            string NewTeamName = Console.ReadLine();
            Console.Write("Insert the city of the team : ");
            string NewTeamCity = Console.ReadLine();
            Console.Write("Insert the coach of the team : ");
            string NewTeamCoach = Console.ReadLine();
            Console.Write("Insert the colours of the team :");
            string NewTeamColours = Console.ReadLine();

            using (PlayerContext db = new PlayerContext())
            {

                Team newTeam = new Team { TeamName = NewTeamName , TeamCity = NewTeamCity, TeamCoach=NewTeamCoach, TeamColours=NewTeamColours };
                db.Add(newTeam);
                db.SaveChanges();
            }
            break;

            case 6:
        
                Console.Write("Insert the Id to search: ");
                int teamIdToSearch = int.Parse(Console.ReadLine());

                using (PlayerContext db = new PlayerContext())
                {
                    Team teamFound = db.Teams.Where(team => team.TeamId == teamIdToSearch).First();
                    Console.WriteLine(teamFound);
                }
                break;

        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
        
    }
}






/*
Console.WriteLine("Hello, World!");
using (PlayerContext db = new PlayerContext())
{
    
    Player Giocatore1 = new Player {Name = "Pinco", LastName = "Pallino", PlayerMatches = 100, PlayerScore = 30, PlayerVictories = 2 };
    Player Giocatore2 = new Player {  Name ="Ciccio", LastName = "Panza", PlayerMatches= 50, PlayerScore = 12, PlayerVictories=1 };
    db.Add(Giocatore1);
    db.Add(Giocatore2);
    db.SaveChanges();

    db.Remove(Giocatore1);


    Console.WriteLine(Giocatore1);
    Console.WriteLine(Giocatore2);
    


}
*/