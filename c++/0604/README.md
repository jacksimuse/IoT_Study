# 삼각 달팽이

[문제 참고 링크](https://codepractice.tistory.com/81)

----
[삼각달팽이](https://programmers.co.kr/learn/courses/30/lessons/68645?language=cpp)
----
![image](https://user-images.githubusercontent.com/73567433/120744828-d35e2380-c536-11eb-8687-cac32c11d8bf.png)
![image](https://user-images.githubusercontent.com/73567433/120744837-d8bb6e00-c536-11eb-9a89-e5c5ce225eba.png)

# 삼각 달팽이 이론
```C
#include <stdio.h>
#include <stdlib.h>


/*
0.↓ [1][0]		진행되는 방향을 배열로 표현
1.→ [0][1]
2.↖ [-1][-1]

1				구현되야하는 그림
2 9
3 10 8
4 5  6  7
*/

int main(int argc, char* argv[]) {

	int dy[3] = { 1, 0, -1 };	// 3가지 방향이므로 양의 방향 1, 자기 행 0, 음의 방향 -1
	int dx[3] = { 0, 1, -1 };	// 3가지 방향이므로 양의 방향 1, 자기 열 0, 음의 방향 -1
	int cycle = 0;

	// arr[y][x]
	int** arr = NULL;	// 2차 배열에 대한 이중포인터
	int y, x;

	int i, j;
	int N, len, count = 1;	// 숫자를 받을 N, len은 진행되면서 감소될 N을 표현, count는 진행되면서 커질 수를 표현

	scanf("%d", &N);
	len = N;


	arr = (int**)malloc(sizeof(int*) * N);	// 2차 배열을 N의 크기만큼 할당해준다
	for (i = 0; i < N; i++)
		arr[i] = (int*) malloc(sizeof(int) * (i + 1));	// 2차 배열속 하나의 요소를 담당

	y = -1; x = 0;	// 시작되자마자 밑으로 진행되므로 시작 자리가 0,0 인점을 생각하여 -1, 0로 값을 준다
	while (len) {	// len이 0이면 false기 때문에 알아서 종료
		for (i = 0; i < len; i++) {	// len만큼 진행
			y = y + dy[cycle];	
			x = x + dx[cycle];
			arr[y][x] = count++;	// 진행되면서 해당자리에 숫자 증가
		}

		cycle = (cycle + 1) % 3;	// 배열에 세 숫자만 있으므로 % 3해서 돌려쓴다
		len--;	// -1씩하여 4 - 3 - 2 - 1 같이 진행 시켜준다
	}


	for (i = 0; i < N; i++) {	// 배열을 프린트 해주는 곳
		for (j = 0; j < i + 1; j++)
			printf("%3d ", arr[i][j]);
	
		printf("\n");
	}

	return 0;
}
```
