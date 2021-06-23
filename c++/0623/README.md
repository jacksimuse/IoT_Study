#스킬트리
```C#
#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(string skill, vector<string> skill_trees) {
    int answer = skill_trees.size(); // 답을 배열의 사이즈만큼 둔다
    string get_skill; // 스킬중에서 순서대로 찍어야될 스킬셋과 비교할 그릇
    int flag = 1; // 순서가 맞는지 확인해줄 플래그

    for (int i = 0; i < skill_trees.size(); i++)
    {
        for (int j = 0; j < skill_trees[i].size(); j++)
        {
            for (int k = 0; k < skill.size(); k++) // 이중배열과 일차 배열의 배교이므로 for문 3개 썼습니다.
            {
                if (skill_trees[i][j] == skill[k])  // 찍은 스킬을 순서대로 찍어야되는 스킬과 비교해서 같은게 있으면 그릇에 담는다
                {
                    get_skill.push_back(skill_trees[i][j]);
                    break;
                }
            }
        }
        for (int j = 0; j < get_skill.size(); j++)  // 순서가 맞는지 확인용 for문
        {
            if (skill[j] != get_skill[j]) // 같은 위치에 하나라도 다르면 flag = 0 처리
            {
                flag = 0;
                break;
            }
        }
        if (flag == 0) // flag = 0 이면 틀린거라서 틀린 스킬셋이므로 답에서 하나씩 차감, flag는 원래대로 돌려주고 그릇도 리셋해준다
        {
            answer--;
            flag = 1;
        }
        get_skill.erase(get_skill.begin(), get_skill.end());
    }
    
    return answer;
}

int main()
{
    string skill = "CBD";
    vector<string> skill_trees = { "BACDE", "CBADF", "AECB", "BDA" };
    cout << solution(skill, skill_trees);

}
```
