## 자릿수 더하기
```C
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

	while (input)
	{
		result += input % 10;
		input /= 10;
	}
	printf("%d", result);

	return 0;
}
```

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
// 연습할때 코드
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() 
{
	int input;
	printf("정수 입력 : ");
	scanf("%d", &input);

	for (int i = 1; i <= input; i++)
	{
		if (i % 2 == 1) 
		{
			printf("수");
		}
		else
		{
			printf("박");
		}
	}
	return 0;
}
```

```C
// 제출할때 코드
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

char* solution(int n) {
    // 리턴할 값은 메모리를 동적 할당해주세요.
    char* answer = (char*)malloc((sizeof("수") * n) + 1);
    strcpy(answer, "\0");
    for(int i = 1; i<= n; i++)
    {
      if (i % 2 == 1) 
      {
          strcat(answer, "수");
      }
	    else
	    {
          strcat(answer, "박");
	    }
    }
    return answer;
}
```
