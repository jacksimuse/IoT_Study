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
