쉬는 시간 10분동안 풀 수 있는 문제입니당

## 누가 더 클까(백준 4101번 문제)
```C
/*
두 정수를 입력받고 두 수를 비교해서 Yes나 No를 출력하며, 0 0 을 입력하면 종료하는 문제
*/
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() 
{
	int a, b;

	while (1)
	{
		scanf("%d %d", &a, &b);
		if (a > b)
		{
			printf("Yes\n");
		}
		else if (a == 0 && b == 0)
		{
			break;
		}
		else
		{
			printf("No\n");
		}
	}
	
	return 0;
}
```
<br><br>
## 아이디 중복 ??!(백준 10926번 문제)
```C
/*
문자열입력받고 입력받은 문자열 + ??! 를 출력하는 문제
*/
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main() 
{
	char input[50];
	scanf("%s", input);
	printf("%s??!", input);
	return 0;
}
```
