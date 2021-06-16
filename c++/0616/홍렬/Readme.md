```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    int n = 15;         // 기준 정수
    int cn = n;         // n 임시 저장용 변수
    vector<int> bn1;    // n의 2진수 벡터
    vector<int> bn2;    // n 다음 값들의 2진수 벡터
    int cnt = 0;        // bn1속 1의 갯수
    int cnt2 = 0;       // bn2속 1의 갯수

    // 1. n을 2진화
    while (1)
    {
        bn1.push_back(n % 2);
        n /= 2;
        if (n == 0) break;
    }

    // 2. bn1속 1의 갯수 카운트
    for (int i = 0; i < bn1.size(); i++)
    {
        if (bn1[i] == 1)
        {
            cnt++;
        }
    }

    // 3. n 다음에 올 정수들의 2진화 및 1의 갯수 카운트
    n = cn;             // 1번 과정에서 2진화를 하며 n이 0이 되었으므로
                        // 다시 원래 값으로 초기화

    while (1)           // 원하는 값을 찾을때까지 반복
    {
        n++;            // n을 증가된 값으로 초기화
        cn = n;         // 증가된 n을 임시 변수 cn에 대입(2진화에 사용될 정수는 cn)
        cnt2 = 0;       // 1의 갯수 초기화
        bn2.clear();    // bn2 벡터를 0으로 초기화

        while (1)       // 증가된 n의 2진화
        {
            bn2.push_back(cn % 2);
            cn /= 2;
            if (cn == 0) break;
        }

        for (int i = 0; i < bn2.size(); i++)    // bn2속 1의 갯수 카운트
        {
            if (bn2[i] == 1)
            {
                cnt2++;
            }
        }
        
        if (cnt == cnt2) break;                 // bn1 1의 갯수와 bn2 1의 갯수가 같을경우
                                                // 반복문 탈출 및 원하는 n값을 얻게된다.
    }

    return 0;
}
```