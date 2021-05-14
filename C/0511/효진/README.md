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

### 2. [아이디중복](https://www.acmicpc.net/problem/10926)     

```java   
/*
	작성자 : 박효진
	작성일 : 2021년 5월 14일(금)

	<문제> 
	준하는 사이트에 회원가입을 하다가 joona라는 아이디가 이미 존재하는 것을 보고 놀랐다.
	준하는 놀람을 ??!로 표현한다. 
	준하가 가입하려고 하는 사이트에 이미 존재하는 아이디가 주어졌을 때
	놀람을 표현하는 프로그램을 작성하시오.

	>>입력 
	첫 줄에 준하가 가입하려고 하는 사이트에 이미 존재하는 아이디가 주어짐
	알파벳 소문자, 길이 50이하

	>>출력
	아이디 위에 ??!를 붙여서 나타내기
 */

#include <stdio.h>
#include <string.h>

int main()
{
	/*중복된 아이디 입력*/
	
	
	char id[50] = "joonas";
	char id1[50];

	printf("아이디를 입력하세요 : ");
	scanf("%s", id1);

	if (strcmp(id,id1)== 0)
	{
		printf("\n %s??!", id);
		
	}
	else
	{
		printf("사용가능한 아이디 입니다.");
	}
	


	return 0;
}   
```   

해냈다~!~!~!!~!!
