# 세탁소 사장 동혁
```C
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	int T, C;
	int Q = 25, D = 10, N = 5, P = 1; // 소수점 귀찮아서 int로 하고 각자리 x 100함
	int a, b, c, d;
	
	scanf("%d", &T); // 테스트 케이스 받기
	for (int i = 0; i < T; i++)
	{
		scanf("%d", &C); // 거스름돈 입력 받기

		
		a = C / Q;    // 거스름돈에서 제일 큰 순으로 나누고 몫만 하면 개수가 출력됨
		b = (C % Q) / D;  // 각 잔돈 거스르고 나머지에서 또 다음 작은 단위를 몫으로 나눔
		c = ((C % Q) % D) / N;
		d = (((C % Q) % D) % N) / P;

		printf("%d %d %d %d\n", a, b, c, d);
	}
}
```
# 수 졍렬하기
```c
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	int N, a[1000] = { 0 }, temp;
	int i = 0, min = 0;

	scanf("%d", &N);	// 테스트 케이스 받기

	for (i = 0; i < N; i++)
	{
		scanf("%d", &a[i]);	// 케이스 만큼 숫자 받기
	}

	while (min != N)	// 최소값 찾기를 N번할때까지
	{
		for (i = 0; i < N; i++)
		{
			if (a[min] < a[i])	// 최소값이 지금 값보다 크다면
			{
				temp = a[min];	// 교체
				a[min] = a[i];
				a[i] = temp;
			}
		}
		min++;
	}
	
	for (i = 0; i < N; i++)
	{
		printf("%d\n", a[i]);
	}
}
```
