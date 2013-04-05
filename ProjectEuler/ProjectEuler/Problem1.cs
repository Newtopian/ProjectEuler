using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     *If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
     * The sum of these multiples is 23.
     * 
     * Find the sum of all the multiples of 3 or 5 below 1000.
     * 
     */
    class Problem1
    {
        public static IEnumerable<int> FindMultiplesBelow(int aMultipleOf, int aUpperLimit)
        {
            return 0.To(aUpperLimit - 1).Where(i => i % aMultipleOf == 0);
        }

        public static int SolveProblem()
        {
            HashSet<int> multiples = new HashSet<int>();
            //Find multples of 3 below 10
            foreach (int i in FindMultiplesBelow(3, 10))
            {
                multiples.Add(i);
            }

            foreach (int i in FindMultiplesBelow(5, 10))
            {
                multiples.Add(i);
            }

            if (multiples.Aggregate((total, i) => total + i) != 23)
            {
                Console.WriteLine("WOOPS -- " + string.Join(", ", multiples));
            }

            multiples.Clear();
            //Find multples of 3 below 10
            foreach (int i in FindMultiplesBelow(3, 1000))
            {
                multiples.Add(i);
            }

            foreach (int i in FindMultiplesBelow(5, 1000))
            {
                multiples.Add(i);
            }
            return multiples.Aggregate((total, i) => total + i);
        }
    }
}
