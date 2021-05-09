```C
/* 2차원 배열의 크기를 알릴 N,M을 설정 300까지
배열 안에 받을 수는 10000보다 작은 정수
합을 구할 부분의 개수 K를 받는다 10000이하
K 다음 줄에는 네 개의 정수 좌표 i, j, x, y가 주어진다*/

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int main()
{
	int range[300][300] = {0}; // 2차원 배열 방이 300개짜리
	int N, M, K; // 행 렬 받을 N, M 행렬을 더할거 반복하는 K
	int a, b, x, y; // 행렬 좌표 a, b / x, y
	int i, j; // 반복문 돌릴 i, j
	
	scanf("%d %d", &N, &M);
	
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < M; j++)
		{
			scanf(" %d", &range[i][j]); // 각 방에 숫자를 받는다
		}
	}

	
	int sum = 0; // 각 행렬을 더해줄 sum

	scanf(" %d", &K); // K만큼 돌릴려고 숫자 받기

	for (i = 0; i < K; i++)
	{
		scanf(" %d %d %d %d", &a, &b, &x, &y); // 좌표 받기

		for (i = a - 1; i < x; i++)
		{
			for (j = b - 1; j < y; j++)
			{
				sum += range[i][j]; // 각 행렬을 더해준다
			}
		}
		printf("%d\n", sum);
		sum = 0; // 다음 좌표를 위해 0으로 
	}
}
