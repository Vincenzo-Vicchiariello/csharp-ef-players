using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players.Models

{
    [Table ("teams_table")]
    //[Index(nameof(TeamName)), IsUnique = true]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamCity { get; set; }
        public string TeamCoach { get; set; }
        public string TeamColours { get; set; }

        public List<Team> Players { get; set;}

        public override string ToString()
        {
            string TeamInfo = $"Team name: {TeamName}\n"
                + $"Team City: {TeamCity}\n"
                + $"Team Coach: {TeamCoach} ";
            return TeamInfo;
        }

     

    }
}
