### 점프와 순간이동
```C++
#include <iostream>
using namespace std;

int main()
{
    int N = 5;      // 도달해야할 칸 수
    int ans = 0;    // 건전지 사용량

    // 점프는 이동거리 만큼 건전지 사용량이 증가하고
    // 순간이동은 건전지 사용량에 영향을 주지 않으므로
    // 순간이동을 최대한 사용할 것

    // N칸을 순간이동을 최대한 사용하여 이동했다는 가정하에
    // 2를 반복하여 나눠준다.
    // 홀수가 나오는 경우는 1칸 점프했다고 가정하여
    // 건전지 사용량을 증가시켜준다.
    while (N != 0)
    {
        if (N % 2 != 0)
        {
            ans++;
        }
        N /= 2;
    }

    cout << ans;

    return 0;
}
```
<br>

### 영어 끝말잇기
```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    int n = 4;                                          // 끝말잇기에 참여한 인원
    vector<string> words = { "a", "sba", "aba", "aba" };  // 검사할 끝말잇기 벡터<스트링>
    string t;                                           // 끝말잇기 단어를 잠시 담을 임시 스트링
    int idx = 0;                                        // 끝말잇기가 중단된 순서
    int flag = 0;                                       // 끝말잇기가 중단되어 탈락자가 나왔음을 나타내는 플래그
    vector<int> answer = { 0, 0 };                      // 경기 결과는 중단 안될경우를 대비하여
                                                        // [ 0, 0 ]로 초기화 한다.

    // 1. 끝말잇기가 중단되는지 판단한다.
    for (int i = 1; i < words.size(); i++)
    {
        t = words[i];                   // 한 단어를 잠시 담아 놓는다.

        // 1-1. 중복 단어를 말했는지 판단한다.
        for (int j = 0; j < i; j++)     // 해당 순서 바로 전까지 반복문을 돌려
        {                               // 그 전에 t단어와 같은 단어가 나왔는지 판단한다.

            if (t == words[j])          // 이전에 t단어와 같은 단어가 있다면
            {                           // 해당 인덱스(i)를 중단 인덱스로 설정한다.

                idx = i + 1;            // 벡터 인덱스는 0부터 시작하므로(0, 1, 2, ...) -> i
                                        // 1부터 시작하는 순서(1, 2, 3, 4, ...)인 중단 인덱스 -> idx

                flag = 1;               // 끝말잇기가 중단 됐으므로 flag에 변화를 준다
                break;                  // 위 과정이 끝나고 1-1번 반복문 탈출
            }
        }

        if (flag == 1) break;           // flag = 1이면(= 끝말잇기가 중단되었으면)
                                        // 1번 반복문 탈출

        // 1-2. 끝말을 잇는 단어를 말했는지 판단한다.
        if (words[i].front() != words[i - 1].back())
        {                       // 앞 단어의 끝문자과 해당 단어의 첫문자를 비교한다.
                                // 둘이 다를 경우

            idx = i + 1;        // 1-1과 같은 과정을
            flag = 1;           // 거친 후
            break;              // 1번 반복문 탈출
        }
    }

    // 2. flag = 1인 경우(끝말잇기가 중단된 경우)
    //    해당 단어를 누가 말했는지 = answer[0]
    //    몇 번째 스테이지에서 탈락했는지 = answer[1]
    //    answer에 값 대입
    if (flag == 1)
    {
        if ((idx % n == 0) && (idx != 0))               // 2-1. idx가 n의 배수인 경우
        {                                               //      ex) n = 3, idx = 6
            answer[0] = n;                              //      answer[0] = 3
            answer[1] = idx / n;                        //      answer[1] = 2
        }
        else                                            // 2-2. idx가 n의 배수가 아닌경우
        {                                               //      ex) n = 3, idx = 5
            answer[0] = idx % n;                        //      answer[0] = 2
            answer[1] = ((idx - (idx % n)) / n) + 1;    //      answer[1] = 2
        }
    }
    
    cout << answer[0] << " " << answer[1];

    return 0;
}
```