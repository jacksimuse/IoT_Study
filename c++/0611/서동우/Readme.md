```C++
#include <string>
#include <iostream>

using namespace std;

bool solution(string s)
{
    bool answer = false;     // 반환할 정답 bool형 변수

    int count = 0;           // '('  , ')' 에 따라 변화를 줄 count

    for (int i = 0; i < s.size(); i++)
    {
        if (s[i] == '(')       // '('가 오면 count를 ++ 해줌
        {
            count++;
        }
        else if (s[i] == ')')  // ')' 가 오면 count를 -- 해줌
        {
            count--;
        }

        if (count < 0)        // count가 음수가 되면 false반환하고 함수 종료
        {
            return false;
        }
        // count가 음수가 되었다 => 뭔가 이상이 생겼으니 종료하고 false 반환
        // 1. 맨 처음 값이 )이 왔을때 => 짝이 딱 맞게 닫힐수가 없으니 종료
        // 2. 중간에 음수가 되었을때 => for문으로 문자열을 끝까지 돌리기 전에 음수가 나왔으므로
        //                           ')'가 중간에 더 많다는 뜻이므로 짝이 안맞음 => 종료
        
    }

    // 중간에 종료되는일 없이 정상적으로 '('  ,  ')' 를 카운트했을때 조건문
    if (count == 0)        // count가 0이 되었다 => ( ) 짝이 맞았다 => true
    {
        answer = true;
    }
    else                   // count가 0이 아니다 => ( ) 짝이 안맞다 => false
    {
        answer = false;
    }

    return answer;
}

int main()
{
    string s1("()()");
    string s("(())()");
    string s4(")()(");
    string s3("(()(");
    string s2("())");
    

    solution(s);
}
```
