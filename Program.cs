// See https://aka.ms/new-console-template for more information
using csharp_ef_players.Models;

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