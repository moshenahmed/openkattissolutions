using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    public class TwoStones
    {
        public void SolveTwoStones() { 
        int input = int.Parse(Console.ReadLine());
        string[] TakeTwoStones = new string[input];
            //int count = 1;
            if (input == 1)
            {

                Console.WriteLine("Alice");
            }

            else if (input >= 1 && input % 2 == 1)
            {

                Console.WriteLine("Alice");
            }



            else
            {
                Console.WriteLine("bob");
            }
     

        }
    }
}
