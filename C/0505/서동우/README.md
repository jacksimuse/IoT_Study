```C
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>

int main() 
{
	int testNum = 0;                                         // 테스트 케이스 저장할 변수
	scanf("%d", &testNum);

	for (int k = 0; k < testNum; k++)                        // testNum을 받은만큼 반복 
	{
		int repeatNum = 0;                               // 반복할 횟수를 저장할 변수
		char inputText[10] = "";                         // 문자열 받을 배열

		scanf("%d %s", &repeatNum, &inputText); 

		for (int i = 0; i < strlen(inputText); i++)      // 입력받은 inputText 길이 만큼 반복
		{
			for (int j = 0; j < repeatNum; j++)      // 입력받은 repeatNum만큼 반복
			{
				printf("%c", inputText[i]);      // inputText[i]를 통해 repeatNum만큼 똑같은 문자가 출력됨
			}
		}
		printf("\n");
	}
	return 0;
}
```
