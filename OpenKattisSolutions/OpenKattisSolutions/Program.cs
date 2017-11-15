using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenKattisSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] input = Console.ReadLine().ToCharArray();
            if (input.Length == 2) { 
            int N = int.Parse(Char.ToString(input[0]));
            int P = int.Parse(Char.ToString(input[1]));
            
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

            ////int count = 1;
            //if (input == 1)
            //{

            //    Console.WriteLine("Alice");
            //}

            //else if (input >= 1 && input % 2 == 1)
            //{

            //    Console.WriteLine("Alice");
            //}



            //else
            //{
            //    Console.WriteLine("bob");
            //}


        }




    }
}






