```C++
#include <string> // 기존 헤더파일
#include <vector>
#include <cmath>  // 제곱근을 위해 넣은 헤더파일
#include <iostream>
using namespace std;

int solution(int n) {
    int answer = 0;
    int third[100] = { 0 }; // 3진법 각 자리 수를 배열로 받는다
    int count = 1;  // 10진법을 3진법으로 만들기 위해 몇번 나눠지는지 카운트
    int m = n;  // n을 사용하기 위한 m

    while (m / 3 != 0) {  // m을 3으로 계속 나눈다
        m = m / 3;
        count++;  // 몇번 나눠지는지 카운트
    }

    for (int i = 0; i < count; i++)
    {
        third[i] = n % 3; // 배열 첫번째부터 나머지를 담게되면 굳이 받은 것을 뒤집어 줄 필요가 없다
        n = n / 3;  // n을 계속 사용하려고 몫으로 초기화
    }
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) answer += third[i] * pow(3, (count - count)); // 3진법 각자리 값 x 해당 각자리 수
        else answer += third[i] * pow(3, (count - i -1));
        
    }
    return answer;
}

int main()
{
    int n;
    cin >> n; // n 입력
    cout << solution(n);  // anwer에 리턴된 것을 출력
}
```
