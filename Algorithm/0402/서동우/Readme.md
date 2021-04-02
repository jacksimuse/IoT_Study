## 1. x보다 작은 수
```C#
using System;
class Program
{
    static void Main(string[] args)
    {
         // 1. x보다 작은 수(백준 10871번)
        string[] input = Console.ReadLine().Split();
        string[] inputSequence = Console.ReadLine().Split();
        for (int i = 0; i < inputSequence.Length; ++i)
        {
            if (Convert.ToInt32(inputSequence[i]) < Convert.ToInt32(input[1]))
                Console.Write($"{inputSequence[i]} ");
        }
    }
}
```

개수(N -> input[0])와 정수(X -> input[1])를 문자열 배열로 입력받은 다음, Split()을 통해 나눠줍니다. <br>
수열(A -> inputSequence)도 문자열 배열로 입력받고 Split()통해 나눠줍니다. <br>
수열의 개수(inputSequence.Length)만큼 for문을 돌리면서 수열의 값이 정수(input[1])보다 작은 값이면 출력해줍니다. <br>
(이때 수열은 문자열 배열로 받았기때문에 Convert.ToInt32로 정수로 변환해주어야합니다.) <br><br>




## 2. A + B
```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        //2.A + B(백준 11021번(A + B의 7번째 문제))
        int CaseNum = int.Parse(Console.ReadLine());
        for (int i = 1; i <= CaseNum; i++)
        {
            string[] inputNum = Console.ReadLine().Split();
            Console.WriteLine($"Case #{i}: {int.Parse(inputNum[0]) + int.Parse(inputNum[1])}");
        }
     }
}
```
테스트 케이스(CaseNum)을 입력받고 CaseNum만큼 for문을 돌립니다. <br>
그 다음 입력받는 두 정수 A와 B는 문자열 배열인 inputNum[0], inputNum[1] 에 저장합니다. <br>
Case#{i}를 통해 i를 1씩 증가시키면서 두 정수를(문자열에서 정수로 변환) 합한 값을 출력합니다. <br>
(TMI : 출력구문중에 'Case #{i}: ' 부분을 'Case #{i} : '로 제출했더니 계속 틀렸다고떠서 멘붕왔습니다... 스페이스바를 조심히 사용합시다..)


