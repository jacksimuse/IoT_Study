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
