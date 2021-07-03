### 네번째 점
```C++
#include <stdio.h>
#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int nx, ny;		// 입력받을 x, y 좌표
	vector<int> x;		// nx를 담을 벡터
	vector<int> y;		// ny를 담을 벡터
	int flx = 0;		// x좌표에 대한 플래그
	int fly = 0;		// y좌표에 대한 플래그
	int rx, ry;		// 주어진 사각형의 네번째 점의 좌표


	// 1. 직사각형의 세 점의 좌표를 입력 받는다.
	for (int i = 0; i < 3; i++)
	{
		cin >> nx >> ny;
		x.push_back(nx);
		y.push_back(ny);
	}

	// 2. 주어진 x, y 벡터로 네번째 점을 구해야 하는데,
	//    축에 평행한 직사각형의 좌표는 한 규칙이 있다.
	//    점의 x 좌표는 2개의 숫자가 각각 2개씩 있는 벡터로 이루어지고,
	//	  점의 y 좌표 역시 동일하게 구성 된다.
	// ex) x : 5, 5, 7 이면 네번째 점의 x는 7이 되고,
	//     y : 1, 2, 1 이면 네번째 점의 y는 2가 된다.

	// 2-1. 사각형 첫번째 점을 기준으로
	//      해당 x가 벡터에 몇 개 있는지 판단한다.
	for (int i = 0; i < 3; i++)
	{
		if (x[0] == x[i])
		{
			flx++;
		}
	}
	// 만약 첫번째 x가 1개밖에 없다면
	if (flx == 1) 
	{ 
		rx = x[0];			// 위의 규칙대로 네번째 점의 x는 첫번째 x가 되고,
	}
	// 첫번째 x가 2개라면
	else if (flx == 2)
	{
		for (int i = 0; i < 3; i++)	// 벡터에서 첫번재 x와 다른 x를 찾아(1개 밖에 없을테니)
		{
			if (x[0] != x[i])
			{
				rx = x[i];	// 네번째 점의 x로 정한다.
			}
		}
	}
	// 2-2. y역시 동일한 방법으로 정한다.
	for (int i = 0; i < 3; i++)
	{
		if (y[0] == y[i])
		{
			fly++;
		}
	}
	if (fly == 1)
	{
		ry = y[0];
	}
	else if (fly == 2)
	{
		for (int i = 0; i < 3; i++)
		{
			if (y[0] != y[i])
			{
				ry = y[i];
			}
		}
	}

	// 3. 구하고자는 점의 x, y 출력
	cout << rx << " " << ry;

	return 0;
}
```

### 터렛
```C++
#include <stdio.h>
#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

int main()
{
	int T;				// 테스트 케이스 수
	vector<int> vx1;		// 좌표1의 x좌표
	vector<int> vy1;		// 좌표1의 y좌표
	vector<int> vr1;		// 좌표1의 타겟과 거리
	vector<int> vx2;		// 좌표2의 x좌표
	vector<int> vy2;		// 좌표2의 y좌표
	vector<int> vr2;		// 좌표2의 타켓과 거리

	int x1;				// 사용자 입력 받을 변수들
	int y1;
	int r1;
	int x2;
	int y2;
	int r2;				// 요기까지

	int idx = 0;			// 반복문에 사용될 벡터 인덱스
	vector<int> vcnt;		// 최종 반환할 타겟 좌표 수


	// 타겟 좌표는
	// 원점:좌표1, 반지름:r1인 원1과 -> 좌표1에서 존재가능한 타겟의 집합
	// 원점:좌표2, 반지름:r2인 원2를 -> 좌표2에서 존재가능한 타겟의 집합
	// 가정하여 겹치는 경우를 찾아 그 갯수를 구한다.

	// 1. 테스트할 케이스의 수를 입력받는다.
	cin >> T;
	
	// 2. T만큼 케이스 별 데이터를 입력받는다.
	//    데이터는 바로 해당 벡터에 들어간다.
	for (int i = 0; i < T; i++)
	{
		cin >> x1 >> y1 >> r1 >> x2 >> y2 >> r2;
		vx1.push_back(x1);
		vx2.push_back(x2);
		vr1.push_back(r1);
		vy1.push_back(y1);
		vy2.push_back(y2);
		vr2.push_back(r2);
	}

	// 3. 완성된 벡터들로 타겟 좌표들의 수를 구한다.
	while (1)
	{
		// 3-1. 좌표1과 좌표2의 데이터가 모두 같은 경우
		//      타겟 좌표 수는 무한대 이므로 cnt는 -1이 된다.
		if (vx1[idx] == vx2[idx] && vr1[idx] == vr2[idx] && vy1[idx] == vy2[idx])
		{
			vcnt.push_back(-1);
		}
		else 
		{
			// 3-2. 두 원의 원점간 거리와
			//      두 반지름을 더한 거리가 같은 경우(외접) 이거나
			//      두 반지름을 뺀 거리가 같은 경우(내접) 이면 좌표 수는 1개.
			if (pow(vx2[idx] - vx1[idx], 2) + pow(vy2[idx] - vy1[idx], 2) == pow(vr1[idx] + vr2[idx], 2) ||
				pow(vx2[idx] - vx1[idx], 2) + pow(vy2[idx] - vy1[idx], 2) == pow(vr1[idx] - vr2[idx], 2))
			{
				vcnt.push_back(1);
			}
			// 3-3. 두 원의 원점간 거리가
			//      두 반지름을 더한 거리보다 작고,
			//      두 반지름을 뺀 거리보다 큰 경우(두 점에서 만남) 좌표 수는 2개.
			else if (pow(vx2[idx] - vx1[idx], 2) + pow(vy2[idx] - vy1[idx], 2) < pow(vr1[idx] + vr2[idx], 2) &&
				pow(vx2[idx] - vx1[idx], 2) + pow(vy2[idx] - vy1[idx], 2) > pow(vr1[idx] - vr2[idx], 2))
			{
				vcnt.push_back(2);
			}
			// 3-4. 두 원의 원점이 같지만 반지름이 다른경우,
			//      두 원점의 원점도 다르고 접점이 없는경우 좌표 수는 0개.
			else
			{
				vcnt.push_back(0);
			}

			// 홍렬 법칙 실패
			/*for (int i = vx1[idx] - vr1[idx]; i <= vy1[idx] + vr1[idx]; i++)
			{
				for (int j = vx1[idx] - vr1[idx]; j <= vy1[idx] + vr1[idx]; j++)
				{
					if (pow(i - vx1[idx], 2) + pow(j - vy1[idx], 2) == pow(vr1[idx], 2) &&
						pow(i - vx2[idx], 2) + pow(j - vy2[idx], 2) == pow(vr2[idx], 2))
					{
						cnt++;
					}
				}
			}*/
		}

		idx++;
		if (idx == T) break;
	}

	// 4. 3에서 만든 좌표 수 벡터를 하나씩 출력한다.
	for (int i = 0; i < vcnt.size(); i++)
	{
		cout << vcnt[i] << '\n';
	}

	return 0;
}
```
