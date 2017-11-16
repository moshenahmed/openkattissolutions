using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    class ColdPuterScience
    {
        public void Negativenumberscount()
        {
            int size = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int count = 0;
            if (size >= 1 && size <= 100)
            {
                for (int i = 0; i < size; i++)
                {
                    int number = int.Parse(input[i]);
                    if (number <= 1000000 && number >= -1000000)
                    {

                        if (number < 0)
                        {

                            count++;
                        }

                    }
                }
                Console.WriteLine(count);

            }
        }
    }
}
