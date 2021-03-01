using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i < 25)
            {
                if (n == 7)
                {
                    n = 1;
                    i++;
                }
                else if (n < 7)
                {
                    n++;
                    i++;
                }
            }

            Console.WriteLine(n);
        }
    }
}
