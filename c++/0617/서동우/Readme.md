```C++
/*
	프로그래머스 완전탐색 Lv2 : 소수찾기
	숫자로 이루어진 문자열 numbers가 주어졌을때 각 숫자의 조합으로 만들 수 있는 소수가 몇개인지 구하는 문제
*/

/*
	구현
	1. 정수로 이루어진 문자열을 쪼개기(num 벡터, allnum 벡터에 저장)
	2. next_permutation 함수를 이용해서 각 숫자의 조합을 찾아서 allnum에 저장
	3. allnum의 중복 제거 후 소수를 찾아서 반환
*/

#include <iostream>
#include <algorithm>
#include <vector>
#include <string>
using namespace std;


/// <summary>
/// 소수를 찾는 함수
/// </summary>
bool isSosu(int n)
{
	if (n < 2) return false;     // 만약 0, 1이면 함수 종료

	for (int i = 2; i < n; i++)
	{
		if (n % i == 0) return false;  // 2부터 n-1 까지 나눠서 만약 나누어떨어지는게 있으면 소수가 아니므로 함수 종료
	}

	return true;     // 여기까지 왔으면 소수이므로 true 반환
}


/// <summary>
/// solution
/// </summary>
int solution(string numbers)
{

	vector<int> num;             // 한 자리수씩 쪼갰을때 받는 벡터
	vector<int> allnum;          // 모든 숫자를 받을 벡터
	int len = numbers.size();

	for (int i = 0; i < len; i++)   // 문자열을 한 자리씩 쪼개기
	{
		num.push_back(numbers[i] - '0');
		allnum.push_back(numbers[i] - '0');
	}

	sort(num.begin(), num.end());   // next_permutation 함수를 쓰기위해 정렬

	do
	{
		for (int i = 2; i <= len; i++)    // i가 2부터 시작하는 이유는 2자리수 ~ len자리수까지 구하기 위함
		{
			string temp = "";             // 숫자조합을 받을 임시 문자열 변수
			for (int j = 0; j < i; j++)   // 0부터 numbers의 배열 크기만큼 for문 돌림
			{
				temp += num[j] + '0';
			}
			allnum.push_back(stoi(temp)); // 합쳐진 숫자를 정수로 변환해서 allnum에 저장
		}

	} while (next_permutation(num.begin(), num.end()));  // 숫자를 섞어줌


	// 중복제거
	sort(allnum.begin(), allnum.end());
	allnum.erase(unique(allnum.begin(), allnum.end()), allnum.end());


	// 소수 찾기(벡터의 요소를 하나씩 검사해서 소수인지 판별)
	int answer = 0;
	for (int i = 0; i < allnum.size(); i++)
	{
		if (isSosu(allnum[i]))  // 만약 소수면 answer를 ++해줌
		{
			answer++;
		}
	}

	// 소수개수인 answer를 반환
	cout << answer << endl;
	return answer;
}

int main()
{
	solution("1234");
	//solution("011");

	return 0;
}




/*
do while문 상세

// numbers = "1234"   를 예시로 들기

len = numbers.size();  이므로 len = 4

do
	{
		for (int i = 2; i <= len; i++)     // i는 2부터 4까지 for문 돌림
		{
			string temp = "";  
			for (int j = 0; j < i; j++)    // 0부터 i까지 for문 돌림  // i가 2면 2자리수, i가 3이면 3자리수, i가 4면 4자리수가 되는 것임
			{
				temp += num[j] + '0';      // 임시 변수에 숫자의 조합을 저장(12, 23, 34, 13, ... , 123, 234, 124, ... , 4자리수 등등)
			}
			allnum.push_back(stoi(temp));  // 합쳐진 숫자를 정수로 변환해서 allnum에 저장
		}

	} while(next_permutation(num.begin(), num.end()));  // 숫자를 섞어줌

*/
```
