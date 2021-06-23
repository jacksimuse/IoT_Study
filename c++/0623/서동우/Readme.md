```C++
/*
    프로그래머스 스킬트리
    스킬을 찍어야하는 순서가 있다.(선행 스킬이 있다)
    문자배열로 이루어진 스킬트리가 주어졌을때, 문자열이 선행 스킬에 맞게 잘 찍은게 몇개인지 반환하는 문제
*/

/*
    구현
    1. 임시로 받을 벡터 temp 선언
    2. skill_trees 배열을 for문으로 검사해서 skill과 같은 요소가있으면 temp에 전부 담아줌
    3. temp와 skill을 비교해서 순서가 맞는지 확인
    4. 순서가 맞으면 answer++하고 반환
*/

#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(string skill, vector<string> skill_trees) 
{
    int answer = 0;

    // 모든 경우의 스킬트리 검색
    for (int i = 0; i < skill_trees.size(); i++)
    {
        vector <char> temp;  // 임시 벡터 temp 선언
        
        for (int j = 0; j < skill_trees[i].size(); j++)  // 스킬트리가 2차원 배열이니 for문 2번 돌림
        {
            for (int k = 0; k < skill.size(); k++)
            {
                if (skill_trees[i][j] == skill[k])       // skill_trees 중에 skill과 일치하는 문자를 temp에 저장
                {
                    temp.push_back(skill_trees[i][j]);
                }
            }
        }
        
        int flag = 0;
        for (int j = 0; j < temp.size(); j++)  // temp의 길이만큼 skill을 비교하여 순서가 일치하는지 확인
        {
            if (temp[j] != skill[j])
            {
                flag = 1;
                break;
            }
        }
      
        if (flag == 0)   // 일치하면 answer++
        {   
            answer++;
        }
    }
    cout << answer << endl;
    return answer;
}

int main()
{
    solution("CBD", { "BACDE", "CBADF", "AECB", "BDA" });

    return 0;
}

```
