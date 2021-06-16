```C++
/*
	프로그래머스 Lv2 : 다음 큰 숫자
	n의 다음 큰 숫자를 결정하는 문제.
	1. n의 다음 큰 숫자는 n보다 큰 자연수
	2. n의 다음 큰 숫자와 n은 2진수로 변환했을때 1의 개수가 같다.
	3. n의 다음 큰 숫자는 조건 1, 2를 만족하는 수 중 가장 작은수
*/

/*
	구현
	1. 입력받은 수(n => temp)의 2진수 변환했을때의 1의 개수(tempcount) 구하기
	2. 입력받은 수 + 1(res) 의 2진수 변환했을때의 1의 개수(rescount) 구하기
	3. 만약 1단계, 2단계 의 1의 개수가 같다면(tempcount == rescount) 종료후에 n 반환
	4. 만약 1의 개수가 같지 않다면 2단계를 while문에서 다음 숫자를 1씩 증가시키면서(temp = ++n;) 무한반복
*/


#include <iostream>
#include <string>
#include <vector>
using namespace std;

int solution(int n)
{
	int answer = 0;

	int temp = n;      // 입력받은 수를 temp에 대입
	int tempcount = 0; // 2진수 변환했을때 1을 count 해줄 변수


	// 2진수 변환하면서 1을 count하는 while문
	while (temp)
	{
		if(temp % 2 == 1) tempcount++;  
		temp = temp / 2;
	}
	

	// 다음 숫자를 찾기위한 while문
	while (1)
	{
		int rescount = 0;  // 2진수 변환했을때 1을 count 해줄 변수
		int res = ++n;     // n을 ++하면서 찾아줄 예정
		while (res)        // res의 2진수 변환
		{
			if (res % 2 == 1) rescount++;  // 2진수로 변환했을때 1의 개수 count해줌
			res /= 2;
		}
		if (tempcount == rescount) break;  // temp의 1개수 == res의 1개수가 같으면 while 문 종료
	}
	
	answer = n;            // while문이 종료됬을때 n의 값을 출력
	cout << n << endl;

	return answer;
}

int main()
{
	solution(78);
	solution(15);

	return 0;
}
```
