using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenKattisSolutions
{
    class Spavanac
    {
        public void spavanac()
        {
            string[] input = Console.ReadLine().Split(' ');
            if ((int.Parse(input[0]) >= 0 || int.Parse(input[0]) <= 23) && (int.Parse(input[1]) <= 59 || int.Parse(input[1]) >= 0))
            {

                var time = DateTime.Now;
                var date = new DateTime(time.Year, time.Month, time.Day, int.Parse(input[0]), int.Parse(input[1]), 0);

                var timelag = date.AddMinutes(-45);






                Console.WriteLine(timelag.Hour + " " + timelag.Minute);
            }

        }
    }
}
