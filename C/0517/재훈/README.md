# 숫자의 개수
```C
#include <stdio.h>
#include <string.h>

int main()
{
	int a, b, c;
	scanf("%d", &a);
	scanf("%d", &b);
	scanf("%d", &c);
	int j[10] = { 0 };
	int d;
	if (a, b, c >= 100 && a, b, c < 1000) d = a * b * c;
	int e = 0, f = 0, g = 0, h = 0, n = 0, o = 0, k = 0, l = 0, m = 0, z=0 ;
	char pa[100];
	sprintf(pa, "%d", d);
	printf("%s\n", pa);

	for (int i  = 0; i < strlen(pa); i++)
	{
		switch (pa[i])
		{
		case '0': j[0] = ++e; break;
		case '1': j[1] = ++f; break;
		case '2': j[2] = ++g; break;
		case '3': j[3] = ++h; break;
		case '4': j[4] = ++n; break;
		case '5': j[5] = ++o; break;
		case '6': j[6] = ++k; break;
		case '7': j[7] = ++m; break;
		case '8': j[8] = ++l; break;
		case '9': j[9] = ++z; break;
		}
	}
	
	for (int i = 0; i < 9; i++)
	{
		printf("%d\n", j[i]);
		if (i == 8) printf("%d", j[i]);
	}
}
```
# 숫자의 합
```C
#include <stdio.h>

int main()
{
	int a,b,c = 0;
	scanf("%d", &a);

	for (int i = 0; i < a; i++)
	{
		scanf("%1d", &b);
		c += b;
	}
	printf("%d", c);

}
```
