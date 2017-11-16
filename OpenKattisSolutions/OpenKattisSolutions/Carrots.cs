using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    public class Carrots
    {
        public void Solvingcarrots() {

            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int P = int.Parse(input[1]);

            if (N >= 1 && P <= 1000)
            {
                string names;
                string[] contestants = new string[N];
                for (int i = 0; i < N; i++)
                {
                    names = Console.ReadLine();
                    contestants[i] = names;
                }
                Console.WriteLine(P);
            }
        }
}
}