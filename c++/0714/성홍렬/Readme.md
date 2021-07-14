```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    int n = 10;			// 변환할 자연수
    int namuge;		        // 자연수를 3으로 나눈 나머지
    string answer;		// 최종 반환 스트링


	// 1. 3진법을 응용하여 나머지에 따라 1, 2, 4 중 하나를 answer에 대입
	while (1)
	{
		namuge = n % 3;				// 나머지 연산을 통한 나머지 변수 초기화
		
		if (namuge == 1)			// 나머지가 1인 경우
		{
			answer.push_back('1');		// 스트링에 '1'을 넣는다
		}
		else if (namuge == 2)			// 나머지가 2인 경우
		{
			answer.push_back('2');		// 스트링에 '2'를 넣는다
		}
		else if (namuge == 0)			// 나머지가 3인 경우
		{
			answer.push_back('4');		// 스트링에 '4'를 넣은 후
			n--;				// 피제수를 1 감소 시킨다
							// 이유↓
							// ex) n = 6인 경우 -> answer = "14"가 되어야 한다.
							// 1. 6 % 3 = 0이므로 스트링에 4를 넣는다.
							// 2. 다음 피제수는 2(= 6 / 3)가 된다.
							// 3. 하지만 2 % 3 = 2 이므로 answer = "24"가 된다.
							// 4. 그러므로 2번에서 피제수를 1 감소시키게 되면
							// 5. 1 % 3 = 1이 되어 answer = "14"가 되는 올바른 결과를 얻는다.
		}

		n /= 3;					// 다음 자리 숫자를 구하기 위한 피제수
		if (n == 0) break;			// 피제수가 0인 경우 반복문 탈출
	}

	// 2. 1번 과정의 계산은 스트링에 원하는 값을 반대로 넣는 과정이므로
	//    전체 스트링을 한 번 뒤집어준다.
	int temp;					// swap을 위한 임시 변수
	int j = answer.size() - 1;			// answer의 마지막 인덱스
	for (int i = 0; i < answer.size() / 2; i++)	// 앞뒤 반전을 위해 처음부터 배열의 중간까지 수행
	{
		//swap
		temp = answer[i];
		answer[i] = answer[j];
		answer[j] = temp;
		j--;
	}
	
	// 3. 전체 스트링 출력
	for (int i = 0; i < answer.size(); i++)
	{
		cout << answer[i];
	}

    return 0;
}
```
