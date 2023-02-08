using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgScoresDemo
{
    internal class Score
    {
        public double Scores { get; set; }
        public Score(double scores)
        {
            Scores = scores;
        }

        public override string ToString()
        {
            return Scores.ToString("F2");
        }
    }
}
