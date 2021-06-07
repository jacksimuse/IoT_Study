```C++
/*
    프로그래머스 월간 코드 챌린지 시즌2 : 약수의 개수와 덧셈
    left, right 두 정수 값이 주어질때 left~right 값들의 약수의 개수를 구해서
    약수의 개수가 짝수면 +, 약수의 개수가 홀수면 -한 수를 return 하는 문제
*/

/*
    풀이
    2중 for문으로 첫번째 for문은 left ~ right 까지 돌림
                  두번째 for문은 1부터 첫번째 for문의 변수만큼 돌림
    두번째 for문에서 약수를 찾으면서 count를 ++해줌
    두번째 for문이 끝났을때 count값에따라 result에 짝수, 홀수 일때 더하거나 빼줌
*/

#include <stdio.h>
#include <vector>
#include <iostream>
using namespace std;



int solution(int left, int right)
{
    int result = 0;
    for (int i = left; i <= right; i++)   // left~right까지 for문 돌림
    {
        int count = 0;
        for (int j = 1; j <= i; j++)      // 1부터 i(첫번째 for문변수)까지 for문 돌림
        {
            if (i % j == 0)               // 만약 약수면 count++
            {
                count++;
            }
        }

        if (count % 2 == 0)               // 약수의 개수가 짝수면 result에 해당 정수를 더해줌
        {
            result += i;
        }
        else if (count % 2 != 0)          // 약수의 개수가 홀수면 result에 해당 정수를 빼줌
        {
            result -= i;
        }
    }

    return result;                        // result값 반환
}

int main()
{
    int a, b;
    cin >> a >> b;
    int res = solution(a, b);
    cout << res << endl;
}
```


```C
/*
    프로그래머스 두개뽑아서더하기(C)
	정수배열이 주어질때 서로 다른 두 개의 수를 뽑아 더해서 만들 수 있는 모든 수를
	오름차순으로 담아 return 하는 문제
*/

/*
	구현
	1. 두개를 더했을때 가장 큰 수를 찾아서 그 수만큼의 공간을가지는 bool형 배열 선언(가장 많은 개수만큼 만드는 경우임)
	2. bool형 배열의 모든 요소를 false로 초기화
	3. 두개를 더했을때의 경우의 수를 bool형 배열의 요소를 true로 바꿔줌( 2 + 1 = 3 이면 bool형배열[3] = true; 로 만들어줌)
	4. boolary의 true의 요소만큼의 크기를가지는 int형 배열선언
	5. boolary의 true를 가지는 인덱스를 int형 배열에 하나씩 넣어줌
	6. 출력
*/

#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int* solution(int arr[], size_t arr_len)
{
	int temp = 0;
	for (int i = 0; i < arr_len; i++)               // 1. 받은 배열에서 두가지를 더했을때 가장 큰 수를 찾기(temp에 저장)
	{
		for (int j = i + 1; j < arr_len; j++)
		{
			if (temp < arr[i] + arr[j])
			{
				temp = arr[i] + arr[j];
			}
		}
	}

	bool* boolary = (bool*)malloc(sizeof(bool) * temp + 1); //    가장 큰 수 만큼의 공간을 가지는 bool형 배열(boolary) 선언
	
	for (int i = 0; i <= temp; i++)                         // 2. bool형 배열의 요소를 전부 0으로 초기화
	{
		boolary[i] = false;
	}

	int boolCount = 0;                               // 3. 두 개를 더했을때의 경우의 수를 bool형 배열 요소에 true로 해줌.
	int count = 0;                                   //    예를들어 뽑은 수가 2, 1 이면 2 + 1 = 3 인데
	for (int i = 0; i < arr_len; i++)                //    boolary[3] = true;  가 되는것임
	{
		for (int j = i + 1; j < arr_len; j++)
		{
			boolCount = arr[i] + arr[j];             //    두 개를뽑아서 더한것을 boolCount에 저장
			if (boolary[boolCount] == false)         //    만약 boolCount가 false 가 아니면 ( => 중복방지)
			{
				boolary[boolCount] = true;           
				count++;                             //    boolary에서 true의 개수를 세기위한 count변수
			}
		}
	}

	int answerCount = 0;
	int* answer = (int*)malloc(sizeof(int) * count); // 4. boolary에서 true의 개수(count)만큼 int형 배열(answer) 선언
	for (int i = 0; i <= temp; i++)
	{
		if (boolary[i] == true)                      //    boolary의 요소중에 true인 인덱스를 answer의 처음부터 추가해줌
		{                                            //    예를들어 처음의 true값이 boolary[3] = true; 면
			answer[answerCount++] = i;               //    answer[0] = 3; 이 저장됨
		}
	}

	for (int i = 0; i < count; i++)                  //    answer에 저장된 배열 요소 출력
	{
		printf("%d ", answer[i]);
	}

	return answer;
}

int main()
{
	int arr1[4] = { 5,0,2,7 };
	int arr2[5] = { 2, 1, 3, 4, 1 };
	solution(arr2, 5);
}
```


```C
/*
    프로그래머스 : 음양더하기
    길이가 같은 정수배열, bool형 배열을 받고
    bool형 배열의 true인 인덱스에는 양수,
                  false인 인덱스에는 음수로해서 정수배열들의 합을 반환하는 문제
*/

/*
    구현
    1. bool형 배열의 false인 인덱스를 구하기
    2. 해당하는 인덱스의 정수배열의 요소에 -1을해서 음수로 만들어줌
    3. 정수배열의 모든 요소를 더해줌
    4. result값 반환
*/

#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int absolutes[], size_t absolutes_len, bool signs[], size_t signs_len) 
{
    int result = 0;
    for (int i = 0; i < signs_len; i++)     // bool형 배열 요소가 false인 인덱스에 -1을 곱해서 정수 배열 요소에 음수로 만들어줌
    {
        if (signs[i] == false)
        {
            absolutes[i] *= -1;
        }
    }

    for (int i = 0; i < absolutes_len; i++)  // 모든 정수배열요소의 합을 result에 저장
    {
        result += absolutes[i];
    }
    
    printf("%d\n", result);
    return 0;
}

int main()
{
    int absolutes[3] = { 4, 7, 12 };
    bool signs[3] = { true, false, true };

    solution(absolutes, 3, signs, 3);
}
```
