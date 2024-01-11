using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hejner_Balint_DartStat
{
    public class Round
    {
        [PrimaryKey] [AutoIncrement] public int ID { get; set; }
        [AutoIncrement] [Required] public int LegNumber { get; set; }
        [Required] public int DartsThrown { get; set; }
        [Required] public int Score { get; set; }
        [Required] public double AverageScore { get; set; }


        public Round(int legNumber, int dartsThrown, int score, double averageScore)
        {
            LegNumber = legNumber;
            DartsThrown = dartsThrown;
            Score = score;
            AverageScore = averageScore;
        }

        public Round()
        {

        }
    }
}
