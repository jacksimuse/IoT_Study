```C++
#include<string>
#include <iostream>
#include <vector>

using namespace std;

int main()
{
    bool answer = false;    // answer의 초기값
    string a = ")()(";      // 테스트할 스트링
    vector<int> il, ir;     // ( 와 )의 인덱스를 담을 벡터

    // 1. 스트링속 괄호들의 위치를 벡터화
    for (int i = 0; i < a.size(); i++)      // 스트링의 요소를 처음부터 끝까지 조사
    {
        if (a[i] == '(') il.push_back(i);   // ( 인 경우 il벡터에 해당 인덱스값 삽입
        if (a[i] == ')') ir.push_back(i);   // ) 인 경우 ir벡터에 해당 인덱스값 삽입
    }

    // 2. 벡터화된 괄호의 인덱스를 바탕으로 올바른 괄호의 조건에 따라 참/거짓 판별
    
    // 올바른 괄호의 조건
    // 첫 번째. ( 와 ) 의 갯수가 같아야 한다
    // 두 번째. ) 는 무조건 ( 의 뒤에 와야 한다
    // --> 첫 번재 조건을 만족하고 두 번째 조건을 만족하는 괄호의 갯수가
    //     해당 벡터의 크기와 같다면 올바른 괄호의 조건을 만족

    int cnt = 0;                            // 두 번째 조건을 증명할 변수

    if (il.size() == ir.size())             // 첫 번째 조건을 만족한다면
    {
        for (int i = 0; i < il.size(); i++) // ( 와 )의 위치를 비교하여 두 번째 조건을
        {                                   // 만족하는지 판별한다
            if (il[i] < ir[i])              // 해당 벡터 요소들이 2의 조건을 만족한다면
            {
                cnt++;                      // cnt는 하나씩 증가한다.
            }
        }

        if (cnt == il.size())               // 최종 cnt(만족하는 괄호수)와 벡터의 크기가 같다면
        {
            answer = true;                  // answer는 true
        }
    }
    else if (il.size() != ir.size())        // 첫 번째 조건 불만족시
    {
        answer = false;                     // answer는 false
    }

    cout << answer;

    return 0;
}
```