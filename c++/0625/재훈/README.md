# 점프와 순간이동
```c++
#include <iostream>
using namespace std;

int solution(int n)
{
    int ans = 0;

    while (n) // n을 계속 나누면서 앞으로 진행
    {
        if (n % 2 == 0) // 짝수는 순간이동이므로 카운트 필요없음
        {
            n = n / 2;
        }
        if (n % 2 == 1) // 홀수는 점프해야되서 n을 -1하고 카운트 +1
        {
            n--;
            ans++;
        }
    }
    

    return ans;
}
