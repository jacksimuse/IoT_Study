# 1번문제 사분면 고르기

```C#
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
```

# 2번문제 윤년
```C#
            // 숫자를 받아온다
            int yoonnyeon = int.Parse(Console.ReadLine());

            if ((yoonnyeon % 4 == 0) && (yoonnyeon % 100 != 0) // 4의 배수이고 100의 배수가 아님
                || (yoonnyeon % 400 == 0)) // 또는 400의 배수
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
```
