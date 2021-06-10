```C++
#include <string>
#include <iostream>
using namespace std;

int main()
{
    string dirs = "LLLLLLR";    // 방문자의 경로를 담은 문자열
    int mx[600] = { 0 };        // 방문자의 x경로를 담을 정수 배열(전 요소 0으로 초기화)
    int my[600] = { 0 };        // 방문자의 y경로를 담을 정수 배열(전 요소 0으로 초기화)
    int cntx = 0;               // mx의 사이즈
    int cnty = 0;               // my의 사이즈
    int ix = 0;                 // mx의 인덱스
    int iy = 0;                 // my의 인덱스
    int ry, rx;                 // 좌표를 통해 구한 경로 값
    int res1 = 0;               // 중복된 경로 값을 제외한 mx의 사이즈(= 최종 x방향 경로 수)
    int res2 = 0;               // 중복된 경로 값을 제외한 my의 사이즈(= 최종 y방향 경로 수)
    int res;                    // res1 + res2
    //int a[11][11] = { 0 };    // 하다보니 좌표 찍을 필요는 없을 듯
    int x = 5;                  // 처음 x좌표
    int y = 5;                  // 처음 y좌표

//                     x축
//       0  1  2  3  4  5  6  7  8  9  10
//     0
//     1
//     2            (y, x)로 가정하고 했습니다. 
//     3            원래는 (x, y)이지만 하다보니까 이렇게 해버림
//     4
// y축 5             (5, 5) -> 원점
//     6
//     7
//     8
//     9
//     10

    // 1. dirs을 읽어 방향에 따른 경로 값 구한다
    for (int i = 0; i < dirs.size(); i++)
    {
        if (dirs[i] == 'U') // up
        {
            y--;            // 위로 한 칸 올라가므로 y--

            if (y < 0)      // U에 의한 다음 좌표가 평면 밖인 경우
            {
                y = 0;      // U를 제외한 다른 방향으로 가기위해 0으로 초기화
                continue;
            }

            ry = (y + (y + 1)) + (x * 100); // 경로배열에 넣을 경로 값 계산
                                            // (5, 5) -> (4, 5)인 경우
                                            // ry = 509가 된다.
            cnty++;                         // 경로 배열의 사이즈 측정
            my[iy++] = ry;                  // 경로 배열에 삽입
        }
        else if (dirs[i] == 'D') // down
        {
            y++;
            if (y > 10)
            {
                y = 10;
                continue;
            }
            ry = (y + (y - 1)) + (x * 100);
            cnty++;
            my[iy++] = ry;
        }
        else if (dirs[i] == 'L') // left
        {
            x--;
            if (x < 0)
            {
                x = 0;
                continue;
            }
            rx = (x + (x + 1)) + (y * 100);
            cntx++;
            mx[ix++] = rx;
        }
        else if (dirs[i] == 'R') // right
        {
            x++;
            if (x > 10)
            {
                x = 10;
                continue;
            }
            rx = (x + (x - 1)) + (y * 100);
            cntx++;
            mx[ix++] = rx;
        }
    }

    // 2. 방문이 끝나고 각 경로 배열에서 중복되는 경로에 대한 처리
    for (int i = 0; i < cntx; i++)      // mx배열 처리
    {
        for (int j = 0; j < cntx; j++)
        {
            if (i == j) continue;
            if (mx[i] == mx[j])         // 중복되는 한 쌍의 값 발견시
            {
                mx[j] = -1;             // 둘 중 하나를 -1로 처리
            }
        }
    }

    for (int i = 0; i < cnty; i++)      // my배열 처리
    {
        for (int j = 0; j < cnty; j++)
        {
            if (i == j) continue;
            if (my[i] == my[j])
            {
                my[j] = -1;
            }
        }
    }

    // 3. 최종으로 처음 걸은 길의 길이를 구한다
    for (int i = 0; i < cntx; i++)
    {
        if (mx[i] == -1) continue;  // 2단계에서 처리한 중복 값을 빼고
        res1++;                     // 카운트 한다
    }

    for (int i = 0; i < cnty; i++)
    {
        if (my[i] == -1) continue;
        res2++;
    }

    res = res1 + res2;              // 카운드된 x경로수와 y경로 수를 더하여 최종값 계산

    cout << res;

    return 0;
}
```