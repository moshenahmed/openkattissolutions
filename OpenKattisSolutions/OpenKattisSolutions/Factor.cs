using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    class Factor
    {
        public void faktor() { 
        string[] input = Console.ReadLine().Split(' ');

        int A = int.Parse(input[0]);
        int I = int.Parse(input[1]);
        int C;
            if (A>=1 && A<=100 && I >= 1 && I <= 100)
            {
                C = A* (I - 1);
                Console.WriteLine(C+1);
            }
}
}
}
