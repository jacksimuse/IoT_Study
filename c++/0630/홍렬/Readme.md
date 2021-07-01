### 손익분기점

```C++
#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
	long A, B, C;			// A(고정비용), B(가변비용), C(판매가격)
	long long ans;			// 손익분기점

	cin >> A >> B >> C;

	if (B >= C)						// 가변비용이 판매가격보다 같거나 큰 경우는
	{								// 몇 개를 생산하더라도 손익분기점이 생기지 않으므로
		ans = -1;					// 손익분기점은 -1이 된다.
	}
	else							// 위의 경우가 아니면
	{
		ans = (A / (C - B)) + 1;	// A + 생산 수*B < 생산 수*C 의 부등식을 통해
	}								// 손익분기점의 바로 전 생산 수를 구할 수 있다.
									// 해당 생산 수에서 다음 단계가 손익분기점이 되므로 +1 한다.
	cout << ans;

	return 0;
}
```
<br>

### 피보나치 
```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    int n = 5;                      // 피보나치 수열의 인덱스
    vector<int> fibo;               // 피보나치 수열 벡터

    // 1. n번째 피보나치 수까지 피보나치 수열 생성한다.
    for (int i = 0; i <= n; i++)
    {
        if (i == 0)                 // 피보나치 0번째 수는 0으로 고정
        {
            fibo.push_back(0);
        }
        else if (i == 1 || i == 2)  // 피보나치 1, 2번째 수는 1로 고정
        {
            fibo.push_back(1);
        }
        else                        // 3번째 이상 피보나치 수는 앞의 두 수를 더해서 만든다.
        {
            fibo.push_back((fibo[i - 1] % 1234567) + (fibo[i - 2] % 1234567));
        }
    }

    // 피보나치 수마다 1234567 모듈러 연산을 하는 이유는
    // 44번째 피보나치 수만 가도 int의 범위를 넘어서므로
    // 피보나치 수마다 모듈러 연산을 하여 프로그램 실행에 있어서
    // int의 범위를 넘지 않은채로 계산 수행할 수 있도록 하기 위함이다.

    cout << fibo.back() % 1234567;

    return 0;
}
```
