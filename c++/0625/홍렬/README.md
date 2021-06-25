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
    int n = 4;
    vector<string> words = { "a", "aba", "aba", "a" };	// 끝말잇기 벡터<스트링>
    string t;
    int idx = 0;
    int flag = 0;
    vector<int> answer = { 0, 0 };

    for (int i = 1; i < words.size(); i++)
    {
        t = words[i];
        for (int j = 0; j < i; j++)
        {
            if (t == words[j])
            {
                idx = i + 1;
                flag = 1;
                break;
            }
        }

        if (flag == 1) break;

        if ((flag == 1) || (words[i].front() != words[i - 1].back()))
        {
            idx = i + 1;
            flag = 1;
            break;
        }
    }

    if (flag == 1)
    {
        if ((idx % n == 0) && (idx != 0))
        {
            answer[0] = n;
            answer[1] = idx / n;
        }
        else
        {
            answer[0] = idx % n;
            answer[1] = ((idx - (idx % n)) / n) + 1;
        }
    }
    
    cout << answer[0] << " " << answer[1];


    return 0;
}
```