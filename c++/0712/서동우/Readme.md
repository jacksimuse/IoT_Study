```C++
/*
  프로그래머스 Lv2 연습문제 : n개의 최소공배수
  n개의 수의 최소공배수를 구하는 문제
*/

/*
  구현
  1. 주어지는 벡터 arr를 정렬
  2. 맨 마지막 수를 lastnum에 저장
  3. 제일 큰 수 * n를 구해주고 이 숫자가 for문으로 arr에 있는 요소들과 나머지 연산으로 나누어 떨어지는지 검사
  4. 모든 요소들이 제일큰수 * n 에 나누어떨어지면 그것이 최소공배수가되므로 그 값을 반환
*/

#include <string>
#include <vector>
#include <algorithm>
#include <iostream>
using namespace std;

int solution(vector<int> arr)
{
    int answer = 0;                // 최소공배수를 저장할 변수 answer
    sort(arr.begin(), arr.end());  // arr를 정렬해줌

    int lastnum = arr[arr.size() - 1];  // 벡터의 마지막 숫자(제일 큰 숫자)를 lastnum에 저장

    bool flag = true;              // while문을 빠져나가는 것을 판별할 flag
    int mulnum = 1;                // 제일 큰 수에 곱해줄 숫자(lastnum * mulnum 이 최소공배수가 될 것임)

    while (flag)
    {
        flag = false;
        answer = lastnum * mulnum;  // 제일 큰 숫자 * mulnum 을 answer에 저장

        // arr의 요소들이 answer에 나눠떨어지는지 구해줌
        for (int i = 0; i < arr.size(); i++)  
        {
            if (answer % arr[i] != 0)  // 나눠떨어지지않으면 공배수가 아니므로 for문을 빠져나감
            {
                flag = true;
                break;
            }
        }
        mulnum++;                   // 다음 곱해줄 숫자를 ++해줌
    }
    cout << answer << endl;         
    return answer;                  // 최소 공배수(answer)를 반환
}

int main()
{
    solution({ 2, 6, 8, 14 });
    return 0;
}
```
