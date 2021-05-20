# 특별한 날
```C
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() {
	int m, d;		// 달과 일을 변수로 지정하고 값을 받는다
	scanf("%d", &m); 
	scanf("%d", &d);

	if (m < 2) printf("Before");	// 1월은 Before
	else if (m == 2) {		// 2월에서 18보다 작으면 Before 같으면 Special 크면 After
		if (d < 18) printf("Before");
		else if (d == 18) printf("Special");
		else printf("After");
	}
	else printf("After");		// 나머지 달은 After
}
```
# 아
```c
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>

int main() {
	char ah_j[1000] = { 0 }, ah_d[1000] = { 0 };  // 재환이가 소리, 의사 요구소리를 받을 문자 배열을 선언
	char* j = ah_j, * d = ah_d; // 문자열에 값을 받을거라 포인터
	int i = 0;
	for (i = 0; i < 1000; i++)
	{
		scanf(" %s", j); // 포인터에 문자열을 입력받음
		if (ah_j[strlen(ah_j) - 1] == 'h') break; //재환이마지막소리 = 마지막 배열 -1 이 h일때 반복 그만 / 마지막 배열은 널문자라서
	}
	for (i = 0; i < 1000; i++)
	{
		scanf(" %s", d); 
		if (ah_d[strlen(ah_d) -1] == 'h') break;
	}
	
	if (strlen(ah_j) >= strlen(ah_d)) printf("go"); // 재환이와 의사 소리 비교해서 재환이가 같거나 길면 go 아니면 no
	else printf("no");
}
```
