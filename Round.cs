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
        [AutoIncrement] [Required] public int RoundNumber { get; set; }
        [Required] public int DartsThrown { get; set; }
        [Required] public int Score { get; set; }
        [Required] public int RemainingScore { get; set; }

        public Round(int roundNumber, int dartsThrown, int score, int remainingScore)
        {
            RoundNumber = roundNumber;
            DartsThrown = dartsThrown;
            Score = score;
            RemainingScore = remainingScore;
        }

        public Round()
        {

        }
    }
}
