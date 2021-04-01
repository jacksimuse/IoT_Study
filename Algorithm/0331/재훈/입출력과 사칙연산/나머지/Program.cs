using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 나머지
{
    class Program
    {
        static void Main(string[] args)
        {
            // 숫자 3개를 받아온다
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(); // 한 줄 띄우기용

            // 그대로 표현했다..
            Console.WriteLine((a + b) % c);
            Console.WriteLine((a % c) + (b % c) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine((a % c) * (b % c) % c);
        }
    }
}
