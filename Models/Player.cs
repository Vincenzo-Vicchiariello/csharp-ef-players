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


        public string getPlayerId()
        {

           // this.PlayerId = PlayerId.ToString();
           // return this.PlayerId;
        }


    }
}
