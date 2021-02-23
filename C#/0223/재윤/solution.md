# 1번 문제 [윤년]
연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.

윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.

예를 들어, 2012년은 4의 배수이면서 100의 배수가 아니라서 윤년이다. 1900년은 100의 배수이고 400의 배수는 아니기 때문에 윤년이 아니다. 하지만, 2000년은 400의 배수이기 때문에 윤년이다.
--
## 풀이
연도를 입력받고 문제에서 주어진 대로 조건들을 판별한다...
```csharp
using System;

namespace Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is_Num = int.TryParse(Console.ReadLine(), out int number);
            
            if(is_Num) {
                if(number < 1 || number > 4000)
                    Console.WriteLine("-1");
                else {
                    
                    if((number % 4 == 0 && number % 100 != 0) ||number % 400 == 0)
Console.WriteLine("1");
                    else
                        Console.WriteLine("0");
                }
            }
            else {
                Console.WriteLine("-1");
            }
        }
    }
}

```
