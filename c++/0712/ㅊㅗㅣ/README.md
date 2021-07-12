# N개의 최소공배수
```c++
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<int> arr) {
    int answer = 0;
    int flag = 0; // 원소가 약수인지 확인하는 flag
    int i = 1;  // 반복시켜줄 i
    sort(arr.begin(), arr.end()); // 맨 큰 수를 뒤로 놓기 위한 정렬
    int temp; // 맨 큰 수를 늘려나갈 temp

    while(true)
    {
        temp = arr[arr.size() - 1] * i; // 맨 큰수를 점점 키운다
        for (int j = 0; j < arr.size(); j++)
        {
            if (temp % arr[j] == 0) flag += 1;  // 해당원소가 키운 큰수의 약수이면 flag를 올린다
        }
        if (flag == arr.size()) // flag가 배열크기와 같으면 모두 해당하는 최소공배수가 되었다.
        {
            answer = temp;
            break;
        }
        flag = 0; // 초기화
        i++;
        
    }

    return answer;
}

int main()
{
    vector<int> arr = { 1,2,3 };
    cout << solution(arr);
}
```
