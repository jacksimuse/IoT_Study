```C++
#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    vector<int> arr = { 2, 6, 8, 14 };  // 테스트할 벡터
    int an;                             // 최종 반환할 최소공배수
    int flag = 0;                       // 최소 공배수 인지 아닌지 판단할 변수

    // 1. 테스트할 벡터를 오름차순으로 정렬
    sort(arr.begin(), arr.end());

    // 2. 최초의 최소 공배수는 벡터 내 제일 큰 수로 초기화
    an = arr.back();

    // 3. an은 벡터에서 제일 큰 수이므로
    //    구하고자하는 최소 공배수는
    //    an의 배수와 나머지 숫자들의 공배수를 만족하는 수 중 제일 작은 수이다.
    while (1)
    {
        for (int i = 0; i < arr.size(); i++)    // an이 최소 공배수인지 판단
        {
            if (an % arr[i] == 0)               // 벡터 요소별로 판단한다
            {
                flag = 0;                       // 해당 요소의 배수인 경우 flag는 변화없다
            }
            else if (an % arr[i] != 0)          // 해당 요소의 배수가 아닌 경우
            {
                flag = 1;                       // flag는 변화가 생기고
                break;                          // 그 즉시 판단 반복문 탈출
            }
        }

        if (flag == 0) break;                   // 만약 flag가 0인채로 반복문이 끝났다면
                                                // = an이 모든 벡터 요소의 배수라면
                                                // = 구하고자하는 최소 공배수라면
                                                // while 반복문 탈출하여 an 값을 출력하게 된다.

        an += arr.back();                       // flag = 1로 판단 반복문이 끝난 경우
                                                // an은 다음 배수로 초기화 된다.
    }

    cout << an;

    return 0;
}
```