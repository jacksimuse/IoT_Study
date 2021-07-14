```C++
/*
  프로그래머스 Lv2 : 124 나라의 숫자
  자연 수만 존재하는 124 나라에서 모든 수를 124로 변환하는 문제.
*/

/*
  구현
  1. 모든 수가 124로 끝나므로 3 나머지 연산 사용(나머지가 0, 1, 2 일때 각각 4, 1, 2가 된다)
  2. 문자열 변수를 선언해서 나머지 연산의 결과를 앞부터 채워준다.
  3. n에서 1을 빼주고 3을 나눠준다.
   3-1. 1을 빼는 이유는 3일때 4를 출력해야하는데 빼지않고 연산하면 14가 출력됨 
   3-2. 
  4. 2~3 반복(n이 0이 될때까지)
*/

#include <string>
#include <vector>
#include <iostream>
using namespace std;

string solution(int n) 
{
    string answer = "";
    vector<string> lastnum = {"4", "1", "2"};  // % 3 의 값에따라 0, 1, 2 일때 4, 1, 2 출력

    while (n)
    {
        answer = lastnum[n % 3] + answer;  // 나머지 연산값을 문자열에 삽입
         
        n = n - 1;    

        n /= 3;    
    }

    cout << answer << endl;
    return answer;
}

int main()
{
    solution(1); // 1
    solution(2); // 2
    solution(3); // 4
    solution(4); // 11
    solution(13); // 111
    solution(14); // 112
    solution(15); // 114
    solution(16); // 121

    return 0;
}
```
