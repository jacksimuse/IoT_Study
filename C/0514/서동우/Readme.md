이번에도 연습했던거랑 제출용 둘 다 올립니당 <br>

## 두 정수 사이의 합
a, b를 입력받으면 a부터 b까지의 합을 구하는 문제.<br>
a부터 b까지 for문을 돌리면서 그 값을 하나씩 더해주는것으로 코드 작성<br>
```C
// 연습할때 코드
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main() 
{
	int a, b;
	int result = 0;

	scanf("%d %d", &a, &b);

	if (a == b) 
	{
		printf("두 수가 같음 : %d", a);
	}
	else if (a < b) 
	{
		for (a; a <= b; a++)  // a가 더 클때
		{
			result += a;
		}
		printf("%d", result);
	}
	else 
	{
		for (b; b <= a; b++)  // b가 더 클때
		{
			result += b;
		}
		printf("%d", result);  
	}
	
	return 0;
}

```

<br>

```C
// 제출용
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

long long solution(int a, int b) {
	long long answer = 0;

	if (a == b)     // 입력받은 a, b가 같으면 a 출력
	{
		answer = a;
	}
	else if (a < b)  // b가 더 크면 a부터 b까지의 합 출력
	{
		for (a; a <= b; a++)
		{
			answer += a;
		}
	}
	else    // a가 더 크면 b부터 a까지 합 출력
	{
		for (b; b <= a; b++)
		{
			answer += b;
		}
	}
	return answer;
}
```

## 약수의 합
정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 문제<br>
12의 약수 1, 2, 3, 4, 6, 12를 예로들면 12를 1, 2, 3, 4, 6, 12로 나누면 나머지가 0인것을 활용하여 조건문을 작성<br>

```C
// 연습할때 코드
#include <stdio.h>
int main() 
{
	int a = 5;         // 입력받을 a값
	int result = 0;    // 약수의 합을 저장할 변수 result
	for (int i = 1; i <= a; i++)  // 1부터 입력받은 정수 a까지 for문 돌림
	{
		if (a % i == 0)   // 약수일때 result에 값을 더해줌
		{
			result += i;
		}
	}
	printf("%d", result);  // result값 출력

	return 0;
}
```

<br>

```C
// 제출용코드
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {    
	int answer = 0;
	for (int i = 1; i <= n; i++)   // i를 1~n까지 for문 돌림
	{
		if (n % i == 0)             // 약수일때 answer에 i를 더해줌
		{
			answer += i;
		}
	}

	return answer;
}
```


## 소수구하기
하는중..
