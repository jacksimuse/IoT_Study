using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 윤년
{
    class Program
    {
        static void Main(string[] args)
        {
            // 숫자를 받아온다
            int yoonnyeon = int.Parse(Console.ReadLine());

            if ((yoonnyeon % 4 == 0) && (yoonnyeon % 100 != 0) // 4의 배수이고 100의 배수가 아님
                || (yoonnyeon % 400 == 0)) // 또는 400의 배수
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

        }
    }
}
