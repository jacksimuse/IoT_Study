### 1. [누가 더 클까](https://www.acmicpc.net/problem/4101)   

```java   
#include <stdio.h>

int main()
{
    int a, b;
   
    printf("두 정수를 입력하세요 : ");
    scanf("%d %d", &a, &b);
    while (1)
    {
        char ch;
        scanf("%c", &ch);
        if (ch == 'F') break;
        
        if (a > b)
        {
            printf("Yes \n");
        }
        else if (a == 0 && b == 0)
        {
            printf("Yes \n");
            break;
        }
        
        else
        {
            printf("No \n");
        }
        printf("그만하고 싶다면 F를 누르시오. \n");
        printf("다시 입력하세요 : \n");
        scanf("%d %d", &a, &b);

    }

    return 0;
}   
```    
