# 최댓값과 최솟값
```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;
using std::stoi;  // string을 int로 변형

string solution(string s) {
  string answer = "";
	vector<int> num;  // 변형된 숫자를 받을 num
	string number;  // 숫자단위로 잘라서 담을 number
	int temp; // string에서 int로 담을 temp
	int max, min; // 최댓값, 최솟값 받기
	int i = 0;  // i로 돌려서 빈칸일 때마다 자르기

	while (i <= s.size()) // 받아오는 문자열의 길이만큼 돌린다
	{
		while (s[i] != ' ') // 공백일때마다 끊는다
		{
			number += s[i]; // 공백 이전의 숫자가 하나의 숫자이므로 더해준다
			i++;  // i를 늘려준다
			if (i == s.size()) break;
		}
		temp = stoi(number);  // 잘라온 숫자를 int형으로 변형
		number.erase(number.begin(), number.end()); // 숫자받는 그릇을 초기화
		num.push_back(temp);  // 숫자만 있는 vector에 저장
		i++;
	}

	max = num[0]; // 최대 최소값을 나타낼 반복문
	min = num[0];
	for (int i = 0; i < num.size(); i++)
	{
		for (int j = 0; j < num.size(); j++)
		{
			if (num[j] > max) max = num[j];
		}
	}
	for (int i = 0; i < num.size(); i++)
	{
		for (int j = 0; j < num.size(); j++)
		{
			if (num[j] < min) min = num[j];
		}
	}

	string a = to_string(min);  // 최소 최대값이 정해진후 다시 문자열로 변형
	answer += a;  // 답 칸에 넣고 공백으로 구분
	answer.push_back(' ');
	
	string b = to_string(max);
	answer += b;
	
    return answer;
}

int main()
{
	string s = "-10 -20 -30 -40";
	cout << solution(s) ;

}
```
