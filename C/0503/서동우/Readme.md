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
