#### [1. 자릿수 더하기](https://programmers.co.kr/learn/courses/30/lessons/12931)
```c

#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int answer = 0;
    
    printf("자연수를 입력하세요: ");
    scanf("%d", &n);
    
    while(n>9)
    {
        answer += n % 10;
        n /=10;
    }
    
    return answer +n;
}

```
