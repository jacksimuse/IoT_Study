```C++
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