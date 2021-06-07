# 약수의 개수와 덧셈
```C++
#include <string>
#include <vector>
#include <iostream>
using namespace std;

int solution(int left, int right) {
    int answer = 0;
    
    while (left != right + 1) // 왼쪽이 오른쪽 + 1 전까지 될때까지 진행
    {
        int cnt = 0;  // 약수의 개수를 세준다
        for (int i = 1; i <= left; i++)
        {
            if (left % i == 0) cnt++; // 약수는 맞어 떨어지는 값이므로 나머지가 0일때만 카운트한다
        }
        if (cnt % 2 == 0) answer += left; // 카운트가 짝수이면 나눠지는 수를 답에 더한다
        else answer -= left;    // 홀수면 빼준다
        left++; // 왼쪽의 수를 진행시키면서 오른쪽으로 진행시킴
    }
    return answer;
}

int main()
{
    int a, b; // 숫자 두개 받을 변수
    cin >> a >> b;
    printf("%d", solution(a, b));
}
```
# 두개 뽑아서 더하기
```C++
#include <vector>
#include <iostream>
using namespace std;

vector<int> solution(vector<int> numbers) {
    vector<int> answer;     // 답을 받을 배열
    int box;                // 정렬을 위한 그릇
    
    for (int i = 0; i < numbers.size(); i++)    // 배열 사이즈만큼 돌기
    {
        for (int j = 1; j < numbers.size(); j++)
        {
            if (i == j) continue;   // 같은 수는 받지말기
            answer.push_back(numbers[i] + numbers[j]);  // 앞뒤자리끼리 계속 더해서 배열에 담기
        }
    }

    for (int i = 0; i < answer.size(); i++) 
    {
        for (int j = answer.size() - 1; j >= 0; j--)    // i로 고정시키고 뒤에서 부터 비교하기
        {
            if (i == j) continue;   // 같은 자리는 패스
            if (answer[i] == answer[j])     // 요소가 같으면 삭제
                answer.erase(answer.begin() + j);
        }
    }

    for (int i = 0; i < answer.size(); i++)     // 정령
    {
        for (int j = i + 1; j < answer.size(); j++)
        {
            if (answer[i] > answer[j]) {
                box = answer[i];
                answer[i] = answer[j];
                answer[j] = box;
            }
        }
    }
    return answer;
}

int main()
{
    vector<int> input = { 0,0,1,1 };
    
    for (int i = 0; i < solution(input).size(); i++)
    {
        printf("%d ", solution(input)[i]);
    }
    
}
```
