# 덩치

```C++
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <iostream>
using namespace std;

int main()
{
	int T;
	int spec[][50] = { {0}, {0} }; // 몸무게와 키를 2차 배열로 받음
	int w, h, grade[50] = { 0 }; // 등급을 받을 배열 0으로 초기화

	cin >> T;

	for (int i = 0; i < T; i++)
	{
		grade[i] += 1;  // 1부터 시작해야되서 다시 1을 다 더해줌
	}

	for (int i = 0; i < T; i++) // 각 배열에 몸무게와 키 입력받기
	{
		cin >> w >> h;

		spec[0][i] = w;
		spec[1][i] = h;
	}
	for (int i = 0; i < T; i++)
	{
		for (int j = 0; j < T; j++)
		{
			if (spec[0][i] < spec[0][j] && spec[1][i] < spec[1][j]) grade[i] += 1;  // 맨처음부터 끝까지 돌면서 비교하고 덩치가 작으면 등급이 1올라감
		}
	}
  
	for (int i = 0; i < T; i++)
	{
		cout << grade[i] << " "; // 등급을 담은 배열을 출력
	}
}
```
