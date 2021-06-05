달팽이배열 성장일지


#### 4x4 사각 달팽이배열

```C
#include <stdio.h>

int main()
{
	int n = 4;
	int arr[4][4];

	int value = 1;  // 배열 요소의 값(1부터시작)

	int x = 0;      // 가로
	int y = -1;     // 세로

	int inc = 1;   // 지금 배열의 위치를 올려야하는지 내려야하는지 판단해주는 변수

	while (n > 0)
	{
		for (int i = 0; i < n; i++)  // 가로 값
		{
			y += inc;
			arr[x][y] = value;
			value++;
		}
		n--;
		if (n == 0) break;   // n = 0이면 배열의 값 설정이 끝난거임

		for (int i = 0; i < n; i++)  // 세로 값
		{
			x += inc;
			arr[x][y] = value;
			value++;
		}
		inc *= -1;
	}


	for (int i = 0; i < 4; i++)
	{
		for (int j = 0; j < 4; j++)
		{
			printf("%3d", arr[i][j]);
		}
		printf("\n");
	}


	return 0;
}
```

### 동적으로 값을받아서 사각달팽이배열 출력

```C
#include <stdio.h>

int main()
{
	int x = 0;      
	int y = -1;     
	int inc = 1;    // 지금 배열의 위치를 올려야하는지 내려야하는지 판단해주는 변수
	int value = 1;  // 배열에 입력할 데이터값(1부터 시작)


	int n;           // 입력받을 숫자(이 숫자에따라 배열의 크기가 결정)
	printf("달팽이 배열의 크기 : ");
	scanf_s("%d", &n);


	int N = n;  // 입력받은 n의 원본을 저장할 변수
	

	// 배열을 동적할당(입력받은 수 * 입력받은 수  만큼의 배열을 메모리에 동적할당)
	int** arr = (int**)malloc(sizeof(int*) * n);
	for (int i = 0; i < n; i++)
	{
		arr[i] = (int*)malloc(sizeof(int) * n);
	}


	while (n > 0)
	{
		for (int i = 0; i < n; i++)  // 가로 값 arr[고정][y로인해 변함]
		{
			y += inc;
			arr[x][y] = value;
			value++;
		}
		n--;                      // 더하는 개수를 --해서 줄여줌
		if (n == 0) break;        // n = 0이면 배열의 값 설정이 끝난거임 => 반복문 종료

		for (int i = 0; i < n; i++)  // 세로 값  arr[x로인해 변함][고정]
		{
			x += inc;
			arr[x][y] = value;
			value++;
		}
		inc *= -1;                   // -1을 곱해줘서 인덱스가 더 상승하는지, 떨어져야하는지 바뀜
	}



	// 저장한 배열 출력
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N; j++)
		{
			printf("%3d", arr[i][j]);
		}
		printf("\n");
	}


	return 0;
}
```


#### 삼각달팽이배열 도전중(3*3까지는 완료)
```C
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>


void Tri_snail(int* arr, int N, int ArrSize, int value, int Len, int depth)
{
	int n = N;
	int arrSize = ArrSize;
	int len = Len + (4 * depth);
	//int len = Len;


	for (int i = 0; i < n; i++)
	{
		len += i;
		arr[len] = value;
		value++;
	}

	n--;
	if (n == 0) return;

	for (int i = 0; i < n; i++)
	{
		arr[arrSize - N + 1 + i] = value;
		value++;
	}

	n--;
	if (n == 0) return;

	len = arrSize - N - 1;
	for (int i = 0; i < n; i++)  // 0 1 2
	{
		arr[len] = value;
		value++;
		len -= N - 1 - i;
	}

	n--;
	if (n == 0) return;
	
	
	// 오른쪽 대각선까지했는데 안쪽 삼각형부터는 모르겠음... 우얘하누?
	/*if (ArrSize >= value)
	{
		Tri_snail(arr, n, arrSize, value, 0, depth + 1);
	}*/
}



int main()
{
	int n;
	
	int value = 1;
	printf("배열의 크기 입력 : ");
	scanf_s("%d", &n);

	int arrSize = (n * (n + 1)) / 2;

	int *arr = (int*)malloc(sizeof(int) * arrSize + 1);  // 요소개수만큼 동적할당

	int len = 0;
	int depth = 0;


	Tri_snail(arr, n, arrSize, value, len, depth);
	


	for (int i = 0; i < arrSize; i++)
	{
		printf("%3d", arr[i]);
	}

	printf("\n");

	return 0;
}
```
