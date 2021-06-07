```C++
// 약수갯수를 통한 덧셈과 뺄셈
#include <string>
#include <vector>
#include <iostream>

using namespace std;

void solution(int left, int right) {
    int answer = 0;                     // 최종 반환 결과 값
    int i, j;                           // 반복문용
    int size;                           // 만들어진 배열의 크기
    int hm = 0;                         // 약수의 갯수
    int a[100];                         // 약수갯수 판별할 숫자들의 배열

    size = right - left;                // 입력된 left, right값을 이용해
                                        // 만들어질 배열의 크기를 구한다

    for (i = 0; i <= size; i++)         // 1. 약수갯수를 구할 숫자들을 배열에 넣는다
    {
        a[i] = left++;
    }

    for (i = 0; i <= size; i++)         // 2. 배열 요소별로 1 ~ 해당요소만큼 반복
    {                               
        for (j = 1; j <= a[i]; j++)
        {
            if (a[i] % j == 0) hm++;    // 약수를 만나면 howmany(약수갯수)가 1증가
        }
        if (hm % 2 != 0) a[i] *= -1;    // howmany가 홀수인 경우 해당요소를 음수화
        hm = 0;                         // 다음 요소로 넘어가기전 hm을 0으로 초기화
    }

    for (i = 0; i <= size; i++)         // 3. 약수갯수에 따라 부호가 정해진 요소들을
    {
        answer += a[i];                 // 점부 더해 최종 반환값을 만든다.
    }

    for (i = 0; i <= size; i++)         // 부호가 바뀐 요소들 확인용
    {
        cout << a[i] << " ";
    }

    cout << endl;

    cout << answer << endl;             // 최종 반환값 확인용
}

int main()
{
    int left, right;

    cin >> left >> right;

    solution(left, right);

    return 0;
}
```
<br>

---

<br>

```C++
// 두 개 뽑아서 더하기
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    //vector<int> a = { 2, 1, 3, 4, 1 };    // 일반적인 경우
    vector<int> a = { 0, 0, 0 };            // 0만 넣은 경우
    vector<int> b;                          // a벡터 요소들을 더해서 만든 벡터(중복 존재)
    vector<int> c;                          // b벡터에서 중복되는 요소들을 뺀 벡터(최종)

    int i, j;                               // 반복문용
    int temp;                               // 정렬속 swap용

    // 1. a백터의 요소들을 서로서로 싹다 더한 후
    //    b벡터에 대입한다.
    for (i = 0; i < a.size(); i++)
    {
        for (j = 0; j < a.size(); j++)
        {
            if (i == j) continue;       // i = 1, j = 1이어서
                                        // a[1] + a[1]인 경우를 스킵한다.

            b.push_back(a[i] + a[j]);   // a = { 1, 2, 3 } 인경우
                                        // b = { 3, 4, 3, 5, 4, 5 }가 된다.
        }
    }

    // b벡터 확인용
    for (i = 0; i < b.size(); i++)
    {
        cout << b[i] << " ";
    }

    cout << endl;

    // 2. b벡터 속 중복된 값을 가지는 요소들을 -1로 처리한다.
    for (i = 0; i < b.size(); i++)
    {
        for (j = 0; j < b.size(); j++)
        {
            if (i == j) continue;       // b[1]과 b[1]을 비교하는 경우는 스킵
            if (b[i] == b[j])           // b요소들을 서로 비교하여 같은 경우
            {
                b[j] = -1;              // 둘 중 하나의 요소를 -1로 치환
                                        // [1, 0, 2, 1]인 경우
                                        // [1, 0, 2, -1]로 바꿔준다
            }
        }
    }

    // 3. b벡터에서 -1을 제외한 모든 요소들을 받아온다.
    for (i = 0; i < b.size(); i++)
    {
        if (b[i] != -1)
        {
            c.push_back(b[i]);      // b = { 1, 0, 2, -1 }인 경우
                                    // c = { 1, 0, 2 }가 된다.
        }
    }

    // 4. 마지막으로 c벡터의 요소들을 오름차순으로 정렬한다.
    for (i = 1; i < c.size(); i++)
    {
        for (j = i; j > 0; j--)
        {
            if (c[j] < c[j - 1])
            {
                temp = c[j];
                c[j] = c[j - 1];
                c[j - 1] = temp;
            }
        }
    }

    // c벡터 확인용
    for (i = 0; i < c.size(); i++)
    {
        cout << c[i] << " ";
    }

    return 0;
}
```
<br>

---

<br>

```C++
// 음양 더하기
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    vector<int> a = { 1, 2, 3 };                // 정수 벡터
    vector<bool> s = { false, false, true };    // 부호 벡터(bool형)
    vector<int> is;                             // 부호 벡터(int형)
    int i;                                      // 반복문용
    int res = 0;                                // 최종 반환 변수

    // 1. s벡터의 bool 값을 이용하여 is벡터의 정수값(1 or -1) 생성
    for (i = 0; i < s.size(); i++)
    {
        if (s[i] == true)       // s벡터가 true인 경우 is는 1
        {
            is.push_back(1);
        }
        else if (s[i] == false) // s벡터가 false인 경우 is는 -1
        {
            is.push_back(-1);
        }
    }

    // is벡터 확인용
    for (i = 0; i < is.size(); i++)
    {
        cout << is[i] << " ";
    }

    cout << endl;

    // 2. is벡터의 1(or -1)값을 이용하여 부호가 있는 정수로 변환
    for (i = 0; i < a.size(); i++)
    {
        a[i] *= is[i];
    }

    // a벡터 확인용
    for (i = 0; i < a.size(); i++)
    {
        cout << a[i] << " ";
    }

    cout << endl;

    // 3. res에 a벡터의 값들을 더하여 최종 반환값 만들기
    for (i = 0; i < a.size(); i++)
    {
        res += a[i];
    }

    // res 확인용
    cout << res;

    return 0;
}
```
