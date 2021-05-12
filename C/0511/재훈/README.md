# 누가 더 클까
```C
#include <stdio.h>

int main()
{
	int a, b;

	while (1)
	{
		scanf("%d %d", &a, &b); // 값 받기
		if (a > b) printf("Yes\n");  // 크기비교 크면 yes
		else if (a <= b) 
		{
			if (a == b && a == 0) break; // a와 b가 0 일때 종료
			printf("No\n"); // 같거나 작으면 no
		} 
	}
}
```
