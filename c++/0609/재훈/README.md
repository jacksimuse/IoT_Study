# 방문 길이
```C++
/* 가장 중요한 개념
   1. 간선(이 방향으로 지나간 적이있는가? 1 : 0)
   2. 간선을 표현하기 위한 좌표같은 배열 4개 [이전x][이전y][현재x][현재y]

     int adj[11][11][11][11]; [prev_x][prev_y][x][y]
     [0][0] -> [0][1] adj[0][0][0][1] =1 ; adj[0][1][0][0] = 1;
*/

#include <iostream>
#include <string>
using namespace std;

int solution(string dirs) {
    int answer = 0, round = 0;
    int px_py_x_y[11][11][11][11];  // -5~5까지 11칸이므로 배열 11칸씩 할당
    int x = 5, y = 5;               // 가운데는 5로 표시하지만 (0,0) 위치
   
    while (round != dirs.size())    // 글자수까지 도는 것을 round로 체크
    {
        if (dirs[round] == 'U')     // 첫문자가 'U'이면
        {
            if (y + 1 < 11) {       // y축으로 한칸 이동하지만 판은 나가서 안되므로 11보다 작은지 여부
                if (px_py_x_y[x][y][x][y + 1] != 1) {   // 현재 y축 1칸이 증가하는 곳에 지나간적이 없다면
                    px_py_x_y[x][y][x][y + 1] = 1;      // (0,0) -> (0,1) 방향 '1' 처리
                    px_py_x_y[x][y + 1][x][y] = 1;      // 같은 길이므로 (0,1) -> (0,0) 방향 '1'처리
                    answer++;                           // 처음 지나가므로 1증가
                }
                y++;                                    // y축으로 1칸 이동
            }
        }
        else if (dirs[round] == 'D')    // 밑에 3 구문도 같은 상황
        {
            if (y - 1 >= 0) {
                if (px_py_x_y[x][y][x][y - 1] != 1) {
                    px_py_x_y[x][y][x][y - 1] = 1;
                    px_py_x_y[x][y - 1][x][y] = 1;
                    answer++;
                }
                y--;
            }
        }
        else if (dirs[round] == 'L')
        {
            if (x - 1 >= 0) {
                if (px_py_x_y[x][y][x - 1][y] != 1) {
                    px_py_x_y[x][y][x - 1][y] = 1;
                    px_py_x_y[x - 1][y][x][y] = 1;
                    answer++;
                }
                x--;
            }
        }
        else if (dirs[round] == 'R')
        {
            if (x + 1 < 11) {
                if (px_py_x_y[x][y][x + 1][y] != 1) {
                    px_py_x_y[x][y][x + 1][y] = 1;
                    px_py_x_y[x + 1][y][x][y] = 1;
                    answer++;
                }
                x++;
            }
        }
        round++;
    }
    return answer;
}

int main()
{
    std::string input;
    std::cin >> input;
    
    std::cout << solution(input);
}
```
