using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    class Pot
    {
        public void Power()
        {
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            if (N >= 1 && N <= 10)
            {
                for (int i = 1; i <= N; i++)
                {
                    int P = int.Parse(Console.ReadLine());
                    if (P >= 10 && P <= 9999)
                    {
                        double power = P % 10;
                        double number = P / 10;
                        double X = Math.Pow(number, power);

                        sum += X;
                    }

                }
                Console.WriteLine(sum);

            }
        }
    }
}
