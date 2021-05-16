## 1.두 정수 사이의 합
중첩 if문 사용해서 조건 확인하고, for문 사용해서 합계 반복진행

### 출력 확인용 코드
```c

/* 두 정수 a, b가 주어졌을 때
a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수,
solution을 완성하세요. */

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main(void)
{
    int a, b;
    int answer = 0;
    printf("첫 번째 정수 입력 : ");
    scanf("%d", &a);
    printf("두 번째 정수 입력 : ");
    scanf("%d", &b);
    
    if (a > b)
    {
        printf("%d ~ %d까지의 ", b, a);
        for (b; b <= a; b++)
            answer += b;
        printf("총합은 : %d", answer);
    }
    else if (a < b)
    {
        printf("%d ~ %d까지의 ", a, b);
        for (a; a <= b; a++)
            answer += a;
        printf("총합은 : %d", answer);
    }
    else //같은 경우
    {
        printf("%d(으)로 두 수가 동일합니다. ",a);
        return a;
    }

    return 0;
}

```


### 제출용 코드
```c

#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

long long solution(int a, int b) {
    long long answer = 0;
    
  if(-100000000<a<10000000 && -100000000<b<10000000 ) 
  {   if(a>b)
    {
        for(b;b<=a;b++)
        {
            answer += b;
        }
    }
     else if(a<b)
     {
         for(a;a<=b;a++)  
         {
            answer += a;
         }
     }
    else //같은 경우
    {   answer = a;
    }
    
    printf("%lld",answer);
    return answer;
  }
}

```

---
## 2. 약수의 합
if문을 사용해서 제한사항 조건을 넣어주고, \n
for문을 사용해 i가 n이 될때까지 수 증가 반복 \n
if문의 조건을 사용해 약수를 찾았습니다.

### 출력 확인용 코드
```c
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main(void)
{
	int answer = 0;
    int n;

    printf("정수를 입력하세요 : ");
    scanf("%d", &n);

    if (0 < n < 3000)
    {
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                answer += i;
        }
    }
    printf("%d의 약수의 총 합은 : %d", n, answer);

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
    
    if(0<n<3000)
    {
        for(int i=1;i<=n;i++)   //i가 n이 될때까지 수 증가 반복
        {
            if(n%i==0)  //n에서 i 나눴을 때 나머지가 없는 경우
                answer += i;
        }
    }
    
    return answer;
}

```
