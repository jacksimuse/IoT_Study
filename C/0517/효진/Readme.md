### 1. [숫자의 합](https://www.acmicpc.net/problem/11720)   
## 2021년 5월 19일 제출   

```java   
/*	작성자 : 박효진
	작성일 : 2021년 5월 19일(수)

	<문제>
	N개의 숫자가 공백 없이 쓰여있다.
	이 숫자를 모두 합해서 출력하는 프로그램을 작성하시오.

	>>입력
	첫째 줄에 숫자의 개수 N (1 ≤ N ≤ 100)이 주어진다.
	둘째 줄에 숫자 N개가 공백없이 주어진다.

	>>출력
	입력으로 주어진 숫자 N개의 합을 출력한다.*/
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int num;							// 첫째 줄 숫자
	int length[101];					// 둘째 줄 숫자
	int sum = 0;						// 합의 변수 
	int i;								// 반복문 i 변수

	printf("원하는 개수를 입력하세요: ");
	scanf("%d", &num);

	for ( i = 0; i < num; i++)
	{
		scanf("%1d", &length[i]);
		sum += length[i];
	}
	printf("숫자들의 합은 : %d", sum);
	
	return 0;
}   
```
