using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            string[] nk = str1.ToString().Split(new char[] { ' ' });
            
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            string[] dates = new string[n];
            for (int i = 0; i < n; i++)
            {
                dates[i] = Console.ReadLine();
            }

            dates.OrderBy(x => x);

            Console.WriteLine(dates[k]);
        }
    }
}
