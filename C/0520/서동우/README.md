```C
/*
백준 10768번 문제(특별한 날)
주석은 내일~
*/
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	int mon;
	int day;

	scanf("%d", &mon);
	scanf("%d", &day);

	if (mon == 2 && day == 18)       // 2월 18일에 스페셜
	{
		printf("Special\n");
	}
	else if (mon < 2)                // 2월보다 작으면 무조건 Before
	{
		printf("Before");
	}
	else if (mon == 2 && day < 18)   // 2월인데 18일보다 작으면 Before
	{
		printf("Before");
	}
	else                             // 나머지는 전부 After처리
	{
		printf("After");
	}
	
	return 0;
}
```


```C
/*
백준 4999번 아!
이거 주석도 내일~
*/

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>

int main()
{
	int a = 0;
	int b = 0;
	char myAh[1001];     // 최대 크기의 배열 선언
	char DocAh[1001];

	scanf("%s", myAh);   // 재환이와 의사의 aah(문자열) 입력
	scanf("%s", DocAh);

	// while문은 0일때 반복문이 끝난다 => NULL일때 반복문이 끝난다.
	// 문자열의 맨끝이 NULL이므로 NULL일때까지 while문을 돌림
	while (myAh[++a]);    
	while (DocAh[++b]);

	// 재환이의 aah와 의사의 aah의 길이 비교후에 go, no 출력
	if (a >= b) 
	{
		printf("go");
	}
	else 
	{
		printf("no");
	}

	return 0;
}
```
