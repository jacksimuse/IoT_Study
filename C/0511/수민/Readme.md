## 1. [누가 더 클까](https://www.acmicpc.net/problem/4101)
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



## 2. [아이디 중복 ??!](https://www.acmicpc.net/problem/10926)

```c

/*	회원가입 동일 id 확인 프로그램
	회원 가입 시 사이트에 동일한 아이디가 존자하면 ??!를 놀람으로 표현
*/
/*
	1. 아이디 입력받기
	2. id.txt 파일안에 있는 id와 비교하기
	3. 동일한 아이디가 있을 경우 ??!를 출력
(활용)4. 동일한 아이디가 없을 경우 입력값 저장하기 >> 이건 주말에 복습하면서 할게요..ㅎ

*/

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

struct IDcheck
{
	char id[30];
};

int main(void)
{	
	FILE* fp;
	struct IDcheck idcheck;
	char id[30];
	int res;

	fp = fopen("id.txt", "r+");
	if (fp == NULL)
	{
		printf("파일을 찾지 못했습니다.");
		return 1;
	}

	while (1)
	{
		res = fscanf(fp, "%s", idcheck.id); //fscanf에서 변수에 저장
		if (res == EOF)
		{
			break;
		}
	}

	// 키보드 입력
	// 구조체 멤버랑 입력받은 값이랑 비교
	printf("id를 입력하세요 : ");
	scanf("%s", id);

	if (strcmp(id, idcheck.id) == 0)
	{
		printf("??!");
	}
	else
	{
		printf("사용할수 있는 아이디입니다.");
	}

	return 0;
}

```
