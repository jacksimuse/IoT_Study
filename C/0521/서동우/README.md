## 백준 2720번 문제(세탁소 사장 동혁)
```C
/*
백준 2720 세탁소 사장 동혁

거스름돈(change)이 주어지면 동전의 단위를 계산하고, 동전을 최소로 하는 개수를 구하는 문제
큰 값부터 몫을 출력하고 나머지 연산으로 나누면서 거슬러줘야할 동전의 개수를 출력
(주석에는 124 넣었을때를 예시로 들고있음)
*/

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() 
{
	int change;
	int input;
	scanf("%d", &input);            // 테스트 케이스 횟수 입력

	while (input--)                 // 테스트 케이스 만큼 반복
	{
		scanf("%d", &change);        // 거스름 돈 입력(124)

		printf("%d", change / 25);   // 25로 나눈 몫 출력('4' 출력)
		change %= 25;                // 나머지 연산으로 25센트로 빠진 값을 대입(24)


		printf(" %d", change / 10);  // 10으로 나눈 몫 출력(' 2' 출력)
		change %= 10;                // 10센트 빠진 값을 대입(4 대입)


		printf(" %d", change / 5);   // 5로 나눈 몫 출력(' 0' 출력)
		change %= 5;                 // 5센트 빠진 값을 대입(4 대입)


		printf(" %d\n", change);     // 다 빠진값이므로 그대로 출력(' 4' 출력)
	}
	return 0;
}
```

<br><br>

## 백준 2750번 문제(수 정렬하기)
삽입정렬로 풀었는데 자료구조에서했던 선택정렬도 한번 짜봤습니다.(퀵정렬은 도저히 안되서 기권합니다)

```C
/*
백준 2750번 문제 (수 정렬하기)
N개의 수가 주어졌을때, 이를 오름차순으로 정렬하는 문제
-> 삽입정렬 사용
*/

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() 
{
	int input;
	int iarr[1001] = { 0 };
	int temp = 0;
  
	scanf("%d", &input); // 테스트 케이스 입력
	
  // 배열 요소 입력
	for (int i = 0; i < input; i++) 
	{
		scanf("%d", &iarr[i]);
	}
	
	// 삽입정렬
	for (int i = 1; i < input; i++) 
	{
		for (int j = i; j > 0; j--) 
		{
			if (iarr[j] < iarr[j - 1])
			{
				temp = iarr[j];
				iarr[j] = iarr[j - 1];
				iarr[j - 1] = temp;
			}
		}
	}

	// 정렬한 배열 출력
	for (int i = 0; i < input; i++)
	{
		printf("%d\n", iarr[i]);
	}
	return 0;
}

```
```C
/*
백준 2750번 문제 (수 정렬하기)
N개의 수가 주어졌을때, 이를 오름차순으로 정렬하는 문제
-> 선택정렬 사용(얜 코드구현은 못하겠는데 복습차원에서 짜봤습니다)
*/

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	int input;
	int iarr[1001] = { 0 };
	int temp = 0;

	scanf("%d", &input);

	for (int i = 0; i < input; i++)
	{
		scanf("%d", &iarr[i]);
	}

	// 선택정렬
	for (int i = 0; i < input; i++) 
	{
		int min = i;
		for (int j = i + 1; j < input; j++) 
		{
			if (iarr[min] > iarr[j])
			{
				min = j;
			}
		}
		temp = iarr[min];
		iarr[min] = iarr[i];
		iarr[i] = temp;
	}

	// 정렬한 배열 출력
	for (int i = 0; i < input; i++)
	{
		printf("%d\n", iarr[i]);
	}
	return 0;
}
```
