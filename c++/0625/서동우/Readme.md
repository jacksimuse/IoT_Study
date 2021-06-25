```C++
/*
   프로그래머스 : 점프와 순간이동
   한번에 K칸을 앞으로 점프하면 배터리가 닳고,
   (현재까지온 거리) * 2 에 해당하는 위치로 순간이동(이때 배터리안닳음)

   의 기능을 하는 2가지의 슈트가 있다.
   이 슈트를 착용하고 N만큼 떨어져있는 장소로 이동하려고할때, 배터리 사용량을 최솟값으로 return하는 문제
*/

/*
   구현
   1. n이 주어지면 n이 0이 될때까지 2로 나눠줌.
   2. n을 나머지 연산했을때 n이 홀수면은 ans에 ++이됨
   3. n이 0이되면 ans를 반환
*/

#include <iostream>
using namespace std;

int solution(int n)
{
    int ans = 0;

    while (n > 0)
    {
        ans += n % 2;
        n /= 2;
    }

    cout << ans << endl;
    return ans;
}

int main()
{
    solution(5000);
    solution(6);

    return 0;
}
```
