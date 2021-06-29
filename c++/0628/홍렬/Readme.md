```C++
#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main()
{
    int bridge_length = 5;                                      // 다리의 길이(1에 한 대씩 있고, 1초에 1씩 움직임)
    int weight = 5;                                             // 다리가 버틸 수 있는 무게
    vector<int> truck_weights = { 2, 2, 2, 2, 1, 1, 1, 1, 1 };  // 다리 건너려고 대기 중인 트럭들의 무게(대기 장소로 볼 수 도 있다.)
    vector<int> on;                                             // 현재 다리 위에 있는 트럭들
    vector<int> out;                                            // 다리를 완전히 벗어난 트럭들
    vector<int> time;                                           // 트럭이 다리에 존재한 시간
    int sz = truck_weights.size();                              // 맨 처음 대기중이었던 트럭의 갯수
    int sum = 0;                                                // on에 있는 트럭들의 무게 총 합
    int cnt = 1;                                                // 최종 반환 값이 될 스테이지 수

    // 문제의 순서 표와 동일한 방식으로 실행된다.
    while (1)
    {
        // 1. 먼저 on -> out으로 갈 트럭이 있는지 판단한다.
        if (time.size() > 0 && time[0] == bridge_length)    // on의 트럭이 out으로 갈 시간이 됐는지 확인
        {                                                   // ex) 다리 길이 = 2, time = { 2, ... }일때
                                                            //     on의 첫번째 트럭은 out으로 간다.
            out.push_back(on[0]);
            on.erase(on.begin());
            time.erase(time.begin());                       // out으로 간 트럭의 time은 삭제한다.
        }

        // 2. 대기 장소 -> on으로 갈 트럭이 있는지 판단한다.
        // 2-1. 현재 on에 있는 트럭들의 무게를 구한다(= sum).
        sum = 0;
        for (int i = 0; i < on.size(); i++)
        {
            sum += on[i];
        }

        // 2-2. 위의 sum에 on으로 건너갈 트럭의 무게를 더한다.
        if (truck_weights.size() > 0)
        {
            sum += truck_weights[0];
        }

        // 2-3. 그렇게 구한 sum이 weight보다 작고, 현재 on의 트럭 수가 다리 길이보다 작은 경우
        // 대기 장소에서 on으로 트럭 한 대 넘긴다.
        if (sum <= weight && on.size() < bridge_length)
        {
            if (truck_weights.size() > 0)
            {
                on.push_back(truck_weights[0]);             // on에 한 대 넘기고
                truck_weights.erase(truck_weights.begin()); // 해당 트럭은 대기 장소에서 지운다.
            }

            time.push_back(0);                              // on에 왔으므로 해당 트럭의 time을 만든다.
            for (int i = 0; i < time.size(); i++)           // 시간이 1초 흘렀으므로 on의 모든 트럭의 시간을
            {                                               // 1초씩 더해준다.
                time[i]++;
            }
        }
        else                                                // 위의 해당 사항이 아닌 경우에도
        {                                                   // 그래도 시간은 1초 흘렀으니
            for (int i = 0; i < time.size(); i++)           // on트럭들의 시간을 1초 증가 시킨다.
            {
                time[i]++;
            }
        }

        // 3. 1과 2과정을 거쳐 out에 모든 트럭이 도달한 경우
        if (out.size() == sz) break;    // 다리 건너기 종료

        cnt++;                          // 한 스테이지가 종료한 경우 전체 진행 시간 1씩 플러스한다.
                                        // 다리 건너기 종료시점의 cnt가 최종 걸린 시간
    }

        // 원래는 대기장소 -> on -> out순으로 프로세스가 진행돼야 하지만
        // 그렇게 코드를 짜니 문제의 표대로 진행이 안돼서
        // on -> out을 먼저 시킨다음 대기장소 -> on을 진행했다.
        // 처음 on -> out 과정에서 맨 처음의 상황을 배제하고 반복문을 돌리는 방식이라
        // 전체적으로 보면 대기장소 -> on -> out순으로 진행된다고 볼 수 있다.
        
    cout << cnt;

    return 0;
}
```