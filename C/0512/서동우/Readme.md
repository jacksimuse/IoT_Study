로직을 코드로 구현했을때랑 제출할때랑 코드가 달라서 둘다 올립니당<br>

## 자릿수 더하기
```C
/*
정수를 입력받으면 각 자릿수의 합을 구하는 문제(ex. 입력이 123이면 1+2+3 = 6 출력)
정수입력받았을때 나머지연산을 통해 한자리씩 뽑아서 temp에 더해줌. => 이걸 반복문을 통해 모든 자릿수를 뽑아냄
*/
// 연습할때 코드
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int main() 
{
	int input;

	printf("정수 입력 : ");
	scanf("%d", &input);
	int temp = 0;
	int result = 0;

	while (input)                 // 입력받은 정수가 일의자리에서 10으로 나눴을때 끝남 (예를들면 1 / 10 = 0  =>  0일때 false로 while문 빠져나옴)
	{
		result += input % 10; // 입력받은 정수의 1의 자리를 빼서 result에 더해줌
		input /= 10;          // 입력받은 정수를 10으로 나눔
	}
	printf("%d", result);

	return 0;
}
```

<br>

```C
// 제출할때 코드
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
    int answer = 0;
    int temp;
    while(n)
    {
        answer += n%10;
        n /= 10;
    }
    return answer;
}
```


## 수박수박수박수박수박수?
```C
/*
정수를 입력하면 그 정수만큼의 문자개수가 출력되는 문제.
홀수 일때 "수", 짝수 일때 "박" 출력 => 반복문으로 입력받은 정수만큼 반복
*/
// 연습할때 코드
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() 
{
	int input;
	printf("정수 입력 : ");
	scanf("%d", &input);

	for (int i = 1; i <= input; i++)  // 입력받은 정수만큼 for문 돌림
	{
		if (i % 2 == 1)           // 홀수일때 "수" 출력
		{
			printf("수");
		}
		else                      // 짝수일때 "박" 출력
		{
			printf("박");
		}
	}
	return 0;
}
```

<br>

```C
/*
문제자체는 쉬운데 제출할때 수박수박을 char*에 저장한다음에 동적할당하여 반환해야합니다.
연습할때는 그냥 printf로 쉽게했는데, 제출할때는 문자열 함수를 사용해서 char*에 저장한다음에, return 해야하는 문제가 되서 조금 난이도가 올라갔네요
*/
// 제출할때 코드
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

char* solution(int n) {
    // 리턴할 값은 메모리를 동적 할당해주세요.
    char* answer = (char*)malloc((sizeof("수") * n) + 1);  // 한글이 2인가 3바이트이므로 (2바이트 * 입력받은 정수) + 1 만큼 메모리를 할당해준다.(+1은 NULL문자를위해)
    
    strcpy(answer, "\0");             // answer를 NULL문자로 초기화(안그러면 쓰레기값이 들어간채로 수박이 들어갑니다)
    
    for(int i = 1; i<= n; i++)
    {
       if (i % 2 == 1) 
       {
          strcat(answer, "수");       // strcat은 문자열을 합쳐주는 함수. 홀수일때 answer + "수"
       }
       else
       {
          strcat(answer, "박");       // 마찬가지로 짝수일때는 answer + "박".
       }
    }
    return answer;
}
```
