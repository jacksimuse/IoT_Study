```C++
#include <string>
#include <iostream>
using namespace std;

int solution(string dirs) {
    int answer = 0;
    return answer;
}

int main()
{
    string dirs = "LULLLLLLU";
    string dirs2 = "ULURRDLLU";
    int x = 0;
    int y = 0;
    int res = 0;

    for (int i = 0; i < dirs.size(); i++)
    {
        if (dirs[i] == 'U')
        {
            if (y >= 5)
            {
                continue;
            }
            else
            {
                y++;
                res++;
            }
        }
        else if (dirs[i] == 'D')
        {
            if (y <= -5)
            {
                continue;
            }
            else
            {
                y--;
                res++;
            }
        }
        else if (dirs[i] == 'L')
        {
            if (x <= -5)
            {
                continue;
            }
            else
            {
                x--;
                res++;
            }
        }
        else if (dirs[i] == 'R')
        {
            if (x >= 5)
            {
                continue;
            }
            else
            {
                x++;
                res++;
            }
        }
    }

    cout << res;

    return 0;
}
```