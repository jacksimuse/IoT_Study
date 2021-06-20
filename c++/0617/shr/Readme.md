```C++
#include <string>
#include <vector>
#include <iostream>
#include <algorithm>    // next_permutation()을 사용하기 위한 헤더

using namespace std;

int main()
{
    string n = "011";  // 테스트할 스트링
    string t;           // n에서 발생하는 순열을 잠시 담을 임시 스트링
    vector<int> all;    // n에서 발생하는 모든 순열을 정수화 하여 담을 벡터
    vector<int> final;  // all에서 중복요소를 제거한 벡터
    int k = 0;          // 순열의 자릿수(++)
    int cnt1 = 0;       // 소수 판단에 사용될 카운트1
    int cnt2 = 0;       // 소수 판단에 사용될 카운트2
    int stage = 0;      // 모든 순열을 만들고 반복문을 탈출시 사용할 변수
                        // "1234"이면 1 ~ 4까지 증가한뒤 반복문을 탈출시킴

    sort(n.begin(), n.end()); // next_permutation은 사전순으로 가장 가까운 다음 상태로 배열하는 함수이므로 
                              // 시작 지점이 오름차순으로 정렬되어 있어야 모든 경우의 수(or 순열)를 만들 수 있다.


    // 1. n 스트링에서 발생가능한 모든 순열을 all벡터에 담는다.
    while (1)
    {
        k++;            // 만들 순열의 자리수를 정한다.(1부터 시작)

        do              // 42행에 의해 n스트링에서 만들 수 있는
        {               // k자릿수를 가지는 순열을 만든다.

            for (int i = 0; i < k; i++) // 자리수 만큼 반복하여
            {
                t += n[i];              // 임시 스트링t에 해당 순열(문자)을 담는다 
            }

            all.push_back(atoi(t.c_str())); // 임시 스트링 t에 담긴 문자를 "정수화" 하여 all에 담는다.
            t.clear();                      // 담고 나서 t는 다시 비워준다.

            reverse(n.begin() + k, n.end());// 중복되는 순열을 피하기 위해 k의 다음 자리 문자를
                                            // 끝과 교환한다.

        } while (next_permutation(n.begin(), n.end()));

        stage++;                            // n의 총 자릿수와 같아지면 반복문 탈출
        if (stage == n.size()) break;       // "1234"의 경우 stage = 0 ~ 3이 되고, 
                                            // 4가 되는 순간 반복문 종료한다.
    }


    // 2-1. 모든 순열을 담은 all벡터에서 중복되는 요소 제거(-1로 처리한다).
    for (int i = 0; i < all.size(); i++)
    {
        for (int j = 0; j < all.size(); j++)
        {
            if (i == j) continue;
            if (all[i] == all[j])
            {
                all[j] = -1;
            }
        }
    }


    // 2-2. 2-1에서 처리한 요소(-1)들을 제외한 요소들을 final벡터에 담는다.
    for (int i = 0; i < all.size(); i++)
    {
        if (all[i] == -1) continue;
        final.push_back(all[i]);
    }


    // 3. final벡터의 요소들을 소수 판단을 하여 카운트 한다.
    for (int i = 0; i < final.size(); i++)
    {
        cnt1 = 0;
        for (int j = 1; j <= final[i]; j++)
        {
            if (final[i] % j == 0) cnt1++;
        }
        if (cnt1 == 2) cnt2++;
    }

    cout << cnt2;

    return 0;
}
```