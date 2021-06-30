# 피보나치 수
```C+
#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    int a = 0, b = 1, res = a + b;  // 처음 0 과 1로 초기화

    for (int i = 2; i < n; i++) // 2부터 n-1, n-2번째 값을 더하는 구조이므로 이전 값들을 넘겨주면됨
    {
        a = b;
        b = res;
        res = (a + b) % 1234567;
    }

    return answer = res;
}
```
# 손익분기점
#include <iostream>
using namespace std;

int main()
{
	int a, b, c, produce_price, BEP;    // 고정비용 a 가변비용 b 판매가격 c 
	cin >> a >> b >> c;


	BEP = c - b;    // n 개 값을 곱해서 계산하나 미리 계산하고 곱하나 같으므로 미리 빼줌 (a x n - b x n) = (a - b) x n
	produce_price = a + BEP;    // 뺀값을 고정비용에 더해준다

	if (BEP <= 0) produce_price = -1;   // 더한값을 다시 BEP로 나눠준다 == 곱해주는 개수와 같은원리 / 뺀값이 0이하면 손익을 넘길수 없으므로 -1처리
	else produce_price = produce_price / BEP;

	cout << produce_price;
}
