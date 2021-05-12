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
# 아이디 중복??!
```c
#include <stdio.h>

int main()
{
	char id[50]; // 글자 50자
	char* id1 = id; // 문자열이라서 포인터로 주소를 가리쳐준다
	scanf("%s", id1); // 포인터로 값을 받는다
	printf("%s??!", id1); // 포인터로 출력한다
}
```
