## 백준 7568번 문제 (덩치)
```C++
/*
백준 7568번 문제 (덩치)
키와 체중을 입력받고 키와 체중 둘 다 클때 덩치가 더 크다 라고 말한다.

예를들어 A(x,y), B(p,q) 일때
x > p, y > q 이면 A가 B보다 덩치가 더 크다.

근데 만약 A(45, 181), B(55, 171) 이면
45 < 55, 181 > 173 이므로 A가 몸무게는 크지만 키는 B가 더 크므로 누가 크다고 볼 수 없다.
=> 공동 순위를 갖게됨
*/

/*
구현 순서
1. 구조체로 체중, 키, 랭크 선언
2. 구조체 배열 선언후에 입력받은 횟수만큼 for문으로 입력받음
3. for문 두번써서 현재 사람, 다음 사람을 비교해서 다음 사람이 더 크면 현재 사람의 등수를 +1 해줌
4. 등수만 출력
*/

#include <iostream>
using namespace std;


typedef struct person
{
	int weight;      // 체중
	int height;      // 키
	int rank = 1;    // 모두 1등으로 시작
}Human;


int main()
{
	Human arr[51];
	int count = 0;
	int num;

	cin >> num;

	// 횟수 입력받기
	for (int i = 0; i < num; i++)
	{
		cin >> arr[i].weight >> arr[i].height;
	}


	// 신장, 체중 비교
	for (int i = 0; i < num; i++)
	{
		for (int j = i+1; j < num; j++)
		{
			if (arr[i].weight < arr[j].weight && arr[i].height < arr[j].height)   // 처음부터 (마지막 - 1) 까지 비교
			{
				arr[i].rank++;
			}
			else if (arr[i].weight > arr[j].weight && arr[i].height > arr[j].height) // 마지막인 경우
			{
				arr[j].rank++;
			}
		}
	}

	// 등수 출력
	for (int i = 0; i < num; i++)
	{
		cout << arr[i].rank << " ";
	}
}
```
