```C
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main() {
	int m, d;
	scanf("%d", &m);
	scanf("%d", &d);

	if (m < 2) printf("Before");
	else if (m == 2) {
		if (d < 18) printf("Before");
		else if (d == 18) printf("Special");
		else printf("After");
	}
	else printf("After");
}
```
