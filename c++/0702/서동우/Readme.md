```C++
/*
  백준 3009번 문제 : 네번째 점
  다른 3좌표가 주어졌을때 좌표끼리 직사각형이되는 다른 1좌표를 구하는 문제
*/
#include <iostream>
using namespace std;

int main()
{
	int x, y;
	int tempX = 0;
	int tempY = 0;
	int t = 3;
	while (t)
	{
		cin >> x >> y;
		tempX = tempX ^ x;
		tempY = tempY ^ y;
		t--;
	}
	cout << tempX << " " << tempY << endl;
 	return 0;
}
```

```C++
/*
   백준 1002번 문제 : 터렛
   두 원의 중심 좌표와 반지름이 주어졌을때, 두 원의 접점이 몇개인지 카운트하는 문제
*/

/*
   1. 접점 2개 : 두 원의 반지름 > 
   2. 접점 1개
   3. 접점 0개
   4. 접점 무한개 : -1 으로 반환
*/
#include <iostream>
using namespace std;

int main()
{
	int TestCase = 0;
	int x1, y1, r1;  // 첫번째 원
	int x2, y2, r2;  // 두번째 원
	int d, res1, res2;  // d : 두 점 사이의 거리
	cin >> TestCase;

	for (int i = 0; i < TestCase; i++)
	{
		cin >> x1 >> y1 >> r1 >> x2 >> y2 >> r2;
		d =  (x1 - x2) * (x1 - x2)  +  (y1 - y2) * (y1 - y2);
		res1 = (r1 - r2) * (r1 - r2);
		res2 = (r1 + r2) * (r1 + r2);

		if (d == 0)   // 두 점 사이의 거리가 0 => 두 원의 중심좌표가 같을때
		{
			if (res1 == 0) cout << -1 << endl;  // 반지름이 같다 => 원이 겹치므로 접점이 무한개 => -1 반환
			else           cout << 0 << endl;   // 반지름이 다르다 => 원의 접점이 없으므로 접점이 0개
		}

		// 두 점 사이의 거리가 0이 아닐때
		else if (d == res1 || d == res2) cout << 1 << endl;  // 원의 내접 or 외접해서 접점이 1개 
		else if (res1 < d && d < res2)   cout << 2 << endl;  // 두 원이 접점 2개가 되도록 겹치는 경우
		else                             cout << 0 << endl;  // 원이 아예 안겹치는 경우
	}
}
```
