# 자릿수더하기
```C
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int answer = 0;
    int add = 0;  // 각 자리를 더해줄 add 그릇
    while (n != 0) // 계속 10으로 나눠줄거라서 더이상 나눠줄거 없을 때 탈출
    {
        add += n % 10; // 맨 뒷자리수를 10의 몫으로 add에 넣는다
        n = n / 10; // n에 n / 10을 집어넣어 자리수를 한칸씩 떙겨준다 ex) 100 -> 10, 10 -> 1 자리로
    }
    answer = add; 다 더해진걸 answer답으로 제출
    return answer;
}

int main() {

    int N, res;
    scanf("%d", &N); // 자연수 N값 받기
    res = solution(N); // 함수 호출하고 res에 값 받기
    printf("%d", res);  // res 
}
```
