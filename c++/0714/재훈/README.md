# 124나라
```C++
#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

string solution(int n) {
    string answer = ""; // 답을 받는 곳
    string answer_int = ""; // 각 자리수를 받을 곳

    while (n > 0) // n이 양수일때까지 돌린다
    {
        if (n % 3 == 1) // 주기가 3이므로 3으로 나눠지는 것을 확인 후 1,2,4 문자로 바꾼다
            answer_int = "1";
        else if (n % 3 == 2)
            answer_int = "2";
        else
            answer_int = "4";

        if (n % 3 == 0) n--;  // 자리수 문제때문에 3의 배수는 -1을 해준다 ex) 2다음 4이므로 맞춰줘야된다
        n = n / 3;
        
        answer += answer_int; // 순서대로 문자를 받는다
    }

    reverse(answer.begin(), answer.end());  // 역순으로 바꿔줘야 자리수가 맞다

    return answer;
}
```
