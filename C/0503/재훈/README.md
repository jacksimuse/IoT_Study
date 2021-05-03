```C
// OX세기
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>

int main()
{
	int i,j,k; // 몇번 진행시킬 숫자 i, 그만큼 반복시킬 j
	char OX[80]; // 80자까지 받을수 있는 문자열
	

	scanf("%d", &i);
	for (j = 0; j < i; j++)
	{
		int count = 0; // 전체 O 수를 더한 값을 담을 거
		int add = 1; // 연속으로 O 나올때 1씩 증가
		scanf("%s", OX);
		for (k = 0; k < strlen(OX); k++) //  문자열 길이 함수 strlen
		{
			if (OX[k] == 'O') 
			{
				count += add;
				add++;
			}
			if (OX[k] == 'X') add = 1;
		}
		printf("%d\n", count);
	}
}
```

```C
// 알람시계
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	int H, M;
	
	scanf("%d %d", &H, &M); // 시와 분을 받는다
	if (M - 45 == 0) // 45분이면 시간만 1시간 뺴준다
	{
		--H;
		if (H < 0) // 0시라서 1시간 뺏을때 -1일 대신 23시를 넣어준다
		{
			H = 23;
		}
	}
	else if (M - 45 < 0) // 45분은 전은 15분을 더하는 것과 같으므로
	{
		--H; // 1시간 전과
		M += 15; // 15분 뒤라고 생각할 수 있다
		if (H < 0)
		{
			H = 23; // 마찬가지로 -1시는 23시
		}
	}
	printf("%d %d\n", H, M);
}
```
