```C++
#include <stdio.h>

typedef struct
{
	int weight;	// 사람의 몸무게
	int height;	// 사람의 키
	int rank;	// 사람의 등수
} Human;

int main()
{
	int N, i, j;
	Human ary[100];			// 인원들을 담을 배열

	scanf("%d", &N);

	// 1. N명의 인원 입력
	for (i = 0; i < N; i++)
	{
		scanf("%d%d", &ary[i].weight, &ary[i].height);
		ary[i].rank = 1;	// 모든 인원의 첫 랭크는 1
	}

	// 2. 각 인원의 랭크 설정
	// 한 인원당 전체 인원 수 만큼 반복문을 실행하여
	// 해당 인원보다 덩치가 큰 인원이 있는 경우
	// 랭크 + 1 실행
	for (i = 0; i < N; i++)
	{
		for (j = 0; j < N; j++)
		{
			/*if (j == i)		// 자기 자신과 비교는 스킵하기위해
			{					// 하지만 없어도 상관 없다
				continue;
			}*/
			if ((ary[i].weight < ary[j].weight) && (ary[i].height < ary[j].height))
			{
				ary[i].rank++;
			}
		}
	}

	// 3. 전 인원의 랭크 출력
	for (i = 0; i < N; i++)
	{
		printf("%d ", ary[i].rank);
	}

	return 0;
}
```