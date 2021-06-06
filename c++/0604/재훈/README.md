# 달팽이 성장일지

```C
#include <stdio.h>

int main()
{
	int arr[4][4];
	int n = 4 , res = 1;
	int col = -1, row = 0, idx = 1;

	while (n != 0)
	{
		for (int i = 0; i < n; i++)
		{
			col += idx;
			arr[row][col] = res++;
		}
		n--;
		for (int i = 0; i < n; i++)
		{
			row += idx;
			arr[row][col] = res++;
		}
		idx *= -1;
	}
	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			printf("%3d", arr[i][j]);
		}
		printf("\n");
	}
}
