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

<br><br>

## 소수구하기
```C
/*
배열에 저장된 정수들을 무작위로 뽑아서 더했을때 그 수가 소수가 되는 경우의 수를 구하는 문제
(배열, 배열 요소의 개수, 배열의 크기는 문제에서 주어짐)
1. 3개의 수를 뽑아서 합을 구하기
2. 합을 구한 수가 소수인지 판별하기

3개의 수를 뽑을때는 for문을 3번써서 더해주고, 
그 값이 소수인지 판별하는 함수에 넣어서 반환값에따라 answer++을 해서 출력해서 풀었습니다.
*/

// 연습할때 코드
#include <stdio.h>

int CheckSum(int x)     // C에는 bool형이 없어서 함수 return을 플래그처럼 사용해서 true(1), false(0)을 활용했습니다.
{
	for (int i = 2; i < x; i++)
	{
		if (x % i == 0)
		{
			return 0;
		}
	}
	return 1;
}

int main() 
{
	int input[] = { 1,2,7,6,4 };  // 임시로 배열생성

	int a = 0;       // 3개의 합 저장할 변수
	int count = 0;   // 3개의 합이 총 몇번 수행했는지 셀 변수
	int i, j, k;     // 반복문 횟수
	int result = 0;  // 소수인지 판별하는 변수(0, 1)
	int answer = 0;  // 소수가 총 몇개인지 세는 변수

	for (i = 0; i < ( sizeof(input) / sizeof(input[0]) - 2); i++)   // (배열의 크기 - 2) 만큼 for문 돌림
	{
		for (j = i+1; j < ( sizeof(input) / sizeof(input[0]) -1); j ++)  // i+1부터 (배열의 크기 -1) 만큼 for문 돌림
		{
			for (k = j+1; k < sizeof(input) / sizeof(input[0]); k++)  // j+1부터 (배열의 크기)만큼 for문 돌림
			{
					a = input[i] + input[j] + input[k];       // 3개의 값을 합해줌
					printf("%d + %d + %d = %d\n", input[i], input[j], input[k], a);  // 3개 합한 값 출력(잘 합했는지 확인용)
				        result = CheckSum(a);  // 3개의 합을 함수에 대입(소수인지 판별 => 소수이면 1, 소수가 아니면 0 반환)
					if (result == 1) 
					{
						answer++;      // 소수일때 answer가 +1 증가
					}
					count++;               // 합이 총 몇번일어났는지 보려고 count를 만들었음
			}
			printf("\n");
		}
	}
	printf("count = %d\n", count);     // 합을 몇번 실행했는지 출력
	printf("answer = %d\n", answer);   // 소수의 개수 출력

	return 0;
}

```

<br>

```C
// 제출할때 코드
#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int CheckSum(int x)   // C에는 true, false가 없어서 플래그 개념으로 함수 생성
{
	for (int i = 2; i < x; i++)
	{
		if (x % i == 0)
		{
			return 0;
		}
	}
	return 1;
}

// nums_len은 배열 nums의 길이입니다.
int solution(int nums[], size_t nums_len) {
	int answer = 0;
	int i, j, k;
	int temp = 0;
	int result = 0;

	for (i = 0; i < nums_len - 2; i++)
	{
		for (j = i + 1; j < nums_len - 1; j++)
		{
			for (k = j + 1; k < nums_len; k++)
			{
				temp = nums[i] + nums[j] + nums[k];
				result = CheckSum(temp);
				if (result == 1)
				{
					answer++;
				}
			}
		}
	}

	return answer;
}
```
