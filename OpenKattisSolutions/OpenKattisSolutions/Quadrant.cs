using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    class Quadrant
    {
        public void Solvequadrant()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x >= -1000 && x <= 1000 && x != 0 && y >= -1000 && y <= 1000 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("2");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("4");
                }
                else
                {
                    Console.WriteLine("3");
                }
            }
        }
    }
}
