using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    class R2
    {
        public void r2()
        {
            string[] input = Console.ReadLine().Split(' ');

            int r1 = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int r2;

            if (r1 >= -1000 && r1 <= 1000 && s >= -1000 && s <= 1000)
            {
                r2 = 2 * s - r1;
                Console.WriteLine(r2);
            }
        }
    }
}
