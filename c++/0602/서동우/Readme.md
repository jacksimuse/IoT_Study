```C
/*
	3진수 뒤집기
	1. 10진수를 입력받으면 3진수로 변환
	2. 3진수를 뒤집어서(1100이면 0011로 바꿈) 다시 10진수로 변환하는 문제

	구현
	1. 입력받은 수를 3진수로 변환(while문을 통해 arr1에 나머지 연산의 값을 하나씩 저장)
	2. arr1의 배열을 뒤집어서 arr2에 저장
	3. arr2로 각 배열의 요소에 3의 거듭제곱을 곱해서 10진수로 변환하여 result 에 저장
	4. result 반환
*/


#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
using namespace std;

int solution(int n)
{
	int arr1[1000] = { 0 };  // 3진수로 나눴을때 저장할 배열
	int arr2[1000] = { 0 };  // arr1에서 뒤집어서 저장할 배열

	int count = 0;   // 배열 요소 인덱스
	int result = 0;  // 최종 결과 변수

	
	// 만약 값이 3보다 작으면 그대로 반환(1이나 2이면 뒤집어도 그대로 1, 2가 되기때문)
	if (n < 3)
	{
		return n;
	}

	// 3진수 변환
	while (1)
	{
		arr1[count] = n % 3; 
		n /= 3;

		count++;   // 인덱스 증가

		if (n < 3)  //
		{
			arr1[count] = n;
			break;
		}
	}

	// 배열 뒤집기 
	// arr1 끝부터 처음까지의 값이 
	// arr2의 처음부터 끝까지의 값이됨
	for (int i = 0; i < count + 1; i++)
	{
		arr2[i] = arr1[count - i];
	}


	
	// 3진수를 10진수로 변환(arr2의 각 요소에 3의 거듭제곱을 곱해서 다 더해줌)
	int temp = 1;
	for (int i = 0; i < count + 1; i++)
	{
		result += arr2[i] * temp;
		temp = temp * 3;
	}

	printf("%d\n", result);     // result 출력(내가 확인하는 용도)

	return result;              // result 반환(문제에서는 printf 지우고 return해주면됨)
}

int main()
{
	solution(45);   // 7 출력
	solution(125);  // 229 출력
	solution(1);    // 1 출력
}
```
