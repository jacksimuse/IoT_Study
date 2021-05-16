#### [1. 자릿수 더하기](https://programmers.co.kr/learn/courses/30/lessons/12931)
### 출력 확인용 코드
```c
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main(void)
{
	int n;
	int answer = 0;
    int sum = 0;

	printf("자연수를 입력하세요 : ");
    scanf("%d", &n);

    while (n > 9)
    {
       sum = answer += n % 10;
        n /= 10;
    }

    printf("%d", sum+n);
    return 0;
}

```

### 제출용 코드

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

#### [2. 수박수박수박수박수박수?](https://programmers.co.kr/learn/courses/30/lessons/12922)
이건 주말ㅇ....
