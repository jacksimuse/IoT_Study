```C++
#include <iostream>
#include <string>
#include <vector>

using namespace std;

int solution(int n) {
	int ary[1000];		// n의 3진수를 담을 배열
	int index = 0;		// ary의 마지막 인덱스(3진수 총 자리수)
	int res = 0;		// 최종 반환 변수
	int i;

	// 1. n을 3진수로 변환. n -> ary
	while (1)
	{
		ary[index] = n % 3;	// ary[0]을 시작으로 3진수 첫 자리부터 대입 시작
		n /= 3;				// 다음 피제수
		if (n == 0) break;	// 피제수가 0이면(3진수 변환 완료) 반복문 탈출
		index++;			// 3진수 변환마다 +1
	}

	// 2. n(3)을 앞 뒤 반전. ary 앞 뒤 반전
	int temp;		// swap을 위한 임시 변수
	int j = index;	// ary의 마지막 인덱스
	for (i = 0; i <= index / 2; i++)	// 앞뒤 반전을 위해 처음부터 배열의 중간까지 수행
	{
		//swap
		temp = ary[i];
		ary[i] = ary[j];
		ary[j] = temp;
		j--;
	}
	
	// 3. 반전한 n(3)을 10진수로 변환. ary -> res
	int three = 1;					// 3진수 변환을 3의 거듭제곱을 담을 변수
	for (i = 0; i <= index; i++)
	{
		res += ary[i] * three;		// 3진수 변환
		three *= 3;					// 다음 거듭제곱 만들기
	}
	
	return res;
}

int main()
{
	int res = 0;

	res = solution(125);
	cout << res;
}
```