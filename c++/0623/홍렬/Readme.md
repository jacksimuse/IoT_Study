```C++
#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

int main()
{
    string skill = "CBD";       // 기준이 될 skill 스트링
    vector<string> skill_trees = { "BACDE", "CBADF", "AECB", "BDA" };   // 검사 당할 스킬트리 벡터<스트링>
    string t;                   // 스킬트리의 요소를 잠시 담을 임시 스트링
    int flag;                   // t와 skill이 다른지에 대한 판단을 담을 flag
    int answer = 0;             // skill 순서를 준수하는 스킬트리의 수

    // 1. skill과 비교하기위해
    //    스킬트리의 스트링에서 skill의 요소와 같은 것들을 잠시 t에 보관
    for (int i = 0; i < skill_trees.size(); i++)
    {
        // 스킬트리의 다음 스트링으로 넘어가기전 항상 초기화
        flag = 0;
        t.clear();

        // 스킬트리에서 skill과 같은 요소를 t에 담는다
        for (int j = 0; j < skill_trees[i].size(); j++)
        {
            for (int k = 0; k < skill.size(); k++)
            {
                if (skill_trees[i][j] == skill[k])
                {
                    t.push_back(skill_trees[i][j]);
                }
            }
        }

        // 2. 완성된 t와 skill을 비교한다.
        for (int l = 0; l < t.size(); l++)
        {
            if (t[l] != skill[l])   // 만약 하나라도 다르다면
            {
                flag = 1;           // flag는 1로 바뀌고
                break;              // 이 반복문을 탈출한다.
            }
        }

        // 3. 만약 t가 skill의 순서를 준수하는 스트링이라면
        if (flag == 0)
        {
            answer++;   // 만족하는 스킬트리의 수를 증가시킨다.
        }
    }

    cout << answer;

    return 0;
}
```