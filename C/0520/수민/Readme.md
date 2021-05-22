
### 1. 특별한 날
```c
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h> 

int main(void)
{
	int mon;
	printf("월을 입력하세요 : ");
	scanf("%d",&mon);
	
	int	date;
	printf("일을 입력하세요 : ");
	scanf("%d", &date);

	if (mon < 2)
		printf("Before");
	
	else if (mon == 2)
	{
		if (date > 18)
			printf("Before");

		else if (date == 18)
			printf("Special");

		else
			printf("After");
	}

	else if (mon > 2)
		printf("After");


	return 0;
}

```
