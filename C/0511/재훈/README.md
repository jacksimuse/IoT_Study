# 누가 더 클까
```C
#include <stdio.h>

int main()
{
	int a, b;
	//scanf("%d", &T);

	while (1)
	{
		scanf("%d %d", &a, &b);
		if (a > b) printf("Yes\n"); 
		else if (a <= b)
		{
			if (a == b && a == 0) break;
			printf("No\n");
		} 
	}
}
```
