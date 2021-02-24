# 1번 문제 [윤년]
연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.

윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.

예를 들어, 2012년은 4의 배수이면서 100의 배수가 아니라서 윤년이다. 1900년은 100의 배수이고 400의 배수는 아니기 때문에 윤년이 아니다. 하지만, 2000년은 400의 배수이기 때문에 윤년이다.


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
# 2번 문제 [별 찍기 - 2]
첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.


## 풀이
오른쪽 정렬처럼 보이도록 ' '(공백)을 채운다...
```csharp
using System;

namespace Sol2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is_Num = int.TryParse(Console.ReadLine(), out int number);
            
            if(is_Num) {
                if(number < 0)
                    Console.WriteLine("-1");
                else {
                    for(int i = 1; i <= number; i++) {
                        for(int j = 1; j <= number - i; j++)
                            Console.Write(" ");
                        for(int j = number - i + 1; j <= number; j++)
                            Console.Write("*");
                        
                        Console.WriteLine("");
                    }
                }
            }
            else {
                Console.WriteLine("-1");
            }
        }
    }
}
```
# 3번 문제 [셀프 넘버]
셀프 넘버는 1949년 인도 수학자 D.R. Kaprekar가 이름 붙였다. 양의 정수 n에 대해서 d(n)을 n과 n의 각 자리수를 더하는 함수라고 정의하자. 예를 들어, d(75) = 75+7+5 = 87이다.

양의 정수 n이 주어졌을 때, 이 수를 시작해서 n, d(n), d(d(n)), d(d(d(n))), ...과 같은 무한 수열을 만들 수 있다. 

예를 들어, 33으로 시작한다면 다음 수는 33 + 3 + 3 = 39이고, 그 다음 수는 39 + 3 + 9 = 51, 다음 수는 51 + 5 + 1 = 57이다. 이런식으로 다음과 같은 수열을 만들 수 있다.

33, 39, 51, 57, 69, 84, 96, 111, 114, 120, 123, 129, 141, ...

n을 d(n)의 생성자라고 한다. 위의 수열에서 33은 39의 생성자이고, 39는 51의 생성자, 51은 57의 생성자이다. 생성자가 한 개보다 많은 경우도 있다. 예를 들어, 101은 생성자가 2개(91과 100) 있다. 

생성자가 없는 숫자를 셀프 넘버라고 한다. 100보다 작은 셀프 넘버는 총 13개가 있다. 1, 3, 5, 7, 9, 20, 31, 42, 53, 64, 75, 86, 97

10000보다 작거나 같은 셀프 넘버를 한 줄에 하나씩 출력하는 프로그램을 작성하시오.


## 풀이
양의 정수 n과 각 자리수를 더하는 함수 d(n)을 정의하고 d(n)에서 나올 수 있는 경우의 수(<= 10000)들을 1 ~ 10000 까지의 자연수 집합(테이블)에서 배제하면 
생성자가 없는 숫자, 즉 셀프 넘버가 된다. (에라스토테네스의 체를 이용하여 소수를 찾아내는 방법과 상당히 유사하다.)
```csharp
using System;

namespace Sol3
{
    class Program
    {
        static int d(int number) {
            int tmp = number;
            for(int i = number; i != 0; i = i/10) {
                tmp += (i % 10);    
            }
            return tmp;
        }
        static void Main(string[] args) {
            
            bool []array = new bool[10000 + 1];
            for(int i  = 0; i < 10001; i++)
                array[i] = true;
            array[0] = false;

            for(int i = 0; i < 10001; i++)
                if(d(i) <= 10000)
                    array[d(i)] = false;

            for(int i = 1; i < 10001; i++)
                if(array[i])
                    Console.WriteLine(i);
        }
    }
}
```
또다른 풀이 방법으로 d(n) = 자리수 숫자  * (10^(각 자리수 - 1) + 1) 인 선형 조합으로 생각할 수 있다.
앞의 풀이와 마찬가지로 1 ~ 10000 까지의 자연수 집합(테이블)에서 배제하면 셀프 넘버를 구할 수 있다. (시간복잡도는 위 풀이법과 같다.)
```csharp
using System;

namespace Sol3
{
    class Program
    {
           static void Main(string[] args) {
            bool []array = new bool[10000 + 1];
            for(int i  = 0; i < 10001; i++)
                array[i] = true;
            array[0] = false;

            for(int v4 = 0; v4 <= 9; v4++) {
                for(int v3 = 0; v3 <= 9; v3++) {
                    for(int v2 = 0; v2 <= 9; v2++) {
                        for(int v1 = 0; v1 <= 9; v1++) {
                            if(v4 * 1001 + v3 * 101 + v2 * 11 + v1 * 2 <= 10000)
                                array[(v4 * 1001 + v3 * 101 + v2 * 11 + v1 * 2)] = false;
                        }
                    }
                }
            }

            for(int i = 1; i < 10001; i++) {
                if(array[i])
                    Console.WriteLine(i);
            }
        }
    }
}
```
다른 방법으로 배열 대신에 set(집합) 형태의 자료구조를 이용하여 1 ~ 10000 까지의 자연수들을 원소로 넣고 d(n)의 원소를 배제하는 등의
방법들을 생각해 볼 수 있으나 여백이 부족하여 생략한다...
