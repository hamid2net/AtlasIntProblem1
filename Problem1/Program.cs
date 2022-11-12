using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(new Solution().BagOfTokensScore(new int[] { 100,200,300,400 }, 200));
            Console.ReadLine();
        }
    }
}
