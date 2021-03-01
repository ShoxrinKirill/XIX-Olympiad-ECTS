using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            string[] pn = str1.ToString().Split(new char[] { ' ' });

            int p = int.Parse(pn[0]);
            int n = int.Parse(pn[1]);

            int count = 0;
            int list = 0;

            string[] ak = str2.ToString().Split(new char[] { ' ' });;
            for(int k = 0; k < ak.Length; k++)
            {
                list += int.Parse(ak[k]);
                if (list == p)
                {
                    count++;
                    list = 0;
                }
                else if (list < p && list + int.Parse(ak[k + 1]) > p)
                {
                    count++;
                    list = 0;
                }
                else if (list < p && list + int.Parse(ak[k + 1]) <= p)
                {
                    continue;
                }
            }

            Console.WriteLine(count);
        }
    }
}
