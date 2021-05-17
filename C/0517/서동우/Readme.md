## 백준 11720번 문제 (숫자의 합)
```C
/*
첫째줄에 숫자를 입력하면,
둘째줄에는 첫째줄에서 입력받은 숫자의 개수만큼 숫자를 입력해서 그 숫자들의 합을 구하는 문제.

예시)
5
54321  입력하면 =>  5+4+3+2+1 = 15 출력

(★핵심★) 배열을 scanf로 받을때 %d가 아니라 %1d 로 받으면 문자열처럼 1자리가 1개의 방에 저장됩니다.
따라서 각 방의 요소를 더해주는 temp를 선언해서 출력했습니다.
*/
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main() 
{
	int numCount;
	int iarr[101];
	int temp = 0;
	scanf("%d", &numCount);
	
	for (int i = 0; i < numCount; i++) 
	{
		scanf("%1d", &iarr[i]);
		temp += iarr[i];
	}

	printf("%d", temp);
	
	return 0;
}
```


## 백준 2577 (숫자의 개수)
```C
/*
a,b,c 값을 입력해서 a*b*c의 값이 0~9까지 숫자가 몇번 쓰였는지 카운트하는 문제.

1. a*b*c의 값을 나머지 연산을 통해 숫자 하나씩 빼줌.(while문 활용)
2. 0으로 채운 10칸짜리 배열을 만들어서 하나씩 뺀 숫자와 각 방의 번호를 매칭해서 ++해줌.(빼준 숫자가 0이면 arr[0] += 1; 해주는 것임)
3. 10칸짜리의 배열의 요소들을 합해서 출력(for문 이용)

*/
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
int main()
{
	int a;
	int b; 
	int c;

	scanf("%d", &a);
	scanf("%d", &b);
	scanf("%d", &c);
	int result = a * b * c;
	
	int iarr[10] = { 0 };

	while (result)
	{
		int temp = 0;
		temp = result % 10;
		// printf("%d\n", temp);
		result = result / 10;

		switch (temp)
		{
			case 0:
				iarr[0] += 1;
				break;
			case 1:
				iarr[1] += 1;
				break;
			case 2:
				iarr[2] += 1;
				break;
			case 3:
				iarr[3] += 1;
				break;
			case 4:
				iarr[4] += 1;
				break;
			case 5:
				iarr[5] += 1;
				break;
			case 6:
				iarr[6] += 1;
				break;
			case 7:
				iarr[7] += 1;
				break;
			case 8:
				iarr[8] += 1;
				break;
			case 9:
				iarr[9] += 1;
				break;
		}
	}

	for (int i = 0; i < sizeof(iarr) / sizeof(iarr[0]); i++)
	{
		printf("%d\n", iarr[i]);
	}
	
	return 0;
}
```
