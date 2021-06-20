### 순열
서로 다른 n개 중에서 r개를 취하여 일렬로 세워놓은 것   
순서를 따진다. -> abc와 acb는 서로 다른 순열   
중복을 허용하지 않는다.   
<br>

### next_permutation()을 이용한 순열 정렬
```C++
#include <algorithm>	// next_permutation()을 사용하기 위한 헤더

next_permutation(a.begin(), a.end());
```
<br>

스트링 or 벡터의 시작 위치와 끝 위치를 인수로 범위를 넘겨주면   
다음 순열 모양새로 "정렬"시킨후 true를 반환하고 다음 순열이 없다면 false를 반환한다.   
```C++
#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main(){

	vector<int> v = {1, 2, 3};
	
  // 3P3 출력하는 코드

	do
	{
		for(int i = 0; i < v.size(); i++)
		{
			cout << v[i] << " ";
		}
		cout << '\n';

	}while(next_permutation(v.begin(),v.end()));   

}
```
<br>

```C++
1 2 3
1 3 2
2 1 3
2 3 1
3 1 2
3 2 1
```
<br>

만약 해당 스트링의 모든 순열을 만들고자 한다면   
사전순으로 가장 가까운 다음 상태로 정렬하므로   
오름차순으로 정렬을 한 다음 함수를 사용해야 한다.
<br>

### nPr의 경우
