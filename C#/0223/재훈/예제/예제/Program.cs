using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            string yoonnyeon = Console.ReadLine();

            int number = 0;
            int.TryParse(yoonnyeon, out number);
            if (number % 4 == 0)
            {
                if ((number % 100 != 0) || (number % 400 == 0))
                    Console.WriteLine("1");
            }
            else
                Console.WriteLine("0");
                
        }
    }
}
