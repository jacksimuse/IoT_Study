# 네번째 점
```C++
#include <iostream>
using namespace std;

int main()
{
	int x1, x2, x3; // x 좌표 3개
	int y1, y2, y3; // y 좌표 3개
	
	cin >> x1 >> y1;  // 좌표 입력
	cin >> x2 >> y2;
	cin >> x3 >> y3;

	if (x1 == x2) // 비교해서 같은게 있으면 들어가고 다른 x, y 좌표를 출력하면 안찍힌 x, y좌표가 된다
	{
		if (y1 == y2)
		{
			cout << x3 << " " << y3;
		}
		else if (y1 == y3)
		{
			cout << x3 << " " << y2;
		}
		else if (y2 == y3)
		{
			cout << x3 << " " << y1;
		}
	}
	else if (x1 == x3)
	{
		if (y1 == y2)
		{
			cout << x2 << " " << y3;
		}
		else if (y1 == y3)
		{
			cout << x2 << " " << y2;
		}
		else if (y2 == y3)
		{
			cout << x2 << " " << y1;
		}
	}
	else if (x2 == x3)
	{
		if (y1 == y2)
		{
			cout << x1 << " " << y3;
		}
		else if (y1 == y3)
		{
			cout << x1 << " " << y2;
		}
		else if (y2 == y3)
		{
			cout << x1 << " " << y1;
		}
	}
}
```

# 터렛
#include <iostream>
#include <math.h>
#include <cmath>
using namespace std;

int main()
{
	int x1, y1, r1;
	int x2, y2, r2;
	int T,i = 0;

	cin >> T;
	for (int i = 0; i < T; i++)
	{
		cin >> x1 >> y1 >> r1 >> x2 >> y2 >> r2;
		int between_x = x1 - x2;
		if (between_x < 0) between_x *= -1;	// x간의 거리 절대값
		int between_y = y1 - y2;
		if (between_y < 0) between_y *= -1;	// y간의 거리 절대값

		int round = pow(between_x, 2) + pow(between_y, 2);	// 원을 그린다

		// 두 터렛의 위치가 동일한 경우
		if (round == 0 && r1 == r2) cout << -1 << endl;	// 터렛 위치가 같고 반지름이 같음
		else if (round == 0 && r1 != r2) cout << 0 << endl;	// 터렛 위치가 같고 반지름이 다름
	
		// 두 터렛의 위치가 다른 경우
		// 한점에서 만나는 경우 외점, 내점
		else
		{
			if (round == pow((r1 - r2), 2) || round == pow((r1 + r2), 2)) cout << 1 << endl;  // 터렛 위치가 다르고 반지름도 다름, 반지름이 상대거리와 같을때

			// 두점에서 만나는 경우
			else if (round < pow((r1 + r2), 2) && round > pow((r1 - r2), 2)) cout << 2 << endl;  // 터렛 위치가 다르고 반지름도 다름, 반지름이 상대거리보다 작거나 클떄
			else cout << 0 << endl;
		}
	}
}
