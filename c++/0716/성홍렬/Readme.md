```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    string s = "-1123 -21123 -3122 -41";        // 테스트할 스트링
    vector<int> n;                              // s의 문자들을 정수로 바꿔 담을 벡터
    int min, max;                               // n의 정수들 중 최솟값과 최댓값을 담을 변수
    string an;                                  // 최종반환할 스트링


    // 1. s의 문자열을 모두 정수로 바꾸어 n에 담는다.
    for (int i = 0; i < s.size(); i++)
    {
        if (s[i] == ' ' || i == s.size() - 1)   // s의 요소들 중 공백을 만나거나 마지막 요소를 만나면
        {
            n.push_back(stoi(s));               // stoi함수를 활용하여 공백 이전의 문자열를 정수로 변환하여 n에 담는다.
                                                // 참고) stoi함수는 공백 전까지의 문자열을 정수로 변환해준다.
            s.erase(0, i + 1);                  // 변환 후 s에서 변환시킨 문자열을 지우고
            i = 0;                              // 반복문을 첫 요소부터 시작시키기 위해 i = 0으로 초기화 한다.
        }
    }

    // 2. 1에서 만든 벡터 n의 정수들 중 최대와 최소를 가려낸다.
    min = max = n[0];                           // 최대 최소 모두 처음 정수로 가정하여 시작한다.
    for (int i = 0; i < n.size(); i++)          
    {
        if (min > n[i]) min = n[i];             // 최소보다 작은 경우 해당 정수로 초기화
        if (max < n[i]) max = n[i];             // 최대보다 큰 경우 해당 정수로 초기화
    }

    // 3. 최종반환할 스트링 an에 최솟값과 최댓값을 문자열로 변환하여 담는다.
    an += to_string(min);
    an += ' ';
    an += to_string(max);

    // an 확인용
    for (int i = 0; i < an.size(); i++)
    {
        cout << an[i];
    }

    return 0;
}
```