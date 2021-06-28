## 점프와 순간이동
```C++
/*
   프로그래머스 : 점프와 순간이동
   한번에 K칸을 앞으로 점프하면 배터리가 닳고,
   (현재까지온 거리) * 2 에 해당하는 위치로 순간이동(이때 배터리안닳음)

   의 기능을 하는 2가지의 슈트가 있다.
   이 슈트를 착용하고 N만큼 떨어져있는 장소로 이동하려고할때, 배터리 사용량을 최솟값으로 return하는 문제
*/

/*
   구현
   1. n이 주어지면 n이 0이 될때까지 2로 나눠줌.
   2. n을 나머지 연산했을때 n이 홀수면은 ans에 ++이됨
   3. n이 0이되면 ans를 반환
*/

#include <iostream>
using namespace std;

int solution(int n)
{
    int ans = 0;

    while (n > 0)
    {
        ans += n % 2;
        n /= 2;
    }

    cout << ans << endl;
    return ans;
}

int main()
{
    solution(5000);
    solution(6);

    return 0;
}
```

<br><br>

## 영어끝말잇기
```C++
/*
   프로그래머스 : 영어끝말잇기
   한 사람씩 순서대로 차례대로 단어를 말하면, 끝의 알파벳과 똑같은 알파벳으로 시작하는 단어를 말하는 문제.
   이때 탈락했다면 그 사람은 몇번째 사람인지, 몇번째 순서로 탈락했는지 반환하는 문제
*/

/*
   구현
   1. 주어진 words의 크기만큼 for문을 돌림 (i는 1부터 시작)
   2. i번째의 첫번째 알파벳, i - 1 번째의 끝 알파벳 비교
   3. 이전에 중복된 단어 있는지 비교
   4. 턴과 카운트를 반환

*/
#include <string>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

vector<int> solution(int n, vector<string> words)
{
	vector<int> answer;
	vector<string> temp;
	int turn = 1, count = 1;

	answer.push_back(0);
	answer.push_back(0);
	temp.push_back(words[0]);

	for (int i = 1; i < words.size(); i++)
	{
		turn++;

		if (words[i].front() == words[i - 1].back())          // i - 1 번째의 마지막 알파벳, i번째의 첫 알파벳 비교
		{
			if (find(temp.begin(), temp.end(), words[i]) == temp.end())  // temp 벡터에 단어가 있는지 검사
			{
				if (i == words.size() - 1)                    // 만약 마지막 단어일때는 바로 answer를 리턴(마지막이면 실패가 아니니까 그대로 0,0을 리턴)
				{
					return answer;                           
				}
				temp.push_back(words[i]);                     // temp에 단어가 없으면 temp에 단어를 넣어줌
			}
			else break;                                       // 중복되는 단어가있으면 즉시 종료
		}
		else break;                                           // i - 1 번째의 마지막 알파벳, i번째의 첫 알파벳이 다르면 즉시 종료


		if (turn == n)       // turn == n이되면 다시 처음으로 돌아와야하니 turn에 0 대입해줌
		{
			count++;
			turn = 0;
		}

	}
	answer[0] = turn;
	answer[1] = count;

	cout << answer[0] << " " << answer[1] << endl;
	return answer;
}

int main()
{
	vector<string> 개어렵네 = { "tank", "kick", "know", "wheel", "land", "dream", "mother", "robot", "tank" };
	//                           1        2       3       1        2       3        1          2       3
	solution(3, 개어렵네);  // 3명이서 temp의 끝말잇기시작

	vector<string> 매우어렵네 = { "hello", "one", "even", "never", "now", "world", "draw" };
	solution(2, 매우어렵네);
}
```
