## 알람시계(백준 2884번 문제)
```C
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int H;
	int M;
	scanf("%d %d", &H, &M);

	if (M >= 45)
	{
		M = M - 45;
	}
	else
	{
		M = M + 15;
		if (H == 0)
		{
			H = 23;
		}
		else
		{
			H--;
		}
	}

	printf("%d %d", H, M);

	return 0;
}
```
기존의 시간을 입력하면 -45분을 하는 조건문 문제입니다. 저는 if else문으로 구현했는데, <br>
1. (12행) 만약 입력받은 분(M)이 45보다 크면(ex. 50분일때) 그대로 -45분을 해줍니다.
2. (16~17행) 분(M)이 45보다 작으면 60-45+M => 15 + M 을 해줍니다.(뺄셈에서 받아내림?을 생각하면됩니다)
3. (19행) 0~24시의 원리이므로 만약 0시일때 1시간을빼면 23시가되므로 시(H)를 23으로 맞춰줍니다
4. (23행) 0시를빼면 나머지 시는 그대로 1시간만빼면되므로 그대로 H--를 해줍니다



<br><br><br>
## OX퀴즈(백준 8958번 문제)
```C
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
int main()
{
	int inputNum;
	int count = 0;
	int addcount = 0;

	scanf("%d", &inputNum);

	char input[100];
	for (int k = 0; k < inputNum; k++)
	{
		scanf("%s", input);
		for (int i = 0; i <= strlen(input); i++)
		{
			if (input[i] == 'O')
			{
				for (int j = 0; j <= i; j++)
				{
					if (input[j] == 'O')
					{
						addcount = addcount + 1;
					}
					else if (input[j] == 'X')
					{
						addcount = 0;
					}
				}
				count = count + addcount;
				addcount = 0;
			}

		}
		printf("%d\n", count);
		count = 0;
	}
}
```
문자열을 입력받았을때 O, X를 판별해서 O일때 점수를주고, O가 반복되면 그만큼 가산점을주는 문제입니다. <br>
테스트케이스(inputNum)을 입력받고 테스트케이스만큼 57행의 for문을 돌립니다. <br>
입력받은 문자열(input)의 길이만큼 60행의 for문을 돌립니다.<br>
(62행) 문자열이 O일때 점수를 매기는데, 64행의 for문은 그 전의 문자열을 검사해서 O이면 addcount를 통해 가산점을 줍니다. <br>
(71행과 76행) addcount는 X가왔을때는 적용되지않으므로 0으로 초기화해줍니다.<br>
(80행) 누적된 점수를 count에 저장하고 문자열 검사(60행 for문)이 끝났을때 count를 출력합니다.
