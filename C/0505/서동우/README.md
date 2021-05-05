## 문자열 반복(백준 2675문제)
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

1. 첫째줄에 테스트케이스(testNum)을 받고, 두번째 줄에는 숫자(repeatNum)와 문자열(inputText)을 입력받는데, <br>
  이때 숫자는 받은 문자열을 반복해서 출력할 횟수입니다.<br>
3. 10행에서 scanf를 통해 테스트케이스(testNum)을 입력받는데, 12행의 for문을 테스트케이스만큼 돌립니다.<br>
4. 17행에서 scanf를 통해 숫자(repeatNum)와 문자열(inputText)을 입력받고, 문자열의 길이만큼 19행의 for문을 돌립니다.<br>
5. 21행의 for문에서 입력받았던 숫자(repeatNum)만큼 for문을 돌리는데 문자열(inputText)을 하나씩 반복해야하므로 inputText[i]를 출력합니다. 
(만약 숫자와 문자열을 3 ABC 을 입력받았다고 가정할때, i = 0 일때 AAA, i = 1일때 BBB, i = 2일때 CCC가 출력됩니다)
