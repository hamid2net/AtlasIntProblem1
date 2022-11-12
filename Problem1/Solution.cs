using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class Solution
    {
        public int BagOfTokensScore(int[] tokens, int power)
        {
            int score = 0, lI = 0, hI = tokens.Length - 1,result=0;
            Array.Sort(tokens);
            while (lI <= hI && (score>0 || power>= tokens[lI]))
            {
                while (lI<=hI && tokens[lI] <= power)
                {
                    power -= tokens[lI++];
                    score++;
                }
                result = Math.Max(result, score);
                if(lI <= hI && score>0)
                {
                    power += tokens[hI--];
                    score--;
                }

            }
            return result;
        }
    }
}
