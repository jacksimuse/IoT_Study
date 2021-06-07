# 약수의 개수와 덧셈
```C++
#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(int left, int right) {
    int answer = 0;
    
    while (left != right + 1) // 왼쪽이 오른쪽 + 1 전까지 될때까지 진행
    {
        int cnt = 0;  // 약수의 개수를 세준다
        for (int i = 1; i <= left; i++)
        {
            if (left % i == 0) cnt++; // 약수는 맞어 떨어지는 값이므로 나머지가 0일때만 카운트한다
        }
        if (cnt % 2 == 0) answer += left; // 카운트가 짝수이면 나눠지는 수를 답에 더한다
        else answer -= left;    // 홀수면 빼준다
        left++; // 왼쪽의 수를 진행시키면서 오른쪽으로 진행시킴
    }
    return answer;
}

int main()
{
    int a, b; // 숫자 두개 받을 변수
    cin >> a >> b;
    printf("%d", solution(a, b));
}
```
