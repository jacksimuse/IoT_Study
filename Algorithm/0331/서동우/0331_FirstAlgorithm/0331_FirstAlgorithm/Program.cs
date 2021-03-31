using System;
namespace _0331_FirstAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 곱셈 문제(백준 2588번)

            // 무식한 방법
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a * (b % 10));
            Console.WriteLine(a * ((b / 10) % 10));
            Console.WriteLine(a * ((b / 100) % 10));
            Console.WriteLine(a * b);

            // 배열로 푸는 우아한 방법 찾는중...



            Console.WriteLine();
            Console.WriteLine();


            // 2. 나머지 문제(백준 10430번)
            // SubString으로 하나씩 짤라서하다가 Split()을 발견해서 편하게 풀었습니다.
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
