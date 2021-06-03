
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


<br><br><br>

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

<br><br>


### 벡터
벡터란? STL(Standard Template Library)에 속해 있는 컨테이너 중 하나로써, 배열처럼 객체들을 순차적으로 보관하는 컨테이너이다. <br>
다 필요없고 쉽게말하면 '가변길이 배열' 이라고 생각하는게 편하다. <br>
'가변길이 배열'은 만약 데이터를 할당된 크기를 초과하면 그만큼 자동으로 크기가 늘어난다는 특징이있다. <br>

#### 벡터 사용법 및 초기화
```C++
vector<자료형> 변수명                        :  vector 변수 생성
vector<자료형> 변수명(숫자)                   : vector 변수 생성 및 숫자만큼 size, 초기값 0
vector<자료형> 변수명 = {x, y, z, ... }      : vector 생성 후, 오른쪽 변수 x, y, z 등의 값으로 초기화
vector<vector<자료형>> 변수명                : 2차원 벡터 생성(열과 행 모두 가변길이)
vector.assign(범위, 초기값)                  : 범위만큼 초기값으로 초기화
```

```C++
#include <vector>                        // 벡터를 쓰기위한 헤더파일
using namespace std;
int main() 
{
	vector<int> v;                   // int형 백터 생성
	vector<int>v(3);                 // int형 백터 생성 후 크기를 3으로 할당 및 0으로 초기화 : {0, 0, 0}
	vector<int>v = {1, 2, 3};        // int형 백터 생성 후 1, 2, 3 으로 초기화
	vector<vector<int>> v;           // 2차원 백터 생성(행과 열 모두 가변)
	vector<int> v = {1, 2, 3, 4, 5}; // 크기가 5인 벡터 생성
	v.assign(5, 10);                 //크기 5만큼 10으로 초기화 : {10, 10, 10, 10, 10}
}
```

<br>

#### 벡터 요소 접근
```C++
vector.front()  : vector의 첫번째 요소 접근 
vector.back()   : vector의 마지막 요소 접근(size-1) 
vector.at(i)    : vector의 i 번째 요소 접근 (0 부터 시작) 
vector[i]       : vector의 i 번째 요소 접근 (0부터 시작)
```

```C++
#include <vector>
using namespace std;
int main() 
{
	vector<int> v = { 1, 2, 3, 4};     // 벡터 선언하고, 벡터안에 1, 2, 3 4를 넣어줌(초기화)
	cout << v.front() << endl;         // 1
	cout << v.back() << endl;          // output : 4
	cout << v.at(1) << endl;           // output : 2
	cout << v[2] << endl;              // output : 3
}
```

<br>

#### 벡터 요소 삽입, 제거
```C++
vector.push_back(A)                      : 벡터 마지막에 요소 A 추가 
vector.pop_back()                        : 벡터의 마지막 요소 제거 
vector.insert(삽입할 주소, A)             : 원하는 위치에 요소 A 삽입 
vector.erase(삭제할 주소)                 : 원하는 위치의 요소 제거 
vector.erase(삭제 시작 주소, 삭제 끝 주소) : 원하는 위치의 요소 제거 
vector.clear()                           : 벡터의 모든 요소 제거(size = 0) 
vector.resize(X)                         : 벡터의 size를 X로 변경
                                           기존 size 초과 시 자동으로 0으로 초기화
```

```C++
#include <vector>

int main()
{
    vector<int> v;

    v.push_back(10);
    v.push_back(20);                 // v = { 10, 20 }

    v.inset(v.begin() + 1, 100);     // v = { 10, 100, 20 }

    v.pop_back();                    // v = { 10, 100 }

    v.emplace_back(1);               // v = { 10, 100, 1 }
    v.emplace_back(2);               // v = { 10, 100, 1, 2 }
    v.emplace(v.begin() + 2, -50);   // v = { 1, 100, -50, 1, 2 }

    v.erase(v.begin() + 1);          // v = { 1, -50, 1, 2 }
    v.resize(6);                     // v = { 1, -50, 1, 2, 0, 0 }
    v.clear();                       // v = empty()     
}
```

<br>

#### 벡터 용량
```C++
 v.empty()	    : 백터가 빈공간이면 true, 값이 있다면 false 
 v.size() 	    : 백터의 크기 반환 
 v.capacity()	    : heap에 할당된 백터의 실제크기(최대크기) 반환 
 v.max_size()	    : 백터가 system에서 만들어 질 수 있는 최대 크기 반환 
 v.reserve(숫자)	  : 백터의 크기 설정 
 v.shrink_to_fit()  : capacity의 크기를 백터의 실제 크기에 맞춤 
```

```C++
#include <vector>

int main()
{
	vector<int>v = { 1, 2, 3, 4 };

	cout << v.size() << endl;        // output : 4
	cout << v.capacity() << endl;    // output : 10 (컴파일 환경에 따라 달라질 수 있음)

	v.reserve(6);
	cout << v.capacity() << endl;    // output : 6
	cout << v.max_size() << endl;    // output : 1073741823(시스템 성능에 따라 달라질 수 있음)

	v.shrink_to_fit();
	cout << v.capacity() << endl;    // output : 4

	cout << v.empty() << endl;       // output : false
	v.clear();
	cout << v.empty() << endl;       // output : true
}
```
