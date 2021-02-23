using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100 ; i++)
            {
                for (int j = 0; j < 100 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
