# 올바른 괄호
```C++
#include<string>
#include <iostream>

using namespace std;

bool solution(string s)
{
    bool answer = true;
    int cnt = 0; // 짝이 맞는지 확인할 cnt
    for (int i = 0; i < s.size(); i++)
    {
        if (s[i] == '(') cnt++; // '('라면 +1, ')'면 -1
        else cnt--; 

        if (cnt < 0) {  // cnt가 음수면 ')'가 더 많아서 false
            answer = false; 
            break;
        }
    }

    if (cnt != 0) answer = false; // 0이 아니면 짝이 안맞아서 false
    return answer;
}

int main()
{
    string gwalho;
    getline(cin, gwalho);

    cout << solution(gwalho);
}
```
