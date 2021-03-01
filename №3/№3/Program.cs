using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = 0;

            while(str != "")
            {
                if (str[0] == '0')
                {
                    str = str.Remove(0, 8);
                    count++;
                }
                else if (str[0] == '1' && str[1] == '1' && str[2] == '0')
                {
                    str = str.Remove(0, 16);
                    count++;
                }
                else if (str[0] == '1' && str[1] == '1' && str[2] == '1' && str[3] == '0')
                {
                    str = str.Remove(0, 24);
                    count++;
                }
                else if (str[0] == '1' && str[1] == '1' && str[2] == '1' && str[3] == '1' && str[4] == '0')
                {
                    str = str.Remove(0, 32);
                    count++;
                }
                else if (str[0] == '1' && str[1] == '1' && str[2] == '1' && str[3] == '1' && str[4] == '1' && str[5] == '0')
                {
                    str = str.Remove(0, 40);
                    count++;
                }
                else if (str[0] == '1' && str[1] == '1' && str[2] == '1' && str[3] == '1' && str[4] == '1' && str[5] == '1' && str[6] == '0')
                {
                    str = str.Remove(0, 48);
                    count++;
                }
                else break;
            }


            Console.WriteLine(count);
        }
    }
}
