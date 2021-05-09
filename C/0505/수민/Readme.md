## 1. 반복문

[문자열 반복](https://www.acmicpc.net/problem/2675)


```c
#include <stdio.h>
#include <string.h>
 
int main() {
    int T, R;    
    char S[21];    // 문자열 S
      
    scanf("%d", &T);  // T만큼 테스트케이스
    
    while (T--) {
        scanf("%d %s", &R, S); // 
        
        
        /* 결과를 출력하기 위한 반복문 */ 
        for (int i = 0; i < strlen(S); i++) {   // 문자열의 길이 만큼 반복
            for (int j = 0; j < R; j++)         // R만큼 반복 출력하기 
                printf("%c", S[i]);
        }
 
        printf("\n");
    }
    return 0;
}
```
