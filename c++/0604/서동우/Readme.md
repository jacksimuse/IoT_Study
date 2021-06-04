```C
#include <stdio.h>

int main()
{
	int n = 4;
	int arr[4][4];

	int value = 1;  // 배열 요소의 값(1부터시작)

	int x = 0;      // 가로
	int y = -1;     // 세로

	int inc = 1;   // 지금 배열의 위치를 올려야하는지 내려야하는지 판단해주는 변수

	while (n > 0)
	{
		for (int i = 0; i < n; i++)  // 가로 값
		{
			y += inc;
			arr[x][y] = value;
			value++;
		}
		n--;
		if (n == 0) break;   // n = 0이면 배열의 값 설정이 끝난거임

		for (int i = 0; i < n; i++)  // 세로 값
		{
			x += inc;
			arr[x][y] = value;
			value++;
		}
		inc *= -1;
	}


	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			printf("%3d", arr[i][j]);
		}
		printf("\n");
	}


	return 0;
}
```
