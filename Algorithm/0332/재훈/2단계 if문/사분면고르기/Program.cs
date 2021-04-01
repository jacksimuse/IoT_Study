using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사분면고르기
{
    class Program
    {
        static void Main(string[] args)
        {
            // 숫자를 2개 받아온다
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
                Console.WriteLine("1"); // 둘다 양수면 1사분면
            else if (a < 0 && b > 0)
                Console.WriteLine("2"); // 둘다 양수면 2사분면
            else if (a < 0 && b < 0)
                Console.WriteLine("3"); // 둘다 양수면 3사분면
            else if (a > 0 && b < 0)
                Console.WriteLine("4"); // 둘다 양수면 4사분면
        }
    }
}
