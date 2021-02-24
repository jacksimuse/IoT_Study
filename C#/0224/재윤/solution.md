# 1번 문제 [스택]
정수를 저장하는 스택을 구현한 다음, 입력으로 주어지는 명령을 처리하는 프로그램을 작성하시오.

명령은 총 다섯 가지이다.

push X: 정수 X를 스택에 넣는 연산이다.
pop: 스택에서 가장 위에 있는 정수를 빼고, 그 수를 출력한다. 만약 스택에 들어있는 정수가 없는 경우에는 -1을 출력한다.
size: 스택에 들어있는 정수의 개수를 출력한다.
empty: 스택이 비어있으면 1, 아니면 0을 출력한다.
top: 스택의 가장 위에 있는 정수를 출력한다. 만약 스택에 들어있는 정수가 없는 경우에는 -1을 출력한다.

## 풀이
C#의 컬렉션(스택)을 사용한다...
```csharp
using System;
using System.Collections.Generic;

namespace Sol1
{
    class Program
    {
        private static Stack<int> s = new Stack<int>();
        private static int size = 0;

        static void Menu(string str)
        {
            string[] tmp = str.Split(' ');
            if (tmp[0].Equals("push"))
            {
                s.Push(int.Parse(tmp[1]));
                size++;
                return;
            }
            if (tmp[0].Equals("pop"))
            {
                if (size > 0)
                {
                    Console.WriteLine(s.Pop());
                    size--;
                }
                else
                    Console.WriteLine("-1");

                return;
            }
            if (tmp[0].Equals("size"))
            {
                Console.WriteLine(size);
                return;
            }
            if (tmp[0].Equals("empty"))
            {
                if(size == 0)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");

                return;
            }
            if (tmp[0].Equals("top"))
            {
                if (size > 0)
                {
                    Console.WriteLine(s.Peek());
                }
                else
                    Console.WriteLine("-1");

                return;
            }

        }

        static void Main(string[] args)
        {
            int num =int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
                Menu(Console.ReadLine());
        }
    }
}
```

# 2번 문제 [제로]
나코더 기장 재민이는 동아리 회식을 준비하기 위해서 장부를 관리하는 중이다.

재현이는 재민이를 도와서 돈을 관리하는 중인데, 애석하게도 항상 정신없는 재현이는 돈을 실수로 잘못 부르는 사고를 치기 일쑤였다.

재현이는 잘못된 수를 부를 때마다 0을 외쳐서, 가장 최근에 재민이가 쓴 수를 지우게 시킨다.

재민이는 이렇게 모든 수를 받아 적은 후 그 수의 합을 알고 싶어 한다. 재민이를 도와주자!

## 풀이
장부를 스택으로 생각해보면 작성한 수가 0이 아닐 때 push() 연산, 0일 때 pop() 연산으로 생각할 수 있다.
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            int num = int.Parse(Console.ReadLine());
            int size = 0;
            for(int i = 0; i < num; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (element != 0)
                {
                    s.Push(element);
                    size++;
                }
                else if (size > 0)
                {
                    s.Pop();
                    size--;
                }
                else { }
            }

            Console.WriteLine(s.Sum());
        }
    }
}
```

# 3번 문제 [요세푸스 문제 0]
요세푸스 문제는 다음과 같다.

1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고, 양의 정수 K(≤ N)가 주어진다. 이제 순서대로 K번째 사람을 제거한다. 한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다. 이 과정은 N명의 사람이 모두 제거될 때까지 계속된다. 원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다. 예를 들어 (7, 3)-요세푸스 순열은 <3, 6, 2, 7, 5, 1, 4>이다.

N과 K가 주어지면 (N, K)-요세푸스 순열을 구하는 프로그램을 작성하시오.

## 풀이
가장 쉬운 방법으로 원형 연결리스트(LinkedList) 자료구조를 생각할 수 있다. 순서대로 양의 정수 (1, 2, ... N)를 순서대로 리스트에 삽입하고 리스트 내부의 연결된 특정 원소의 다음 주소를 
가리키는 포인터 연산을 이용하면, K번째 원소를 제거해도 인덱스 접근이 아닌 포인터 연산을 통한 접근이기 때문에 손쉽게 (N, K) 요세푸스 순열을 구할 수 있다.
그렇다고 위 방법만이 유일한 풀이법은 아니다. 일반적인 연결리스트 자료구조만으로도 해당 문제를 해결할 수 있는데, K번째 위치에 있는 원소에 도달할 때까지 앞에 있는 원소들을 삭제하고 리스트의
뒤에 다시 삽입하는 방식으로 요세푸스 순열을 해결할 수 있다.
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace sol3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List = new List<int>();

            string[] tmp = Console.ReadLine().Split(' ');
            int length = int.Parse(tmp[0]);
            int order = int.Parse(tmp[1]);
            string result = "<";

            for (int i = 1; i <= length; i++)
                List.Add(i);

            for(int i = 0; i < length; i++)
            {
                int list_length = List.Count;

                for(int j = 0; j < order - 1; j++)
                {
                    List.Add(List.ElementAt(0));
                    List.RemoveAt(0);
                }
                result += List.ElementAt(0);
                List.RemoveAt(0);
                if (i < length - 1)
                    result += ", ";
                else
                    result += ">";
            }

            Console.WriteLine(result);
        }
    }
}
```
또 다른 방법으로는 N개의 배열을 선언하고 인덱스 위치를 가리키는 변수를 이용하여 K번째 순서에 해당하는 원소들을 제거하는 방식을 생각해 볼 수 있다.
아니면 요세푸스 순열은 점화식으로 나타낼 수 있기 때문에, 재귀함수로도 해결이 가능하다.
[위키피디아](https://ko.wikipedia.org/wiki/%EC%9A%94%EC%84%B8%ED%91%B8%EC%8A%A4_%EB%AC%B8%EC%A0%9C)
