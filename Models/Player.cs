using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players.Models
{
    [Table ("players_table")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int PlayerScore { get; set; }
        public int PlayerMatches { get; set; }
        public int PlayerVictories { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }


        public string PlayerIDConvertToString()
        {
            string PlayerIDReturn = "";
           PlayerIDReturn = PlayerId.ToString();
            return PlayerIDReturn;
        }

        public override string ToString()
        {
           
            string PlayerInfo= $"Nome: {Name}\n" + 
                $"Cognome: {LastName}\n" + 
                $"Punteggio: {PlayerScore}\n" + 
                $"Partite Giocate: {PlayerMatches}\n" + 
                $"Partite Vinte: {PlayerVictories}\n";

            return PlayerInfo;
        }


    }
}
