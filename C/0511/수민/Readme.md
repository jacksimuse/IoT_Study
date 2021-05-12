### 1. [누가 더 클까](https://www.acmicpc.net/problem/4101)
```c
/*	1. 두 정수 입력받기
	2. 0 < a, b <10000 일때 반복
	3. a > b => yes, a < b => NO
	4. 0 0 => Yes하고, 종료
*/
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main(void)
{
	int a, b;

	printf("비교할 두 정수를 입력하세요 : \n");
	scanf("%d %d", &a, &b);			//비교할 정수 입력받기
	
	
	while (a, b <= 1000000)			// a랑 b가 0보다 백만보다 작거나 같을때 반복한다
	{
		if (a > b)	
		{
			printf("Yes\n");
		}
		else if (a == 0 && b == 0)	//a와 b가 0일때
		{
			printf("Yes\n");
			printf("탈출합니다");
			break;			// yes, 탈출합니다 를 출력하고 반복문 탈출(종료)
		}
		else
			printf("NO\n");

		printf("비교할 두 정수를 입력하세요 : \n");
		scanf("%d %d", &a, &b);
	}
	
	
	return 0;
}

```
