## 1. 사분면 고르기
```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        // 1. 사분면 고르기(백준 14681)
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a < 0 && b < 0)
            Console.WriteLine("3");
        else if (a < 0 && b > 0)
            Console.WriteLine("2");
        else if (a > 0 && b < 0)
            Console.WriteLine("4");
        else
            Console.WriteLine("1");
    }
}
```

## 2. 윤년
```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        // 2. 윤년(백준 2753)
        // 4의 배수면서 100의 배수가 아닐때 
        // 4의 배수면서 400의 배수일때
        int a = int.Parse(Console.ReadLine());

        if (a % 4 == 0 && a % 100 == 0 && a % 400 == 0)
            Console.WriteLine("1");
        else if (a % 4 == 0 && a % 400 == 0 && a % 100 != 0)
            Console.WriteLine("1");
        else if(a % 4 == 0 && a % 100 != 0)
            Console.WriteLine("1");
        else
            Console.WriteLine("0");
    }
}
```

경우의 수가 분명한 조건문 문제입니다. 사분면 고르기는 받은 수에따라 조건에 넣어서 출력하면되고, 윤년은 각각의 경우의 수를 따져서 조건문에 넣어주면됩니다.<br>
(윤년 문제는 한글 이해가 95%인듯... 봐도 이해안됨)

