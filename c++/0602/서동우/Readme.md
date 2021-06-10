
## C로 쌩으로 풀기
```C++
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

------------------------------

<br>

## 벡터로 문제풀기
```C++
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include <iostream>
using namespace std;

int solution(int n) {
    int answer = 0;
    vector<int> v_arr;                        // 벡터 v_arr 선언
    
    while(n)
    {
        v_arr.push_back(n % 3);               // v_arr.push_back()  => 벡터의 마지막 부분에 새로운 요소를 추가해줌 
	                                      // 따라서 나머지 연산의 결과값을 벡터에 하나씩 저장됨
        n /= 3;
    }
    
    reverse(v_arr.begin(), v_arr.end());      // reverse(시작점, 끝점) => 본인이 리버스 하고싶은 위치의 첫번째, 마지막을 넣으면 원본 데이터가 reverse됨
                                              // 따라서 v_arr의 요소를 처음부터 끝까지 => 요소를 끝까지에서 시작으로 뒤집어줌
    
    for(int i = 0; i < v_arr.size(); i++)     // v_arr.size() => 벡터의 크기를 반환해줌
        answer += pow(3, i) * v_arr[i];       // pow(3, i) => 3의 i제곱근을 구현해주는 함수
    
    return answer;
}
```
----------------------

<br><br>
