```C++
/*
    프로그래머스 월간 코드 챌린지 시즌2 : 약수의 개수와 덧셈
    left, right 두 정수 값이 주어질때 left~right 값들의 약수의 개수를 구해서
    약수의 개수가 짝수면 +, 약수의 개수가 홀수면 -한 수를 return 하는 문제
*/

/*
    풀이
    2중 for문으로 첫번째 for문은 left ~ right 까지 돌림
                  두번째 for문은 1부터 첫번째 for문의 변수만큼 돌림
    두번째 for문에서 약수를 찾으면서 count를 ++해줌
    두번째 for문이 끝났을때 count값에따라 result에 짝수, 홀수 일때 더하거나 빼줌
*/

#include <stdio.h>
#include <vector>
#include <iostream>
using namespace std;



int solution(int left, int right)
{
    int result = 0;
    for (int i = left; i <= right; i++)   // left~right까지 for문 돌림
    {
        int count = 0;
        for (int j = 1; j <= i; j++)      // 1부터 i(첫번째 for문변수)까지 for문 돌림
        {
            if (i % j == 0)               // 만약 약수면 count++
            {
                count++;
            }
        }

        if (count % 2 == 0)               // 약수의 개수가 짝수면 result에 해당 정수를 더해줌
        {
            result += i;
        }
        else if (count % 2 != 0)          // 약수의 개수가 홀수면 result에 해당 정수를 빼줌
        {
            result -= i;
        }
    }

    return result;                        // result값 반환
}

int main()
{
    int a, b;
    cin >> a >> b;
    int res = solution(a, b);
    cout << res << endl;
}
```
