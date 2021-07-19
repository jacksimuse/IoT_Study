```C++
/*
  프로그래머스 Lv2 최댓값과 최소값
  공백으로 구분된 숫자가 저장되어있는 문자열에서 최솟값, 최댓값을 반환하는 문제
*/

/*
  구현
  1. 문자열을 한칸씩 검사해서 sub에 문자열 한칸을 넣어줌
  2. 이때 ' '를 만나면 문자열 벡터 v에 넣어줌 ("-1 -2" 일때 -1이 sub에 들어가고, ' '일때 벡터에 -1이 들어감)
  3. 벡터를 compare 함수에 따라 정렬(오름차순, 내림차순)
  4. 벡터 처음값, 마지막값을 answer에 저장하고 반환
*/

#include <string>
#include <vector>
#include <algorithm>
#include <iostream>
using namespace std;

bool compare(string a, string b)  // 맨 처음 숫자가 음수인지, 양수인지 판별하는 플래그
{
    int numA = stoi(a);
    int numB = stoi(b);
    if (numA <= numB)   // 맨 마지막 숫자가 더 크므로 내림차순
    {
        return true;
    }
    else   // 맨 마지막 숫자가 더 작으므로 오름차순으로 정렬
    {
        return false;
    }
}

string solution(string s) 
{
    vector<string> v;
    string answer = "";
    string sub = "";

    for (int i = 0; i < s.size(); i++) 
    {
        if (s[i] == ' ')  // 만약 공백을 만나면 sub에 있는 문자열이 벡터에 저장됨
        {
            v.push_back(sub);
            sub = "";     // sub에는 다시 빈값을 저장
            continue;
        }
        else              // 공백 만나기전까지 문자열을 sub에 저장
        {
            sub += s[i];
        }
    }
    v.push_back(sub);

    sort(v.begin(), v.end(), compare);  // compare값에 따라 오름차순, 내림차순 정렬

    answer += v[0];            // 맨처음값 answer에 저장(최소)
    answer += " ";
    answer += v[v.size() - 1]; // 맨마지막값 answer에 저장(최대)

    cout << answer << endl;
    return answer;
}

int main()
{
    solution("1 2 3 4");
    solution("-1 -2 -3 -4");
    return 0;
}
```
