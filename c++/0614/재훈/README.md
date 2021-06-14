#include <string>
#include <vector>
#include <iostream>
using namespace std;

string solution(string number, int k) {
    string answer = "";
    string temp = number;
    int count = 0;
    
    for (int i = 1; i < number.size(); i++)
    {
        if (number[i] > number[i - 1])
        {
            number.erase(number.begin() + i - 1);
            count++;
            i = 0;
            if (count == k) break;
        }
    }
    
    answer = number;
    return answer;
}

int main()
{
    string num;
    int k;
    cin >> num >> k;
    cout << solution(num, k);
}
