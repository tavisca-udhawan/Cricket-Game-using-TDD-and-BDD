using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public Cricket()
        {
            PlayerScore = 0;
            active =true;
        }
        public int PlayerScore { get; set; }
        public bool active { get; set; }
        public void Score(int runs)
        {
            if (active == true)
            {
                if (runs > 0 && runs <= 6)
                    PlayerScore += runs;
                else if (runs < 0 || runs > 6)
                    PlayerScore += 0;
            }
        }
    }
}
