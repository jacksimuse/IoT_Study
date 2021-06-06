```C++
#include <iostream>
using namespace std;

int main()
{
	int i, j;			// 반복문용
	int val = 1;		// 달팽이에 들어갈 숫자
	int n;				// 달팽이의 크기
	int ary[100][100];	// 달팽이 배열
	int r = 0, c = -1;	// 달팽이 배열의 행과 열
	int turn = 1;		// 달팽이에 대입하는 방향을 바꿔줄 변수

	cin >> n;

	int ogn = n;		// 달팽이 전체 출력을 위한 n을 저장

	// 달팽이 채우기 ㅎ
	while (n > 0)
	{
		for (i = 0; i < n; i++)
		{
			c += turn;
			ary[r][c] = val++;
		}

		n--;						// 한 행(or열)의 대입을 끝내고
									// 다음 대입할 행(or열)이 한 칸씩 작아지므로
		if (n == 0) break;

		for (i = 0; i < n; i++)
		{
			r += turn;
			ary[r][c] = val++;
		}

		turn *= -1;					// 한 번의 행과 열의 대입을 끝내고 대입방향을 바꿔준다
	}

	// 달팽이 출력띠
	for (i = 0; i < ogn; i++)
	{
		for (j = 0; j < ogn; j++)
		{
			cout << ary[i][j] << " ";
		}
		cout << endl;
	}

	return 0;
}
```