using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0224Review
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            int valnum = 0;
            int.TryParse(val, out valnum);

            int[] arr = new int[valnum];

            for (int i = 0; i < valnum; i++)
            {
                string msg = Console.ReadLine();

                Console.WriteLine(i);

                if (msg.IndexOf("push") == 0)
                {
                    
                }
            }
        }
    }
}
