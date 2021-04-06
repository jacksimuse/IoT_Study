# 1. 더하기 사이클
```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        // 1. 더하기 사이클 - 백준 1110
        string input = Console.ReadLine();
        int Count = 0;
        string result = "";
        if (input.Length == 1)
        {
            input = input + "0";  // (선 조건) 일의 자리일때는 문자열 "0"을 붙임
        }
        int OriginalInput = int.Parse(input);

        while (true)
        {
            int TenPosition = int.Parse(input) / 10;  // 십의자리 추출
            int OnePosition = int.Parse(input) % 10;  // 일의자리 추출
            int output = TenPosition + OnePosition;     // 2 + 6

            result = OnePosition + (output % 10).ToString();   // '6' + '8'
            ++Count;

            input = result;
            
            if (OriginalInput == int.Parse(result) || output == 0) // 원래 숫자가 0이거나 원래숫자와 result 값이 같으면 반복문 탈출
                break;
        }
        Console.WriteLine(Count);  // 반복문 탈출했을때 싸이클로 돌렸던 Count를 출력
    }
}
```
(예제) 숫자 '26' p 입력했을때 출력 과정
26      =>    input <br>
2+**6** = **8** <br><br>

68 <br>
6+**8** = 1**4** <br><br>

84 <br>
8+**4** = 1**2** <br><br>

42 <br>
4+**2** = **6** <br><br>

26     => result <br><br>

키보드로 입력받은 문자열을 십의자리, 일의자리로 나눠주고 합치고(문자열의 합), 더해주는(정수의 합연산) 문제입니다. <br>
while안에서 한번씩 더할때마다 Count++ 를 해줌으로써 개수를 카운트했고, 만약 input값과 result값이 같으면 break를 통해 반복문을 탈출하고 Count를 출력했습니다.



# 2. A + B (4번째)
```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        // 2. A + B (4번째) - 백준 10951

        // 이게 왜 틀렸는지 도저히 모르겠음 뭐임이거
        //while (true)
        //{
        //    string[] input = Console.ReadLine().Split();
        //    if (input == null) break;
        //    Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
        //}


        string input = "";
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            string[] sNum = input.Split();
            Console.WriteLine(int.Parse(sNum[0]) + int.Parse(sNum[1]));
        }
    }
}

```
입력이 끝날때까지 A+B를 쓰는문제 <br>
EOF(파일끝)에 Null을 감지하면 반복문을 탈출하는 것으로 코드를 작성했습니다.
