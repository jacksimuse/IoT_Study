### 1. [누가 더 클까](https://www.acmicpc.net/problem/4101)   
## 2021년 5월 12일 제출

1. 필요한 요소   
    : 변수선언 int, scanf, 관계연산자 <>, while문, break문, if문   
    
  
```java   
#include <stdio.h>

int main()
{
    int a, b;                           //입력할 정수형 a,b 변수 선언
   
    printf("두 정수를 입력하세요 : ");   // printf함수를 통해 정수 출력
    scanf("%d %d", &a, &b);            // scanf함수를 통해 입력받을 정수 입력
    while (1)                          // 두 정수 비교 동작 여러번 동작하기 위해 while문 
    {
        char ch;                        //문자 변수 선언
        scanf("%c", &ch);               // scanf함수 통해 입력받을 문자 입력
        if (ch == 'F') break;           // 실행 종료 위한 if문 
        
        if (a > b)                      // a가 b보다 크면
        {
            printf("Yes \n");           // 화면에 Yes출력
        }
        else if (a == 0 && b == 0)      // a=0,b=0이면 Yes출력 
        {
            printf("Yes \n");
            break;                      // 그리고 while문 빠져나가기
        }
        
        else                            // a < b 이면
        {   
            printf("No \n");            // 화면에 NO출력
        }
        printf("그만하고 싶다면 F를 누르시오. \n");     // 사용자 맞춤 함수
        printf("다시 입력하세요 : \n");                // 사용자 맞춤 함수
        scanf("%d %d", &a, &b);                      // 위 함수에 입력받을 정수 입력

    }

    return 0;
}   
```    
