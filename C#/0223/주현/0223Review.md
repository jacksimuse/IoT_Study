# 1번 : 윤년 구하기

```cs
using System;


namespace _0223Review
{
    class Program1
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            int varnum = 0;
            int.TryParse(val, out varnum);
            if (varnum % 4 == 0 && (varnum % 100 != 0 || varnum % 400 == 0))
            {
                Console.WriteLine(1);
            }
            else Console.WriteLine(0);
        }
    }
}
```


# 2번 : 별 찍기

```cs
using System;


namespace _0223Review_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            int num = 0;
            int.TryParse(val, out num);

            for (int i = 0; i < num; i++) //행
            {
                for (int j = 0; j < num - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++) //열
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
```

#3번 : 셀프넘버 구하기

```cs
using System;


namespace _0223Review_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10035];
            int[] arr2 = new int[10035];
            int hap = 0;
            for (int i = 0; i < 10000; i++)
            {
                hap = i + (i / 1000) + (i / 100) - (i / 1000 * 10) + (i / 10) - (i / 100 * 10) + (i % 10);
                //Console.WriteLine("i " + i);
                //Console.WriteLine("hap " + hap);

                arr[i] = hap;
                //Console.WriteLine(arr[i]);
            }

            int q = 0;
            int answer = 1;

            while (answer < 10000)
            {
                /*
                 * 1부터 10000까지의 숫자를 비교, 같은수가 없으면 q가 0 있으면 0이 아닌점을 이용
                 */
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (answer == arr[i])
                    {//answer가 배열 안에 있다면 q를 증가시킨다
                        q++;
                    }
                }//동적배열의 크기만큼 for문이 반복

                if (q == 0)
                {//배열안에 값이 없는경우 answer를 출력한다
                    Console.WriteLine(answer);
                }
                answer++;
                q = 0;//0으로 다시 초기화를 해야 판독을 제대로 할 수 있다.
            }
            //참고 : https://blog.naver.com/qkrdydrjs7/221938565774



        }
    }
}
```
