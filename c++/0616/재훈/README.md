# 다음 큰 숫자
```C++
#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(int n) {
    int answer;
    int cnt_m = 1, cnt_k = 1, m = n, k = n + 1, i = 2;  // n을 복사한 m, n보다 1씩 증가시키면서 계산할 k, 각 수의 이진법에서 1의 개수를 카운트할 cnt_m, cnt_k

    while (1)
    {
        while (m / 2 >= 1)
        {
            if (m % 2 == 1) cnt_m++;  // m을 나눠 1의 개수 파악
            m = m / 2;
        }
        while (k / 2 >= 1)
        {
            if (k % 2 == 1) cnt_k++;  // k를 나눠 1의 개수 파악
            k = k / 2;
        }
        m = n;  // n 원형보존
        k = n + i;  // k는 1씩 증가시킨다
        i++;
        if (cnt_m == cnt_k) // 1의 개수가 같으면 답에 k -1을 넣고 반복문 탈출 k -1인 이유는 나누기를 끝내고 k 가 1증가된 상태이므로 나눈수가 정답이라서
        {
            answer = k - 1;
            break;
        }
        cnt_m =1, cnt_k = 1;  // 반복문을 돌릴때 다시 1의 개수 파악 초기화
    }
    
    return answer;
}

int main()
{
    int n;
    cin >> n;
    printf("%d",solution(n));
}
