## 1. [백준 11720 숫자의 합](https://www.acmicpc.net/problem/11720)
```c
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	int n = 0, sum = 0;
	scanf("%d", &n);
	char num[100];	// 배열 저장하는 
	scanf("%s", num);

	for (int i = 0; i < n; i++)
		sum += num[i] - '0';
	
	printf("%d", sum);

	return 0;
}

```

## 2.
