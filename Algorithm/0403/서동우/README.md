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


설명은 내일 쓰는걸로
