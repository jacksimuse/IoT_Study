```C++
#include <string>
#include <vector>
#include <algorithm>
#include <iostream>
using namespace std;

bool compare(string a, string b)
{
    int numA = stoi(a);
    int numB = stoi(b);
    if (numA <= numB)
    {
        return true;
    }
    else
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
        if (s[i] == ' ') 
        {
            v.push_back(sub);
            sub = "";
            continue;
        }
        else 
        {
            sub += s[i];
        }
    }
    v.push_back(sub);

    sort(v.begin(), v.end(), compare);

    answer += v[0];
    answer += " ";
    answer += v[v.size() - 1];

    return answer;
}

```
