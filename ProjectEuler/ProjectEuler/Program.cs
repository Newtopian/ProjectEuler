using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEuler
{
    static class Program
    {
 
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Solution to Problem 1 is = " + Problem1.SolveProblem());
        }
    }
}
