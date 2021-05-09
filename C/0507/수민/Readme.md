### [ 1번 문제. 2차원 배열의 합 ](https://www.acmicpc.net/problem/2167)

[참고 한 사이트](https://j0n9m1n1.dev/115)
```C
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() 
{
	int i, j, k, x, y, t, n, m, x2, y2, sum = 0;
	int num[300][300] = { {0, },{0, } };

	scanf("%d %d", &x, &y);

	for (i = 0; i < x; i++) {
		for (j = 0; j < y; j++) 
		{
			scanf("%d", &num[i][j]);

		}

	}

	scanf("%d", &t);
	for (k = 0; k < t; k++)
	{
		scanf("%d %d %d %d", &x2, &y2, &n, &m);

		for (i = x2 - 1; i < n; i++)
		{
			for (j = y2 - 1; j < m; j++)
			{
				sum += num[i][j];
			}
		}

		printf("%d\n", sum);

		sum = 0;
	}

}

```





### [ 2번 문제. 멜로디 저작권료 구하기 ](https://www.acmicpc.net/problem/2914)

```c
int main() {
    int A, I;
    scanf("%d %d", &A, &I);
    printf("%d", A * (I - 1) + 1);        // 올림을 하지 않은 평균값을 구한 후 +1

    return 0;
}

```
