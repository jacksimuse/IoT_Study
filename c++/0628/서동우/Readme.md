## 다리위를 지나는 트럭
```C++
/*
   프로그래머스 스택/큐 : 다리를 지나는 트럭
   트럭의 개수와 무게, 다리에 올라갈 수 있는 트럭 수, 다리가 견딜 수 있는 무게가 주어질때
   모든 트럭이 다리를 건너려면 최소 몇 초가 걸리는지 return 하는 문제
*/

/*
   구현
   1. 제일 처음 나온게 제일 빨리 빠져나가는(FIFO) 방식을 떠올려서 큐를 만들어서 풀었습니다.
   2. 걸리는 시간(Time), 다리위 트럭들의 무게합(weightSum), 다리위 트럭리스트를 큐, 몇번째 트럭인지 알게해줄 idx 선언
   
   3. 다리에 트럭이 올라갈때마다 weightSum에 무게를 더하고, 그 트럭을 큐에 넣음
   4. 큐가 점점 쌓이면서 .size()가 다리의 길이와 같아지면 트럭이 도착했다는 의미이므로 트럭을 빼면서 무게도 빼줌(이때 idx++해줌)
   5. 만약 마지막 트럭이면 굳이 무게합을 더하거나 큐에 넣지말고 다리 길이만큼 Time에 더해줘서 종료시킴
*/
#include <string>
#include <vector>
#include <iostream>
#include <queue>
using namespace std;

int solution(int bridge_length, int weight, vector<int> truck_weights)
{
    int Time = 0;          // 걸린 시간 (answer)
    int weightSum = 0;     // 다리 위 트럭들의 무게 합
    queue<int> on_bridge;  // 다리 위 트럭 리스트
    int idx = 0;           // 트럭의 인덱스(몇번째 트럭인지)


    while (1)
    {
        Time++;  // 1초 추가

        // 다리위 트럭의 사이즈가 다리 길이와 같다 = 트럭이 도착했으니 빼줘야함
        if (on_bridge.size() == bridge_length) 
        {
            weightSum = weightSum - on_bridge.front(); // 트럭이 빠진만큼 무게합에서 빠진 트럭의 무게를 빼줌
            on_bridge.pop();    
        }


        if (weightSum + truck_weights[idx] <= weight)  // 트럭 추가할 수 있으면 추가
        { 
            if (idx == truck_weights.size() - 1)       // 지금이 마지막 트럭인 경우 => 다리길이만큼 Time에 더해주고 종료
            {                                          // (마지막 트럭이 다리 길이만큼가고 끝내면되니까)
                Time += bridge_length;
                break;
            }

            on_bridge.push(truck_weights[idx]);       // 현재 트럭을 큐에 추가
            weightSum += truck_weights[idx];          // 추가된 트럭의 합을 무게합에 추가
            idx++;                                    // 다음 차례의 트럭을 세기위해 idx를 ++해줌
        }
        else 
        {
            on_bridge.push(0);                        // 트럭을 더 못 올리면 0으로 트럭 밀어주기
        }
    }

    cout << Time << endl;
    return Time;
}

int main()
{
    solution(2, 10, { 7,4,5,6 });
    solution(100, 100, { 10 });
    return 0;
}
```
