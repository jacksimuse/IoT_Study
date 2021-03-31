## 1. 곱셈 <br>
```C#
﻿using System;
namespace _0331_FirstAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 곱셈 문제(백준 2588번)
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a * (b % 10));
            Console.WriteLine(a * ((b / 10) % 10));
            Console.WriteLine(a * ((b / 100) % 10));
            Console.WriteLine(a * b);
        }
    }
}
```

첫번째 문제는 A와 곱해지는 B의 숫자 하나를 빼내서 곱하는 것을 구하는 문제입니다. <br>
385에서 <br> 5만 빼내기위해 b%10 <br>
        8만 빼내기위해 (b/10 % 10) <br>
        3만 빼내기위해 ((b/100) % 10) 로 구해서 각각 A와 곱해줬습니다.<br><br><br>


## 2. 나머지 <br>
```C#
﻿using System;
namespace _0331_FirstAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. 나머지 문제(백준 10430번)
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

```

두번째 문제에서 예제 입력을 보면 5 8 4 로 되있는데, 이는 한꺼번에 3개의 숫자를 입력받고 엔터를 하는 것을 뜻하는것 같습니다.
실제로 Console.ReadLine()을 a,b,c에 각각 하나씩 입력받아서 3줄을 작성했었는데 이렇게하면 <br>
5 <br>
8 <br>
4 <br>
로 입력받아야하기 때문에 런타임에러가 뜹니다...<br>
그래서 숫자를 한꺼번에 입력받은 다음에 첫번째문제처럼 숫자를 하나씩 빼내서 풀었습니다. <br>
첫번째문제처럼 숫자를 %, /로 빼낼지, SubString으로 할지 고민하다가 Split() 이라는 편리한 함수를 발견해서 빠르게 풀었습니다.<br><br><br>


![첫번째문제](https://github.com/jacksimuse/IoT_Study/blob/main/Algorithm/0331/%EC%84%9C%EB%8F%99%EC%9A%B0/0331_FirstAlgorithm/FirstAlgorithm.png)
