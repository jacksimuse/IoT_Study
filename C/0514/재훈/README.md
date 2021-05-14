# 두 정수 사이 합
```C
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

long long solution(int a, int b) { // 정수 a와 b를 입력받음
    long long answer = 0; // 정수의 합을 담을 그릇
    if ( a < b) // a가 b보다 작으면
        for (; a <= b; a++) answer += a; // a에서 b까지 answer에 담음 3~5-> 3 + 4 + 5
    else if ( a > b) // a가 b보다 크면
        for (; b <= a; b++) answer +=b; // b에서 a까지 answer에 담음
    else if ( a == b) answer = a; // 같으면 그 숫자를 담음
    return answer;
}

int main() {
  solution(3, 5);
  solution(3, 3);
  solution(5, 3);
}
```
# 약수의 합
```C
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int answer = 0;
    for (int i = 1; i <= n; i++) // 1부터 n까지 i를 증가시키면서 나눠준다 
    {
        if (n % i == 0) answer += i; // 나머지가 없으면 answer에 더해준다 
    }
    return answer;
}

int main() {
    int n;
    scanf("%d", &n); // 숫자 n을 받는다
    solution(n);
}
```
