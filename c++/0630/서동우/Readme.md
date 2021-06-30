## 손익분기점
```C++
/*
  백준 1712 문제 : 손익분기점
  고정비용, 인건비, 제품가격 이 주어졌을때 순이익이 고정비용을 넘어가는 손익분기점을 구하는 문제
*/

/*
  구현
  1. 최초로 이익이 발생하는 판매량을 찾는 것이 목적.

  1-1. "고정비용 + 인건비 * 판매량 < 제품가격 * 판매량"

  1-2. 위 식을 정리하면 "판매량 > 고정비용 / (제품가격 - 판매량)" 이 된다.

  1-3. (제품가격 - 판매량)을 순이익이라고 가정.

  2. 위 식에따라  "판매량 = 고정 비용 / 순이익"을 했을때는 총 수익이 판매량과 같아지는 지점이다.
   따라서 이익을 남기는 지점은 +1을 해서 return 해야함
*/
#include <iostream>
using namespace std;

int main()
{
	int 고정비용;
	int 인건비; 
	int 제품가격;

	cin >> 고정비용 >> 인건비 >> 제품가격;
	
	int count = 1;


	if (인건비 >= 제품가격)
	{
		count = -1;
		cout << count << endl;
	}
	else 
	{
		count = 고정비용 / (제품가격 - 인건비) + 1;
		cout << count << endl;
	}
}
```

-----------------

## 피보나치 수
```C++
/*
  프로그래머스 : 피보나치 수
  F(0) = 0, F(1) = 1 일때 1이상의 n에 대해 F(n) = F(n-2) + F(n-1)인 피보나치 수에 대해
  
  2 이상의 n이 입력됬을때 n번째 피보나치 수를 1234567으로 나눈 나머지를 리턴하는 문제
*/

/*
  구현 
  1. 피보나치 수는 F(n) = F(n-2) + F(n-1) 규칙을 따른다. 
  2. 
  (첫번째 c) = a + b
  (두번째 c) = b + (첫번째 c) 가 되므로
  c에는 a + b, a에는 b, b에는 c를 대입시켜줌
  3. 피보나치 수를 1234567으로 나눈 나머지를 리턴하라고 했으므로 
    c를 구할때마다 나머지값을 구해서 값을 반환
*/

#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(int n)
{
    int a = 0; // n - 2
    int b = 1; // n - 1
    int c = 0; // n

    if (n == 1) return 1;

    for (int i = 2; i <= n; i++)
    {
        // f(n) = f(n - 2) + f(n - 1)
        c = (a + b) % 1234567;
        a = b;
        b = c;
    }
    cout << c << endl;
    return c;
}

int main()
{
    solution(3);   // 2
    solution(5);   // 5
    return 0;
}
```
