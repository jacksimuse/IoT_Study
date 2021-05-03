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
