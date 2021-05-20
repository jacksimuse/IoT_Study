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
