```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    string n = "4177252841";        // 테스트할 string
    int k = 4;                      // n에서 잘라낼 숫자 수
    const int ck = k;               // while문에서 반복문 종료 판단에 사용하기위해 k를 상수화
    char max;                       // 단계별 최댓값을 뽑아내기 위한 임시 최댓값
    int id;                         // 단계별 최댓값의 인덱스
    vector<int> index = { 0 };      // 단계별 최댓값의 인덱스를 저장할 벡터
    int cnt = 0;                    // 수행한 단계의 횟수
    string a;                       // 최종 반환할 string

    // 최종으로 만들고자하는 문자열의 길이만큼 단계를 반복하여 수행한다.
    while (cnt != n.size() - ck)
    {
        max = '0';                          // 단계마다 최댓값을 뽑기위해
                                            // 단계 수행 전 문자'0'으로 초기화

        // 1. 첫 단계
        if (cnt == 0)
        {
            for (int i = 0; i <= k; i++)    // 문자열의 첫 문자부터 
            {                               // a문자열의 길이를 충족시킬 수 있는 인덱스까지 반복 수행
                                            // ex) string = "1234", k = 2 인경우 a문자열의 길이는 2이므로
                                            // i는 0부터 2까지만 반복가능하다.

                if (max < n[i])             // 최댓값 탐색 수행
                {
                    max = n[i];             // 최댓값을 max에 담고
                    id = i;                 // 해당 인덱스 또한 id에 담는다.
                }
            }
            a += max;                       // a배열에 max문자를 추가한다.
            index.push_back(id);            // 인덱스벡터에 id를 추가한다.
            k++;                            // 다음 탐색 범위를 위해 +1한다.
            cnt++;                          // 하나의 단계가 수행되었으니 +1한다.
        }

        // 2. 1단계 이후 모든 단계에 적용
        else if (cnt > 0)
        {
            for (int i = index[cnt] + 1; i <= k; i++)   // 바로 전 단계에서 찾아낸 최댓값의 다음 인덱스부터 시작
            {                                           // 마찬가지로 a문자열의 길이를 만족시키는 상한선까지 반복 수행

                if (max < n[i])                         // 최댓값 탐색
                {
                    max = n[i];
                    id = i;
                }
            }
            a += max;                                   // 최댓값 및 인덱스 처리 과정은
            index.push_back(id);                        // 위와 동일하다.
            k++;
            cnt++;
        }
    }

    cout << a;

    return 0;
}
```
