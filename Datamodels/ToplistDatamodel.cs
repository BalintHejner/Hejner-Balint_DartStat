using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hejner_Balint_DartStat.Datamodels
{
    public class ToplistDatamodel
    {
        //private int NumberOfLeg;
        //private int Arrows;
        //private int MaxScore;
        //private int Average;

        private int Points;

        public int points
        {
            get { return Points; }
            set { Points = value; }
        }


        private int NumberOfLeg;

        public int numberofleg
        {
            get { return NumberOfLeg; }
            set { NumberOfLeg = value; }
        }

        private int Arrows;

        public int arrows
        {
            get { return Arrows; }
            set { Arrows = value; }
        }

        private int MaxScore;

        public int maxscore
        {
            get { return MaxScore; }
            set { MaxScore = value; }
        }

        private int Average;

        public int average
        {
            get { return Average; }
            set { Average = value; }
        }

        public ToplistDatamodel(int points, int numberofleg, int arrows, int maxscore, int average)
        {
            this.points = points;
            this.numberofleg = numberofleg;
            this.arrows = arrows;
            this.maxscore = maxscore;
            this.average = average;
        }

        public ToplistDatamodel()
        {
            
        }
    }
}
